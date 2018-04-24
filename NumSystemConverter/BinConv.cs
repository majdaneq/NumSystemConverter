using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NumSystemConverter
{
    class BinConv : TabToConvert
    {
        double convert;
        double result = 0;
        StringBuilder converted = new StringBuilder();
        double varRes = 0;
        string varResult;
        LayoutSingleton layoutSingleton;

        public BinConv() { }

        public BinConv(LayoutSingleton _layoutSingleton)
        {
            layoutSingleton = _layoutSingleton;
            varResult = layoutSingleton.number.Text;           
        }       

        public string BinToDec(string number)                                                        //10 bit res
        {
            var digits = new List<char>();                                              //conversion to int array           
            for (int n = number.Length - 1; n >= 0; n--)
                digits.Add(number[n]);                                                  
            var arr = digits.ToArray();
            Array.Reverse(arr);                                                         //binary input eg 10(10) -> 1010(2)
            int m = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                varRes = Convert.ToDouble(new string(arr[i], 1)) * Convert.ToDouble(Math.Pow(2, m));
                convert = convert % 10;
                m++;
                result += varRes;
            }  
            return Convert.ToString(result);
        }

        public string BinToOct(string number)
        {
            string converted = number;           
            switch (converted.Length % 3)                                                  
            {
                case 1:
                    converted = converted.Insert(0, "00"); break;
                case 2:
                    converted = converted.Insert(0, "0"); break;                         //if 0 is missing add it           
            }

            //check how long is the binary number

            int divider = converted.Length / 3; 

            // dividing string into 3 elements arrays             
            string var="";

            for (int q=0;q<divider;q++)
            {
                var += setTabOct(converted.Substring(3*q, 3));
            }
            return var;            
        }

        public string BinToHex(string number)                                         //16bit
        {
            string varResultHex = number;
            switch (varResultHex.Length % 4)                                       //making a 4*digit 
            {
                case 1:
                    varResultHex =  varResultHex.Insert(0, "000");
                    break;
                case 2:
                    varResultHex =  varResultHex.Insert(0, "00");
                    break;
                case 3:
                    varResultHex = varResultHex.Insert(0, "0");
                    break;
            }

            //check how long is the binary number

            int divider = varResultHex.Length / 4;
            string var = "";

            for (int q = 0; q < divider; q++)
            {
                var += setTabHex(varResultHex.Substring(4 * q, 4));
            }
            return var;           
            
        }    

    }
}

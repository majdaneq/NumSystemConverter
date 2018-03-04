﻿using System;
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
    class BinConv : Converter
    {   public BinConv()
        {

        }
        TextView txtDec, txtHex, txtOct;
        double convert;
        double result = 0;
        string finalresult;
        double varRes = 0;
        string varResult;
        string res;

        public BinConv(TextView t1, TextView t2, TextView t3, TextView t4, string numberToConvert)
        {
            txtDec = t3;
            txtHex = t4;
            txtOct = t2;            
            varResult = numberToConvert; 
        }

        public string BinToDec(double _convert)                                        //10 bit res
        {
            var digits = new List<char>();                               //conversion to int array           
            for (int n = varResult.Length - 1; n >= 0; n--)
                digits.Add(varResult[n]);
            var arr = digits.ToArray();
            Array.Reverse(arr);
            int m = 0;

            for (int i = varResult.Length - 1; i >= 0; i--)
            {
                varRes = Convert.ToInt32(new string(arr[i], 1)) * Convert.ToInt32(Math.Pow(2, m));
                convert = convert % 10;
                m++;
                result += varRes;
            }

            finalresult = Convert.ToString(result);

            return finalresult;
        }

        public string BinToOct()
        {
            string varResultOct = varResult;
            switch (varResult.Length % 3)                                       //making a 4*digit 
            {
                case 1:
                    varResultOct = varResultOct.Insert(0, "00"); break;
                case 2:
                    varResultOct = varResultOct.Insert(0, "0"); break;                
            }

            //check how long is the binary number

            int divider = varResultOct.Length / 3;           
            string varResult1 = "";
            string varResult2 = "";
            string varResult3 = "";
            string varResult4 = "";
            string varResult5 = "";
            string varResult6 = "";
            // dividing string into 4 elements arrays 
            int i = 0;
            string var;

            switch (divider)
            {
                case 0: return "ERROR";

                case 1: return setTabOct(varResultOct);
                case 2:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        
                        i++;
                    }
                        res = setTabOct(varResult1);
                        var = res;
                        res = setTabOct(varResult2);
                        var += res;
                    return var;
                case 3:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        
                        i++;
                    }
                    res = setTabOct(varResult1);
                    var = res;
                    res = setTabOct(varResult2);
                    var += res;
                    res = setTabOct(varResult3);
                    var += res;
                    return var;
                case 4:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        
                        i++;
                    }
                    res = setTabOct(varResult1);
                    var = res;
                    res = setTabOct(varResult2);
                    var += res;
                    res = setTabOct(varResult3);
                    var += res;
                    res = setTabOct(varResult4);
                    var += res;
                    return var;
                case 5:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];    //backbackback
                        
                        i++;
                    }
                    res = setTabOct(varResult1);
                    var = res;
                    res = setTabOct(varResult2);
                    var += res;
                    res = setTabOct(varResult3);
                    var += res;
                    res = setTabOct(varResult4);
                    var += res;
                    res = setTabOct(varResult5);
                    var += res;
                    return var;
                case 6:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];    //backbackback
                        varResult6 += varResultOct[i + 15];
                        
                        i++;
                    }
                    res = setTabOct(varResult1);
                    var = res;
                    res = setTabOct(varResult2);
                    var += res;
                    res = setTabOct(varResult3);
                    var += res;
                    res = setTabOct(varResult4);
                    var += res;
                    res = setTabOct(varResult5);
                    var += res;
                    res = setTabOct(varResult6);
                    var += res;
                    return var;

                default: return "ERROR";
                    
            }  
        }

        public string BinToHex(double _convert)                    //16bit
        {
            //convert = _convert;
           // varResult = Convert.ToString(convert);

            string varResultHex = varResult;
            switch (varResultHex.Length % 4)                                       //making a 4*digit 
            {
                case 1:
                    varResultHex =  varResultHex.Insert(0, "000"); break;
                case 2:
                    varResultHex =  varResultHex.Insert(0, "00"); break;
                case 3:
                    varResultHex = varResultHex.Insert(0, "0"); break;
            }

            //check how long is the binary number

            int divider = varResultHex.Length / 4;
            short decision = 0;
            string varResult1="";
            string varResult2="";
            string varResult3 = "";
            string varResult4 = "";
            string varResult5 = "";
            string varResult6 = "";
            // dividing string into 4 elements arrays 
            int i = 0;
            string var;
                switch (divider)
            {
                case 0: return "ERROR";

                case 1: return setTab(varResultHex);
                case 2:
                    while (i< 4)
                        {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        decision = 2;
                        i++;
                        }
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    return var;
                    
                case 3:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        decision = 3;
                        i++;
                    }
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    res = setTab(varResult3);
                    var += res;
                    return var;
                    
                case 4:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        decision = 4;
                        i++;
                    }
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    res = setTab(varResult3);
                    var += res;
                    res = setTab(varResult4);
                    var += res;
                    return var;
                    
                case 5:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        decision = 5;
                        i++;
                    }
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    res = setTab(varResult3);
                    var += res;
                    res = setTab(varResult4);
                    var += res;
                    res = setTab(varResult5);
                    var += res;
                    return var;
                case 6:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        i++;
                    }
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    res = setTab(varResult3);
                    var += res;
                    res = setTab(varResult4);
                    var += res;
                    res = setTab(varResult5);
                    var += res;
                    res = setTab(varResult6);
                    var += res;
                    return var;
                default: return "ERROR";
            }
        }

        string setTab(string varResult)
        {
            switch (varResult)
            {
                case "0000": return "0";
                case "0001": return "1";
                case "0010": return "2";
                case "0011": return "3";
                case "0100": return "4";
                case "0101": return "5";
                case "0110": return "6";
                case "0111": return "7";
                case "1000": return "8";
                case "1001": return "9";
                case "1010": return "A";
                case "1011": return "B";
                case "1100": return "C";
                case "1101": return "D";
                case "1110": return "E";
                case "1111": return "F";
                default: return "ERROR";

            }
        }

        string setTabOct(string varResult)
        {
            switch (varResult)
            {
                case "000": return "0";
                case "001": return "1";
                case "010": return "2";
                case "011": return "3";
                case "100": return "4";
                case "101": return "5";
                case "110": return "6";
                case "111": return "7";

                default: return "ERROR";

            }
        }

        Array makeArray()
        {

            var digits = new List<int>();                               //conversion to int array           
            for (int n = Convert.ToInt32(convert); n != 0; n /= 10)
                digits.Add(n % 10);
            var arr = digits.ToArray();
            Array.Reverse(arr);

            return arr;
        }
    }
}

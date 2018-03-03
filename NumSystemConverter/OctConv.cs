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
    class OctConv : Converter
    {
        TextView txtDec, txtBin, txtHex;
        double convert;
        double result = 0;
        string finalresult;
        double varRes = 0;
        string varResult;
        string res;
        string binaryresult;

        public OctConv(TextView t1, TextView t2, TextView t3, TextView t4, double numberToConvert)
        {
            txtBin = t1;
            txtDec = t3;
            txtHex = t4;
            varRes = numberToConvert;
            varResult = Convert.ToString(varRes);
        }


        public string OctToBin()
        {
            var digit = new List<char>();

            for (int i = varResult.Length - 1; i >= 0; i--)
                digit.Add(varResult[i]);

            var arr = digit.ToArray();

            for(int i=arr.Length-1;i>=0;i--)
            {
                switch(arr[i])
                {
                    case '0': res += "000"; break;
                    case '1': res += "001"; break;
                    case '2': res += "010"; break;
                    case '3': res += "011"; break;
                    case '4': res += "100"; break;
                    case '5': res += "101"; break;
                    case '6': res += "110"; break;
                    case '7': res += "111"; break;
                }
            }
            binaryresult = res;
            return binaryresult;
        }

        public string OctToHex()
        {
            BinConv bin = new BinConv();
            return bin.BinToHex(Convert.ToDouble(binaryresult));
        }

        public string OctToDec()
        {
            BinConv bin = new BinConv();           
            return bin.BinToDec(Convert.ToDouble(binaryresult)); 
        }
    }
}
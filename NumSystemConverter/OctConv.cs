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
    class OctConv : BinConv
    {
        string varResult;
        string binaryResult;        
        private LayoutSingleton layoutSingleton;      

        public OctConv(LayoutSingleton _slayoutSingleton) : base()
        {
            layoutSingleton = _slayoutSingleton;
            varResult = layoutSingleton.number.Text;
        }

        public string OctToBin()
        {
            var digit = new List<char>();

            for (int i = varResult.Length - 1; i >= 0; i--)     //creating char array from number
                digit.Add(varResult[i]);
            var arr = digit.ToArray();

            for(int i=arr.Length-1;i>=0;i--)
            {
                switch(arr[i])
                {
                    case '0': binaryResult += "000"; break;
                    case '1': binaryResult += "001"; break;
                    case '2': binaryResult += "010"; break;
                    case '3': binaryResult += "011"; break;
                    case '4': binaryResult += "100"; break;
                    case '5': binaryResult += "101"; break;
                    case '6': binaryResult += "110"; break;
                    case '7': binaryResult += "111"; break;
                }
            }
            
            return binaryResult;
        }

        public string OctToHex()
        {
            return BinToHex(binaryResult);            
        }

        public string OctToDec()
        {
            return BinToDec(binaryResult);
        }      
    }
}
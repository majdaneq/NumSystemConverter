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
    class HexConv : BinConv
    {
        
        string varResult;
        string res;
        string binaryresult;

        LayoutSingleton layoutSingleton;

        public HexConv(LayoutSingleton _slayoutSingleton) : base()
        {
            layoutSingleton = _slayoutSingleton;
            varResult = layoutSingleton.number.Text;
        }

        public string HexToBin()
        {
            string varResultHex = varResult;

            for (int i = 0; i < varResultHex.Length; i++)
                switch (varResultHex[i])
                {
                    case '0': res += "0000"; break;
                    case '1': res += "0001"; break;
                    case '2': res += "0010"; break;
                    case '3': res += "0011"; break;
                    case '4': res += "0100"; break;
                    case '5': res += "0101"; break;
                    case '6': res += "0110"; break;
                    case '7': res += "0111"; break;
                    case '8': res += "1000"; break;
                    case '9': res += "1001"; break;
                    case 'A': res += "1010"; break;
                    case 'B': res += "1011"; break;
                    case 'C': res += "1100"; break;
                    case 'D': res += "1101"; break;
                    case 'E': res += "1110"; break;
                    case 'F': res += "1111"; break;
                    case 'a': res += "1010"; break;
                    case 'b': res += "1011"; break;
                    case 'c': res += "1100"; break;
                    case 'd': res += "1101"; break;
                    case 'e': res += "1110"; break;
                    case 'f': res += "1111"; break;
                    default: res += "error"; break;
                }
            binaryresult = res;
            return res;
        }

        public string HexToDec()
        {
            double resx = 0;

            string varResultDec = varResult;
            int m = 0;
            for (int i = varResultDec.Length - 1; i > -1; i--)
            {
                switch (varResultDec[i])
                {
                    case '0': resx += 0 * Math.Pow(16, m); break;
                    case '1': resx += 1 * Math.Pow(16, m); break;
                    case '2': resx += 2 * Math.Pow(16, m); break;
                    case '3': resx += 3 * Math.Pow(16, m); break;
                    case '4': resx += 4 * Math.Pow(16, m); break;
                    case '5': resx += 5 * Math.Pow(16, m); break;
                    case '6': resx += 6 * Math.Pow(16, m); break;
                    case '7': resx += 7 * Math.Pow(16, m); break;
                    case '8': resx += 8 * Math.Pow(16, m); break;
                    case '9': resx += 9 * Math.Pow(16, m); break;
                    case 'A': resx += 10 * Math.Pow(16, m); break;
                    case 'B': resx += 11 * Math.Pow(16, m); break;
                    case 'C': resx += 12 * Math.Pow(16, m); break;
                    case 'D': resx += 13 * Math.Pow(16, m); break;
                    case 'E': resx += 14 * Math.Pow(16, m); break;
                    case 'F': resx += 15 * Math.Pow(16, m); break;
                    case 'a': resx += 10 * Math.Pow(16, m); break;
                    case 'b': resx += 11 * Math.Pow(16, m); break;
                    case 'c': resx += 12 * Math.Pow(16, m); break;
                    case 'd': resx += 13 * Math.Pow(16, m); break;
                    case 'e': resx += 14 * Math.Pow(16, m); break;
                    case 'f': resx += 15 * Math.Pow(16, m); break;
                    default: res += "error"; break;
                }
                m++;
            }
            res = Convert.ToString(resx);
            return res;
        }

        public string HexToOct()
        {
            return BinToOct(binaryresult);
        }    

        
    }
}
            
        
    



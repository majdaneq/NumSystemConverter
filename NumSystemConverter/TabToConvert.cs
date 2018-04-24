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
    abstract class TabToConvert
    {
        public string setTabHex(string varResult)
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

        public string setTabOct(string varResult)
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

        public string[] DecHexTab(long[] binScore, string varResult,long binVar)
       {
            string[] HexScore = new string [varResult.Length];
            int i = 0;

            while (i < varResult.Length)
            {
                binScore[i] = binVar % 16;
                switch (binScore[i])
                {
                    case 0:
                        HexScore[i] = Convert.ToString(0);
                        break;
                    case 1:
                        HexScore[i] = Convert.ToString(1);
                        break;
                    case 2:
                        HexScore[i] = Convert.ToString(2);
                        break;
                    case 3:
                        HexScore[i] = Convert.ToString(3);
                        break;
                    case 4:
                        HexScore[i] = Convert.ToString(4);
                        break;
                    case 5:
                        HexScore[i] = Convert.ToString(5);
                        break;
                    case 6:
                        HexScore[i] = Convert.ToString(6);
                        break;
                    case 7:
                        HexScore[i] = Convert.ToString(7);
                        break;
                    case 8:
                        HexScore[i] = Convert.ToString(8);
                        break;
                    case 9:
                        HexScore[i] = Convert.ToString(9);
                        break;
                    case 10:
                        HexScore[i] = "A";
                        break;
                    case 11:
                        HexScore[i] = "B";
                        break;
                    case 12:
                        HexScore[i] = "C";
                        break;
                    case 13:
                        HexScore[i] = "D";
                        break;
                    case 14:
                        HexScore[i] = "E";
                        break;
                    case 15:
                        HexScore[i] = "F";
                        break;
                }
                binVar /= 16;
                i++;
            }

            return HexScore;

        }

        public string[] DecOctTab(long[] binScore, string varResult, long binVar)
        {
            int i = 0;
            string[] OctScore = new string[varResult.Length];
            while (i < varResult.Length)
            {
                binScore[i] = binVar % 8;
                switch (binScore[i])
                {
                    case 0:
                        OctScore[i] = Convert.ToString(0);
                        break;
                    case 1:
                        OctScore[i] = Convert.ToString(1);
                        break;
                    case 2:
                        OctScore[i] = Convert.ToString(2);
                        break;
                    case 3:
                        OctScore[i] = Convert.ToString(3);
                        break;
                    case 4:
                        OctScore[i] = Convert.ToString(4);
                        break;
                    case 5:
                        OctScore[i] = Convert.ToString(5);
                        break;
                    case 6:
                        OctScore[i] = Convert.ToString(6);
                        break;
                    case 7:
                        OctScore[i] = Convert.ToString(7);
                        break;

                }
                binVar /= 8;
                i++;
            }
            return OctScore;
        }

        public string ClearFront(string _text)
        {
            int index = 0;
            if (_text[0] == '0')
            {
                for (int o = 0; o < _text.Length; o++)
                {
                    if (_text[o] != '0') { index = o; break; }
                }
            }
            _text = _text.Remove(0, index);
            return _text;
        }
    }
}
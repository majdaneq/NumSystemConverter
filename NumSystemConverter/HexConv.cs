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
    class HexConv : Converter, setAdapt
    {
        TextView txtDec, txtBin, txtOct;
        string varResult;
        string res;
        string binaryresult;
        public HexConv(TextView t1, TextView t2, TextView t3, TextView t4, string _number)
        {
            txtBin = t1;
            txtDec = t3;
            txtOct = t2;
            varResult = _number;
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
            string varResultOct = binaryresult;
            switch (varResult.Length % 3)                                       //making a 4*digit 
            {
                case 1:
                    varResultOct = varResultOct.Insert(0, "00"); break;
                case 2:
                    varResultOct = varResultOct.Insert(0, "0"); break;

            }

            //check how long is the binary number

            int divider = varResultOct.Length / 3;
            short decision = 0;
            string varResult1 = "";
            string varResult2 = "";
            string varResult3 = "";
            string varResult4 = "";
            string varResult5 = "";
            string varResult6 = "";
            string varResult7 = "";
            string varResult8 = "";
            string varResult9 = "";
            string varResult10 = "";
            string varResult11= "";
            string varResult12 = "";
            string varResult13 = "";
            string varResult14 = "";
            string varResult15 = "";
            string varResult16 = "";
            string varResult17 = "";
            string varResult18 = "";
            string varResult19 = "";
            string varResult20 = "";            

           

            // dividing string into 4 elements arrays 
            int i = 0;
            switch (divider)
            {
                case 0: return "ERROR";

                case 1: decision = 1; break;
                case 2:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        decision = 2;
                        i++;
                    }
                    break;
                case 3:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        decision = 3;
                        i++;
                    }
                    break;
                case 4:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        decision = 4;
                        i++;
                    }
                    break;
                case 5:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];    //backbackback
                        decision = 5;
                        i++;
                    }
                    break;
                case 6:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        decision = 6;
                        i++;
                    }
                    break;
                case 7:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                       
                        decision = 7;
                        i++;
                    }
                    break;
                case 8:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        decision = 8;
                        i++;
                    }
                    break;
                case 9:
                    while (i < 3)
                    {   varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        decision = 9;
                        i++;
                    }
                    break;
                case 10:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback
                        decision = 10;
                        i++;
                    }
                    break;
                case 11:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback
                        varResult11 += varResultOct[i + 30];    //backbackback
                        decision = 11;
                        i++;
                    }
                    break;
                case 12:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult11 += varResultOct[i + 30];    //backbackback
                        decision = 12;
                        i++;
                    }
                    break;
                case 13:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        decision = 13;
                        i++;
                    }
                    break;
                case 14:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        decision = 14;
                        i++;
                    }
                    break;
                case 15:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback
                        decision = 15;
                        i++;
                    }
                    break;
                case 16:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback
                        varResult16 += varResultOct[i + 45];    //backbackback
                        decision = 16;
                        i++;
                    }
                    break;
                case 17:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback                       
                        varResult16 += varResultOct[i + 45];    //backbackback
                        varResult17 += varResultOct[i + 48];    //backbackback
                        decision = 17;
                        i++;
                    }
                    break;
                case 18:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback
                        varResult16 += varResultOct[i + 45];    //backbackback
                        varResult17 += varResultOct[i + 48];    //backbackback
                        varResult18 += varResultOct[i + 51];    //backbackback
                       
                        decision = 18;
                        i++;
                    }
                    break;
                case 19:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback
                        varResult16 += varResultOct[i + 45];    //backbackback
                        varResult17 += varResultOct[i + 48];    //backbackback
                        varResult18 += varResultOct[i + 51];    //backbackback
                        varResult19 += varResultOct[i + 54];
                        decision = 19;
                        i++;
                    }
                    break;
                case 20:
                    while (i < 3)
                    {
                        varResult1 += varResultOct[i];         //front
                        varResult2 += varResultOct[i + 3];     //back
                        varResult3 += varResultOct[i + 6];     //backback
                        varResult4 += varResultOct[i + 9];    //backbackback
                        varResult5 += varResultOct[i + 12];     //backback
                        varResult6 += varResultOct[i + 15];    //backbackback
                        varResult7 += varResultOct[i + 18];     //backback
                        varResult8 += varResultOct[i + 21];    //backbackback
                        varResult9 += varResultOct[i + 24];    //backbackback
                        varResult10 += varResultOct[i + 27];    //backbackback                        
                        varResult11 += varResultOct[i + 30];    //backbackback
                        varResult12 += varResultOct[i + 33];    //backbackback
                        varResult13 += varResultOct[i + 36];    //backbackback
                        varResult14 += varResultOct[i + 39];    //backbackback
                        varResult15 += varResultOct[i + 42];    //backbackback
                        varResult16 += varResultOct[i + 45];    //backbackback
                        varResult17 += varResultOct[i + 48];    //backbackback
                        varResult18 += varResultOct[i + 51];    //backbackback
                        varResult19 += varResultOct[i + 54];
                        varResult20 += varResultOct[i + 57];
                        decision = 20;
                        i++;
                    }
                    break;
            }

            List<string> varRes = new List<string>();
            varRes.Add(varResult1);
            varRes.Add(varResult2);
            varRes.Add(varResult3);
            varRes.Add(varResult4);
            varRes.Add(varResult5);
            varRes.Add(varResult6);
            varRes.Add(varResult7);
            varRes.Add(varResult8);
            varRes.Add(varResult9);
            varRes.Add(varResult10);
            varRes.Add(varResult11);
            varRes.Add(varResult12);
            varRes.Add(varResult13);
            varRes.Add(varResult14);
            varRes.Add(varResult15);
            varRes.Add(varResult16);
            varRes.Add(varResult17);
            varRes.Add(varResult18);
            varRes.Add(varResult19);
            varRes.Add(varResult20);
            string var ="";

            for (int l=0;l<decision;l++)
            {
                var += setTabOct(varRes[l]);
            }
            return var;
        }

        public string SetTab(string varResult)
        {
            throw new NotImplementedException();
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
    }
}
            
        
    



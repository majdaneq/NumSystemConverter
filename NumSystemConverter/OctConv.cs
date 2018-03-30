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
                        string varResultHex = binaryresult;
            switch (varResultHex.Length % 4)                                       //making a 4*digit 
            {
                case 1:
                    varResultHex = varResultHex.Insert(0, "000"); break;
                case 2:
                    varResultHex = varResultHex.Insert(0, "00"); break;
                case 3:
                    varResultHex = varResultHex.Insert(0, "0"); break;
            }

            //check how long is the binary number

            int divider = varResultHex.Length / 4;
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
            string varResult11 = "";
            string varResult12 = "";
            string varResult13 = "";
            // dividing string into 4 elements arrays 
            int i = 0;
            switch (divider)
            {
                case 0: return "ERROR";

                case 1: decision = 1; break;
                case 2:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        decision = 2;
                        i++;
                    }
                    break;
                case 3:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        decision = 3;
                        i++;
                    }
                    break;
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
                    break;
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
                    break;
                case 6:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        decision = 6;
                        i++;
                    }
                    break;
                case 7:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback   
                        decision = 7;
                        i++;
                    }
                    break;
                case 8:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback    
                        decision = 8;
                        i++;
                    }
                    break;
                case 9:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback 
                        varResult9 += varResultHex[i + 32];    //backbackback   
                        decision = 9;
                        i++;
                    }
                    break;
                case 10:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback 
                        varResult9 += varResultHex[i + 32];    //backbackback   
                        varResult10 += varResultHex[i + 36];    //backbackback  
                        decision = 10;
                        i++;
                    }
                    break;
                case 11:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback 
                        varResult9 += varResultHex[i + 32];    //backbackback  
                        varResult10 += varResultHex[i + 36];    //backbackback
                        varResult11 += varResultHex[i + 40];    //backbackback  
                        decision = 11;
                        i++;
                    }
                    break;
                case 12:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback 
                        varResult9 += varResultHex[i + 32];    //backbackback  
                        varResult10 += varResultHex[i + 36];    //backbackback
                        varResult11 += varResultHex[i + 40];    //backbackback  
                        varResult12 += varResultHex[i + 44];    //backbackback  
                        decision = 12;
                        i++;
                    }
                    break;
                case 13:
                    while (i < 4)
                    {
                        varResult1 += varResultHex[i];         //front
                        varResult2 += varResultHex[i + 4];     //back
                        varResult3 += varResultHex[i + 8];     //backback
                        varResult4 += varResultHex[i + 12];    //backbackback
                        varResult5 += varResultHex[i + 16];    //backbackback
                        varResult6 += varResultHex[i + 20];    //backbackbackdecision = 6;
                        varResult7 += varResultHex[i + 24];    //backbackback      
                        varResult8 += varResultHex[i + 28];    //backbackback 
                        varResult9 += varResultHex[i + 32];    //backbackback   
                        varResult10 += varResultHex[i + 36];    //backbackback
                        varResult11 += varResultHex[i + 40];    //backbackback  
                        varResult12 += varResultHex[i + 44];    //backbackback  
                        varResult13 += varResultHex[i + 48];    //backbackback  
                        decision = 13;
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


            string var="";

            for (int l = 0; l < decision; l++)
            {
                var += setTab(varRes[l]);
            }
            return var;


            switch (decision)
            {
                case 1: return setTab(varResultHex);

                case 2:
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    return var;

                case 3:
                    res = setTab(varResult1);
                    var = res;
                    res = setTab(varResult2);
                    var += res;
                    res = setTab(varResult3);
                    var += res;
                    return var;

                case 4:
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
                case 7:
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
                    res = setTab(varResult7);
                    var += res;
                    return var;
                case 8:
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
                    res = setTab(varResult7);
                    var += res;
                    res = setTab(varResult8);
                    var += res;
                    return var;
                case 9:
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
                    res = setTab(varResult7);
                    var += res;
                    res = setTab(varResult8);
                    var += res;
                    res = setTab(varResult9);
                    var += res;
                    return var;
            }

            return "ERROR";
        }
        public string OctToDec()
        {

            varResult = binaryresult;            
            var digits = new List<char>();                               //conversion to int array           
            for (int n = varResult.Length-1; n >= 0; n--)
                digits.Add(varResult[n]);
            var arr = digits.ToArray();
            Array.Reverse(arr);
            int m = 0;
            long  res=0;
            for (int i = varResult.Length - 1; i >= 0; i--)
            {
                varRes = Convert.ToInt64(new string(arr[i],1)) * Convert.ToInt64(Math.Pow(2, m));
                convert = convert % 10;
                m++;
               // result += varRes;
                res += Convert.ToInt64(varRes);
            }

            finalresult = Convert.ToString(res);

            return finalresult;
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
    }
}
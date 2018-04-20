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
    class DecConv : Converter
    {   private long[] binScore=new long[20];
        private long binVar;
        double numConv;
        public string Message="";
        double scorevar;
        double score;
      
        
        public DecConv(TextView t1, TextView t2, TextView t3, TextView t4, double numberToConvert)
        {
            try
            {
                numConv = numberToConvert;
            }

            catch
            {
                Message = "Liczba za duża!";
            }
        } 

        public string DecToBin()
        {          
            long binx = Convert.ToInt64(numConv);
            int i = 0;
            while(i<20)
            {
                binScore[i] = binx % 2;
                binx /= 2;
              
                i++;
            }  
            double j = 1;
            for(int k=0;k<20;k++)
            {
                scorevar = binScore[k] * j;
                score += scorevar;
                j *= 10;                
            }
                       
            return Convert.ToString(score);
        }

        public string DecToHex()
        {
            int i = 0;
            binVar = Convert.ToInt64(numConv);
            string hej = Convert.ToString(binVar);
            string[] HexScore = new string[hej.Length];
            while (i < hej.Length)
            {
                binScore[i] = binVar % 16;
                switch (binScore[i])
                {
                    case 0: HexScore[i] = Convert.ToString(0);
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

            for (int k = 0; k < HexScore.Length / 2; k++)
            {
                HexScore[k] += HexScore[HexScore.Length - 1 - k];
                HexScore[HexScore.Length - 1 - k] = "" + HexScore[k][0];
                HexScore[k] = "" + HexScore[k][1];
            }
            string text = string.Join("", HexScore); 
            
            return ClearFront(text);
        }
        
        public string DecToOct()
        {
            int i = 0;
            binVar = Convert.ToInt64(numConv);
            string hej = Convert.ToString(binVar);
            string[] HexScore = new string[hej.Length];
            while (i < hej.Length)
            {
                binScore[i] = binVar % 8;
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
                
                }
                binVar /= 8;
                i++;
            }            

            for (int k = 0; k < HexScore.Length / 2; k++)
            {
                HexScore[k] += HexScore[HexScore.Length - 1 - k];
                HexScore[HexScore.Length - 1 - k] = "" + HexScore[k][0];
                HexScore[k] = "" + HexScore[k][1];
            }
            string text = string.Join("", HexScore);
            return ClearFront(text);
        }

        string ClearFront(string _text)
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
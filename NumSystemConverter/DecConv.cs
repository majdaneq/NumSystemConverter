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
    class DecConv :TabToConvert
    {   private long[] binScore=new long[20];
        private long binVar;
        
        public string Message="";
        double scorevar;
        double score;
        private LayoutSingleton layoutSingleton;
        string varResult;
        

        public DecConv(LayoutSingleton _slayoutSingleton)
        {
            layoutSingleton = _slayoutSingleton;
            varResult = layoutSingleton.number.Text;
            binVar = Convert.ToInt64(varResult);
        }   

        public string DecToBin()
        {          
            long binx = Convert.ToInt64(varResult);
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
            binVar = Convert.ToInt64(varResult);            
            string[] HexScore = new string[varResult.Length];
            HexScore = DecHexTab(binScore,varResult,binVar);            

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
            binVar = Convert.ToInt64(varResult);           
            string[] HexScore = new string[varResult.Length];

            HexScore = DecOctTab(binScore, varResult, binVar);
                ;
            for (int k = 0; k < HexScore.Length / 2; k++)
            {
                HexScore[k] += HexScore[HexScore.Length - 1 - k];
                HexScore[HexScore.Length - 1 - k] = "" + HexScore[k][0];
                HexScore[k] = "" + HexScore[k][1];
            }
            string text = string.Join("", HexScore);
            return ClearFront(text);            
        }      
    }
}
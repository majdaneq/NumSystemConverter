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
    class Converter:MainActivity
    {
        //public double numberToConvert;       
        string number="";
        public bool done;
        
        public Converter()
        {}

        ~Converter() { }

        public Converter(LayoutSingleton laySing)
        {
            number = laySing.number.Text;
           done =RadioCheck(laySing);
        }       

        public bool RadioCheck(LayoutSingleton layout)
        {
            //numberToConvert = Convert.ToDouble(layout.number.Text);

            if (layout.InBin.Checked==true)                                   //binary input
            {                
                string possibilities = "01";                
                if (!checkInput(possibilities)) return false;
                BinConv binConv = new BinConv(layout);
                layout.textBinScore.Text = string.Format(layout.number.Text);
                layout.textOctScore.Text = string.Format(binConv.BinToOct(layout.number.Text));
                layout.textHexScore.Text = string.Format(binConv.BinToHex(layout.number.Text));
                layout.textDecScore.Text = string.Format(binConv.BinToDec(layout.number.Text));               
                return true;
            }

            if (layout.InOct.Checked==true)                                   //oct input
            { 
                string possibilities = "01234567";
                if (!checkInput(possibilities)) return false;
                OctConv octConv = new OctConv(layout);
                layout.textBinScore.Text = string.Format(octConv.OctToBin());
                layout.textHexScore.Text = string.Format(octConv.OctToHex());
                layout.textOctScore.Text = string.Format(layout.number.Text);
                layout.textDecScore.Text = string.Format(octConv.OctToDec());  
                return true;
            }

            if (layout.InDec.Checked==true)                                   //decimal input
            {               
                string possibilities = "0123456789";
                if (!checkInput(possibilities)) return false;
                DecConv decConv = new DecConv(layout);                
                layout.textBinScore.Text = string.Format(decConv.DecToBin());
                layout.textDecScore.Text = string.Format(layout.number.Text);
                layout.textHexScore.Text = string.Format(decConv.DecToHex());
                layout.textOctScore.Text = string.Format(decConv.DecToOct());
                return true;
            }

            if (layout.InHex.Checked == true)                                 //hex input
            {
                string possibilities = "0123456789abcdefABCDEF";
                if (!checkInput(possibilities)) return false;
                HexConv hexConv = new HexConv(layout);
                layout.textBinScore.Text = string.Format(hexConv.HexToBin());
                layout.textDecScore.Text = string.Format(hexConv.HexToDec());
                layout.textHexScore.Text = string.Format(layout.number.Text);
                layout.textOctScore.Text = string.Format(hexConv.HexToOct());
                return true;
            }

            else return false;
        }

        bool checkInput(string possibilities){         
            int match = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < possibilities.Length; j++)
                {
                    if (number[i] == possibilities[j]) match++;                                       
                }                
            }
            if (match!=number.Length) return false;
            else return true;
        }
       
    }
}
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
        public double numberToConvert;       
        string number="";
        public bool done;
        
        public Converter()
        {}

        ~Converter() { }

        public Converter(LayoutSingleton laySing)
        {
           done=RadioCheck(laySing);
        }       

        public bool RadioCheck(LayoutSingleton layout)
        {
            numberToConvert = Convert.ToDouble(layout.number.Text);

            if (layout.InBin.Checked==true)                                   //binary input
            {                
                string possibilities = "01";                
                if (!checkInput(possibilities)) return false;
                BinConv binConv = new BinConv(layout);
                layout.textBinScore.Text = string.Format(layout.number.Text);
                layout.textOctScore.Text = string.Format(binConv.BinToOct());
                layout.textHexScore.Text = string.Format(binConv.BinToHex(numberToConvert));
                layout.textDecScore.Text = string.Format(binConv.BinToDec());               
                return true;
            }

            if (layout.InOct.Checked==true)                                   //oct input
            {               

                string possibilities = "01234567";
                if (!checkInput(possibilities)) return false;
                // OctConv octConv = new OctConv(t1, t2, t3, t4, numberToConvert);
                //txtBin.Text = string.Format(octConv.OctToBin());
                //txtHex.Text = string.Format(octConv.OctToHex());
                //txtOct.Text = string.Format(number);
                //txtDec.Text = string.Format(octConv.OctToDec());                
                               
                return true;
            }

            if (layout.InDec.Checked==true)                                   //decimal input
            {               
                string possibilities = "0123456789";
                if (!checkInput(possibilities)) return false;
               // DecConv decConv = new DecConv(t1, t2, t3, t4, numberToConvert);                
                //layout.textBin.Text =  string.Format(decConv.DecToBin());
                //layout.textDec.Text = string.Format(number);
                //layout.textHex.Text = string.Format(decConv.DecToHex());
                //layout.textOct.Text = string.Format(decConv.DecToOct());
                return true;
            }

            if (layout.InHex.Checked == true)                                 //hex input
            {
                string possibilities = "0123456789abcdefABCDEF";
                if (!checkInput(possibilities)) return false;
                //HexConv hexConv = new HexConv(t1, t2, t3, t4, number);
                //txtBin.Text = string.Format(hexConv.HexToBin());
                //txtHex.Text = string.Format(number);
                //txtDec.Text = string.Format(hexConv.HexToDec());
                //txtOct.Text = string.Format(hexConv.HexToOct());
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
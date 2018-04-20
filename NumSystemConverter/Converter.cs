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
        TextView txtBin, txtOct, txtDec, txtHex;
        string number="";
        public bool done;
        LayoutSingleton layout;
        
        public Converter()
        {}

        ~Converter() { }

        public Converter(LayoutSingleton laySing)
        {
            number = laySing.number.Text;
           // RadioCheck(laySing.InBin, b2, b3, b4, t1, t2, t3, t4);
        }
        public Converter(string _number,RadioButton b1,RadioButton b2,RadioButton b3,RadioButton b4,TextView t1, TextView t2, TextView t3, TextView t4)                                 
        {                 
            txtBin = t1;
            txtOct = t2;
            txtDec = t3;
            txtHex = t4;
           try
                {
                    number = _number;                               
                    RadioCheck(b1,b2,b3,b4,t1,t2,t3,t4);
                }
           catch
                {
                
                }           
        }

        public bool RadioCheck(RadioButton b1, RadioButton b2, RadioButton b3, RadioButton b4, TextView t1, TextView t2, TextView t3, TextView t4)
        {   
            if (b1.Checked==true)                                   //binary input
            {
                numberToConvert = Convert.ToDouble(number);
                string possibilities = "01";
                done = checkInput(possibilities);
                if (!done) return false;
                BinConv binConv = new BinConv(t1,t2,t3,t4,number);
                layout.textBin.Text = string.Format(number);
                layout.textOct.Text = string.Format(binConv.BinToOct());
                layout.textHex.Text = string.Format(binConv.BinToHex(numberToConvert));
                layout.textDec.Text = string.Format(binConv.BinToDec(numberToConvert));
                done = true;
                return done;
            }
            if (b2.Checked==true)                                   //oct input
            {
                numberToConvert = Convert.ToDouble(number);

                string possibilities = "01234567";
                done = checkInput(possibilities);
                if (!done) return false;
                OctConv octConv = new OctConv(t1, t2, t3, t4, numberToConvert);
                txtBin.Text = string.Format(octConv.OctToBin());
                txtHex.Text = string.Format(octConv.OctToHex());
                txtOct.Text = string.Format(number);
                txtDec.Text = string.Format(octConv.OctToDec());                
                               
                return true;
            }
            if (b3.Checked==true)                                   //decimal input
            {
                numberToConvert = Convert.ToDouble(number);
                string possibilities = "0123456789";
                done = checkInput(possibilities);
                if (!done) return false;                
                DecConv decConv = new DecConv(t1, t2, t3, t4, numberToConvert);                
                layout.textBin.Text =  string.Format(decConv.DecToBin());
                layout.textDec.Text = string.Format(number);
                layout.textHex.Text = string.Format(decConv.DecToHex());
                layout.textOct.Text = string.Format(decConv.DecToOct());
                return true;
            }
            if (b4.Checked == true)                                 //hex input
            {
                string possibilities = "0123456789abcdefABCDEF";
                done = checkInput(possibilities);
                if (!done) return false;
                HexConv hexConv = new HexConv(t1, t2, t3, t4, number);
                txtBin.Text = string.Format(hexConv.HexToBin());
                txtHex.Text = string.Format(number);
                txtDec.Text = string.Format(hexConv.HexToDec());
                txtOct.Text = string.Format(hexConv.HexToOct());
                return true;
            }

            else return false;
        }

        bool checkInput(string possibilities)
        {
         
            int ssi = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < possibilities.Length; j++)
                {
                    if (number[i] == possibilities[j])
                    {     ssi++;
                    }                    
                }
                
            }
            if (ssi!=number.Length) return false;
            else return true;
        }
       
    }
}
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
        public Converter()
        {

        }

        ~Converter() { }

        public Converter(string number,RadioButton b1,RadioButton b2,RadioButton b3,RadioButton b4,TextView t1, TextView t2, TextView t3, TextView t4)                                 
        {                 
            txtBin = t1;
            txtOct = t2;
            txtDec = t3;
            txtHex = t4;
                try
                {
                    numberToConvert = Convert.ToDouble(number);                
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
                BinConv binConv = new BinConv(t1,t2,t3,t4,numberToConvert);
                txtBin.Text = string.Format(Convert.ToString(numberToConvert));
                txtOct.Text = string.Format(binConv.BinToOct());
                txtHex.Text = string.Format(binConv.BinToHex());
                txtDec.Text = string.Format(binConv.BinToDec());                
                return true;
            }
            if (b2.Checked==true)                                   //oct input
            {
                
                OctConv octConv = new OctConv(t1, t2, t3, t4, numberToConvert);
                return true;
            }
            if (b3.Checked==true)                                   //decimal input
            {                
                DecConv decConv = new DecConv(t1, t2, t3, t4, numberToConvert);

                txtBin.Text=  string.Format(decConv.DecToBin());
                txtDec.Text = string.Format(Convert.ToString(numberToConvert));
                txtHex.Text = string.Format(decConv.DecToHex());
                txtOct.Text = string.Format(decConv.DecToOct());
                return true;
            }
            if (b4.Checked == true)                                 //hex input
            {
                
                HexConv hexConv = new HexConv(t1, t2, t3, t4, numberToConvert);
                 return true;
            }

            else return false;
        }
       
    }
}
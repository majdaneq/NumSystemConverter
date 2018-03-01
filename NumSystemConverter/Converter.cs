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
        Button buttonCount;       
        TextView text;
        double numberToConvert;
        public Converter()
        {

        }
        public Converter(string number)                                 
        { 
                numberToConvert = 20.0;
            try
            {
                numberToConvert = Convert.ToDouble(number);
            }
            catch
            {
                
            }
            getChoice();
        }

        void getChoice()
        {
            if (InBin.Checked)
            {
                BinConv binConv = new BinConv();
            }
            if (InOct.Checked)
            {
                OctConv octConv = new OctConv();
            }
            if (InDec.Checked)
            {
                DecConv decConv = new DecConv();
            }
            if (InHex.Checked)
            {
                HexConv hexConv = new HexConv();
            }
        }
       
    }
}
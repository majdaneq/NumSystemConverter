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
    class BinConv : Converter
    {
        public BinConv(TextView t1, TextView t2, TextView t3, TextView t4, double numberToConvert)
        {
            t1.Text = string.Format("CHUJ");
        }
    }
}
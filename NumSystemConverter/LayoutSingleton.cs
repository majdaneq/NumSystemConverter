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
    public class LayoutSingleton{
        private static LayoutSingleton _obj;       
        public EditText number;
        public Button buttonCount;
        public TextView init;
        public TextView textBin;
        public TextView textBinScore;
        public TextView textDec;
        public TextView textDecScore;
        public TextView textHex;
        public TextView textHexScore;
        public TextView textOct;
        public TextView textOctScore;
        public RadioButton InBin;
        public RadioButton InDec;
        public RadioButton InHex;
        public RadioButton InOct;
        public Switch language;       
      
        private LayoutSingleton(){}     
        
        public static LayoutSingleton CreateObject(){            
            if (_obj == null)  _obj = new LayoutSingleton(); 
            return _obj;
            } 
    }
}
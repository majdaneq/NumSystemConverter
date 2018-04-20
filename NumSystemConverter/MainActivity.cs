using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace NumSystemConverter
{

    
    [Activity(Label = "NumSystemConverter", MainLauncher = true)]

    public class MainActivity : Activity, Observer
    {    
        string ErrorText = "Wprowadź poprawną liczbę";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);           
            SetContentView(Resource.Layout.Main);
            LayoutSingleton o1 = LayoutSingleton.CreateObject();

            #region attribution
            o1.language = FindViewById<Switch>(Resource.Id.switch1);
            o1.buttonCount = FindViewById<Button>(Resource.Id.scorebutton);
            o1.number = FindViewById<EditText>(Resource.Id.number);
            o1.init = FindViewById<TextView>(Resource.Id.init);
            o1.textBin = FindViewById<TextView>(Resource.Id.textBin);
            o1.textBinScore = FindViewById<TextView>(Resource.Id.textBinScore);
            o1.textDec = FindViewById<TextView>(Resource.Id.textDec);
            o1.textDecScore = FindViewById<TextView>(Resource.Id.textDecScore);
            o1.textHex = FindViewById<TextView>(Resource.Id.textHex);
            o1.textHexScore = FindViewById<TextView>(Resource.Id.textHexScore);
            o1.textOct = FindViewById<TextView>(Resource.Id.textOct);
            o1.textOctScore = FindViewById<TextView>(Resource.Id.textOctScore);
            o1.InBin = FindViewById<RadioButton>(Resource.Id.InradioButton1);
            o1.InOct = FindViewById<RadioButton>(Resource.Id.InradioButton2);
            o1.InDec = FindViewById<RadioButton>(Resource.Id.InradioButton3);
            o1.InHex = FindViewById<RadioButton>(Resource.Id.InradioButton4);
            o1.language.TextOff = "PL";
            o1.language.TextOn = "EN";
            #endregion}

            o1.language.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
                  {
                      if (e.IsChecked)
                          UpdateLanguage(o1.language.TextOn,o1);
                      else UpdateLanguage(o1.language.TextOff,o1);
                  };

            o1.buttonCount.Click += delegate
               {
                   if (!convertNumber(o1)) Toast.MakeText(this, ErrorText, ToastLength.Long).Show();                   
               };
        }

        private bool convertNumber(LayoutSingleton o1)
        {   Converter convert = new Converter(o1);            
            if (convert.done == true) return true;
            else return false;           
        }

        public void UpdateLanguage(string language, LayoutSingleton o1)
        {   switch (language)
            {
                case "PL":
                    o1.textBin.Text = "Binarnie :";
                    o1.textDec.Text = "Dziesiętnie :";
                    o1.textOct.Text = "Oktagonalnie :";
                    o1.textHex.Text = "Szesnastkowo :";
                    o1.init.Text = "Podaj liczbę :";
                    o1.InBin.Text = "Binarnie";
                    o1.InDec.Text = "Dziesiętnie";
                    o1.InOct.Text = "Oktagonalnie";
                    o1.InHex.Text = "Szesnastkowo";
                    ErrorText = "Wprowadz poprawną liczbę";
                    o1.buttonCount.Text = "Oblicz";
                    break;

                case "EN":
                    o1.textBin.Text = "Binary :";
                    o1.textDec.Text = "Decimal :";
                    o1.textOct.Text = "Octagonal :";
                    o1.textHex.Text = "Hexagonal : ";
                    o1.init.Text = "Give a number to convert :";
                    o1.InBin.Text = "Binary";
                    o1.InDec.Text = "Decimal";
                    o1.InOct.Text = "Octagonal";
                    o1.InHex.Text = "Hexadecimal";
                    ErrorText = "Insert correct number";
                    o1.buttonCount.Text = "Get result";
                    break;
            }
        }
       
    }
}


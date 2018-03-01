using Android.App;
using Android.Widget;
using Android.OS;

namespace NumSystemConverter
{
    [Activity(Label = "NumSystemConverter", MainLauncher = true)]
    public class MainActivity : Activity
    {
        #region declarations
        
        public EditText number;        
        Button buttonCount;
        TextView init;
        public TextView textBin;
        public TextView textBinScore;
        TextView textDec;
        public TextView textDecScore;
        TextView textHex;
        public TextView textHexScore;
        TextView textOct;
        public TextView textOctScore;
        public static RadioButton InBin;
        public static RadioButton InDec;
        public RadioButton InHex;
        public RadioButton InOct;

        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            SetContentView(Resource.Layout.Main);
            #region attribution
            buttonCount = FindViewById<Button>(Resource.Id.scorebutton);
            number = FindViewById<EditText>(Resource.Id.number);
            init = FindViewById<TextView>(Resource.Id.init);
            textBin = FindViewById<TextView>(Resource.Id.textBin);
            textBinScore = FindViewById<TextView>(Resource.Id.textBinScore);
            textDec = FindViewById<TextView>(Resource.Id.textDec);
            textDecScore = FindViewById<TextView>(Resource.Id.textDecScore);
            textHex = FindViewById<TextView>(Resource.Id.textHex);
            textHexScore = FindViewById<TextView>(Resource.Id.textHexScore);
            textOct = FindViewById<TextView>(Resource.Id.textOct);
            textOctScore = FindViewById<TextView>(Resource.Id.textOctScore);
            InBin = FindViewById<RadioButton>(Resource.Id.InradioButton1);
            InOct = FindViewById<RadioButton>(Resource.Id.InradioButton2);
            InDec = FindViewById<RadioButton>(Resource.Id.InradioButton3);
            InHex = FindViewById<RadioButton>(Resource.Id.InradioButton4);
            #endregion

            buttonCount.Click +=
               delegate
               {
                   Converter convert = new Converter(number.Text, InBin, InOct, InDec, InHex, textBinScore, textOctScore, textDecScore, textHexScore);                        //string to convert   
                                   
               };
        }
    }
}


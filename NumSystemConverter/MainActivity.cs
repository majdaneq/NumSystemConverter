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
        TextView textBinScore;
        TextView textDec;
        TextView textDecScore;
        TextView textHex;
        TextView textHexScore;
        TextView textOct;
        TextView textOctScore;
        public RadioButton InBin;
        public RadioButton InDec;
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
                   Converter convert = new Converter(number.Text);                        //string to convert                  
               };
        }
    }
}


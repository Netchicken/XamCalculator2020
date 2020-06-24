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

namespace XamCalculator2020
{
    [Activity(Label = "BMIActivity")]
    public class BMIActivity : Activity
    {


        private EditText txtWeight;
        private EditText txtHeight;
        private EditText txtResult;

        private TextView txtMessage;
        private double Weight;
        private double Height;
        private double Result;

        private Button btnCalculate;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.BMI);
            InitializeControls();
        }


        void InitializeControls()
        {
            txtWeight = FindViewById<EditText>(Resource.Id.txtWeight);
            txtHeight = FindViewById<EditText>(Resource.Id.txtHeight);
            txtResult = FindViewById<EditText>(Resource.Id.txtResult);
            txtMessage = FindViewById<TextView>(Resource.Id.txtMessage);
            btnCalculate = FindViewById<Button>(Resource.Id.btnCalculate);


            btnCalculate.Click += onBtnCalculate_Click;

        }

        private void onBtnCalculate_Click(object sender, EventArgs e)
        {

            Weight = Convert.ToDouble(txtWeight.Text);
            Height = Convert.ToDouble(txtHeight.Text);

            Result = Weight / (Height * Height);

            txtMessage.Text = Math.Round(Result, 2).ToString();







        }
    }
}
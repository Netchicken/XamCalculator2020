using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Views;

namespace XamCalculator2020
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txtNum1;
        private TextView txtNum2;

        private double Num1;
        private double Num2;
        private double Result;

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDivide;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            InitializeControlls();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        void InitializeControlls()
        {
            txtNum1 = FindViewById<TextView>(Resource.Id.txtNum1);
            txtNum2 = FindViewById<TextView>(Resource.Id.txtNum2);
            btnPlus = FindViewById<Button>(Resource.Id.btnplus);
            btnMinus = FindViewById<Button>(Resource.Id.btnminus);
            btnMul = FindViewById<Button>(Resource.Id.btnmul);
            btnDivide = FindViewById<Button>(Resource.Id.btnDivide);


            btnPlus.Click += onBtnPlus_Click;
            btnMinus.Click += onBtnMinus_Click;

        }

        private void onBtnMinus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onBtnPlus_Click(object sender, EventArgs e)
        {

            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);

            Result = Num1 + Num2;

            // Toast.MakeText(this, "The result is " + Result, ToastLength.Long).SetGravity(GravityFlags.Center, 0, 0).Show();

            Toast toast = Toast.MakeText(this, "The result is " + Result, ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();

        }
    }
}
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using MathiasDesign.Features.SnackBar;
using MathiasDesign.Features.Home;

namespace MathiasDesign
{
    [Activity(Label = "MathiasDesign", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Start the given activity and call Finish() to remove the splash screen from the navigation stack
            StartActivity(new Intent(this, typeof(HomeView)));
            Finish();
        }
    }
}


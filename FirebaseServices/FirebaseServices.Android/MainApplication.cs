using System;
using Android.App;
using Android.Runtime;

namespace FirebaseServices.Droid
{
    [Application(
        Theme = "@style/MainTheme"
        )]
    public class MainApplication : NotificationApplication
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}

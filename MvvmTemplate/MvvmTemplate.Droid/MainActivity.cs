using Android.App;
using Android.Content.PM;
using Android.OS;
using XLabs.Ioc;

namespace MvvmTemplate.Droid
{
    [Activity(Label = "MvvmTemplate", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : XLabs.Forms.XFormsApplicationDroid
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            if (!Resolver.IsSet) SetIoc();
            LoadApplication(new App());
        }

        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();
            Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}


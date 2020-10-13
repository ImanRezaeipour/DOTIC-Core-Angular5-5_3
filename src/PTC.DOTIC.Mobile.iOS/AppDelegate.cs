using System;
using System.Threading;
using System.Threading.Tasks;
using FFImageLoading.Forms.Touch;
using Flurl.Http;
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using PTC.DOTIC.Core;
using PTC.DOTIC.Core.Exception;
using UIKit;
using PTC.DOTIC.ApiClient;
using PTC.DOTIC.Core.Threading;

namespace PTC.DOTIC
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

            ApplicationBootstrapper.InitializeIfNeeds<DOTICXamarinIosModule>();

            InstallFontPlugins();

            global::Xamarin.Forms.Forms.Init();

            ImageCircleRenderer.Init();

            CachedImageRenderer.Init();

            FormsPlugin.Iconize.iOS.IconControls.Init();

            ConfigureFlurlHttp();

            SetExitAction();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        
        /// <summary>
        /// https://github.com/jsmarcus/Xamarin.Plugins/tree/master/Iconize*
        /// </summary>
        private static void InstallFontPlugins()
        {
            Plugin.Iconize
                .Iconize
                .With(new Plugin.Iconize.Fonts.FontAwesomeModule())
                .With(new Plugin.Iconize.Fonts.MaterialModule());
        }

        private static void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs)
        {
            ExceptionHandler.LogException(unobservedTaskExceptionEventArgs.Exception);
            unobservedTaskExceptionEventArgs.SetObserved();
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            ExceptionHandler.LogException(unhandledExceptionEventArgs.ExceptionObject as Exception);
        }

        private static void SetExitAction()
        {
            App.ExitApplication = () =>
            {
                Thread.CurrentThread.Abort();
            };
        }

        private static void ConfigureFlurlHttp()
        {
            FlurlHttp.Configure(c =>
            {
                c.HttpClientFactory = new ModernHttpClientFactory();
            });
        }
    }
}

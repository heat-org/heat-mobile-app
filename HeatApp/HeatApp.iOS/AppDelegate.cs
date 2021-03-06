using Syncfusion.SfChart.XForms.iOS.Renderers;
using Syncfusion.XForms.iOS.ProgressBar;
using Syncfusion.SfMaps.XForms.iOS;
using Syncfusion.SfRotator.XForms.iOS;
using Syncfusion.XForms.iOS.Graphics;
using Syncfusion.XForms.iOS.TabView;
using Syncfusion.XForms.iOS.Cards;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.SfCalendar.XForms.iOS;
using Syncfusion.XForms.iOS.ComboBox;
using Syncfusion.XForms.iOS.Border;
using Syncfusion.XForms.iOS.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using Syncfusion.XForms.iOS.Backdrop;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter;
using Syncfusion.SfBusyIndicator.XForms.iOS;

namespace HeatApp.iOS
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
            global::Xamarin.Forms.Forms.Init();
            SfChartRenderer.Init();
            SfLinearProgressBarRenderer.Init();
            SfMapsRenderer.Init();
            SfRotatorRenderer.Init();
            SfGradientViewRenderer.Init();
            SfTabViewRenderer.Init();
            SfCardViewRenderer.Init();
            SfRatingRenderer.Init();
            Core.Init();
            SfListViewRenderer.Init();
            SfComboBoxRenderer.Init();
            SfCalendarRenderer.Init();
            SfBorderRenderer.Init();
            SfButtonRenderer.Init();
            SfBackdropPageRenderer.Init();
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            Xamarin.FormsMaps.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyD2ZjqBONONbEATiZT8yX97iwm2biuJI5o");
            Rg.Plugins.Popup.Popup.Init();
            Distribute.DontCheckForUpdatesInDebug();
            AppCenter.Start("c55cf46b-3908-4073-925e-adbe7c9f4810", typeof(Distribute));
            new SfBusyIndicatorRenderer();
            Syncfusion.XForms.iOS.Expander.SfExpanderRenderer.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using KeyboardOverlap.Forms.Plugin.iOSUnified;
using Stimmmit.Views.MainPages;
//using KeyboardOverlap.Forms.Plugin.iOSUnified;
using UIKit;
using Xamarin.Forms;

namespace Stimmmit.iOS
{
    public class IOSKeyboardHeightProvider : IKeyboardHeightProvider
    {
        public IOSKeyboardHeightProvider()
        {
            // luckily, this event is called before onfocus
            UIKeyboard.Notifications.ObserveWillShow(OnKeyboardShown);
        }
        private nfloat mHeight = 0; 
        private void OnKeyboardShown(object sender, UIKeyboardEventArgs e)
        {
            mHeight = e.FrameEnd.Height;
        }
        public float GetKeyboardHeight()
        {
            return (float)mHeight;
        }
    }


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
            KeyBoardHeight.KeyboardHeightProvider = new IOSKeyboardHeightProvider();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());           
            return base.FinishedLaunching(app, options);
        }
    }
}

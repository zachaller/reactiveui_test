using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using ReactiveUI;
using ReactiveUI.Mobile;
using ReactiveUI.Cocoa;

namespace HelloWorld_App1
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		MyViewController viewController;

		public AppDelegate()
		{
			//new ReactiveUI.
			//(new ReactiveUI.ServiceLocationRegistration()).Register();
			//(new ReactiveUI.Routing.ServiceLocationRegistration()).Register();
			//(new ReactiveUI.Cocoa.ServiceLocationRegistration()).Register();
		}

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			//(new ReactiveUI.Xaml.ServiceLocationRegistration()).Register();
			//(new ReactiveUI.Routing.ServiceLocationRegistration()).Register();
			//(new ReactiveUI.Cocoa.ServiceLocationRegistration()).Register();
			//(new ReactiveUI.Mobile.ServiceLocationRegistration()).Register();


			window = new UIWindow(UIScreen.MainScreen.Bounds);

			viewController = new MyViewController();
			window.RootViewController = viewController;

			window.MakeKeyAndVisible();

			return true;
		}
	}
}


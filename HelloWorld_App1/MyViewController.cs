using System;
using MonoTouch.UIKit;
using System.Drawing;

using ReactiveUI;
using ReactiveUI.Mobile;
using ReactiveUI.Cocoa;

namespace HelloWorld_App1
{
	public class MyViewController : UIViewController, IViewFor<MyViewModel>, IReactiveNotifyPropertyChanged
	{
		UIButton button;
		int numClicks = 0;
		float buttonWidth = 200;
		float buttonHeight = 50;

		public MyViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.Frame = UIScreen.MainScreen.Bounds;
			View.BackgroundColor = UIColor.White;
			View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

			button = UIButton.FromType(UIButtonType.RoundedRect);

			button.Frame = new RectangleF(
				View.Frame.Width / 2 - buttonWidth / 2,
				View.Frame.Height / 2 - buttonHeight / 2,
				buttonWidth,
				buttonHeight);

			//button.SetTitle("Click me", UIControlState.Normal);

			button.TouchUpInside += (object sender, EventArgs e) =>
			{
				button.SetTitle(String.Format("clicked {0} times", numClicks++), UIControlState.Normal);
			};

			button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
				UIViewAutoresizing.FlexibleBottomMargin;

			View.AddSubview(button);

			//new ReactiveUI.Cocoa.
			//this.OneWayBind(ViewModel, x => x.ButtonText,

		}


		public MyViewModel ViewModel
		{
			get;
			set;
		}

		object IViewFor.ViewModel
		{
			get
			{
				return ViewModel;
			}
			set
			{
				ViewModel = (MyViewModel)value;
				if(PropertyChanged != null)
					PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("ViewModel"));
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;


		public IObservable<IObservedChange<object, object>> Changed
		{
			get { throw new NotImplementedException(); }
		}

		public IObservable<IObservedChange<object, object>> Changing
		{
			get { throw new NotImplementedException(); }
		}

		public IDisposable SuppressChangeNotifications()
		{
			throw new NotImplementedException();
		}

		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	}
}


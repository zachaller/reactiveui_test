using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ReactiveUI;
using ReactiveUI.Cocoa;
using ReactiveUI.Mobile;

namespace HelloWorld_App1
{
	public partial class MyViewModel: ReactiveObject, IRoutableViewModel
	{
		string _buttonText = "Click Here Please";
		public string ButtonText
		{
			get
			{
				return _buttonText;
			}
			set
			{
				this.RaiseAndSetIfChanged(ref _buttonText, value);
			}
		}

		public IScreen HostScreen { get; protected set; }

		public string UrlPathSegment
		{
			get { return "Initial View"; }
		}
	}
}

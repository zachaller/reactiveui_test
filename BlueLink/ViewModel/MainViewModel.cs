using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;
using ReactiveUI.Routing;
using ReactiveUI.Xaml;
using ReactiveUI.Mobile;
using ReactiveUI.Blend;

namespace BlueLink.ViewModel
{
	public partial class MainViewModel : ReactiveObject
    {
        string _carName = "Car's Name";
        public string CarName
        {
            get {
                return _carName;
            }
            set {
                this.RaiseAndSetIfChanged(ref _carName, value);
            }
        }

        public ReactiveCommand OkCommand
        {
            get
            {
				return new ReactiveCommand(this.WhenAny(
					x => x.CarName,
					(x) => (
						x.Value == "w"
						)));
            }
        }

		public MainViewModel()
        {
        }
    }
}

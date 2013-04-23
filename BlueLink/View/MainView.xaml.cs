using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BlueLink.Resources;

using ReactiveUI;
using ReactiveUI.Routing;
using ReactiveUI.Xaml;

namespace BlueLink
{
	public partial class MainPage : PhoneApplicationPage, IViewFor<BlueLink.ViewModel.MainViewModel>
    {
        // Constructor
        public MainPage()
        {
			ViewModel = new BlueLink.ViewModel.MainViewModel();
            this.InitializeComponent();
            this.Bind(ViewModel, x => x.CarName, x => x.textCarName.Text);

			ViewModel.OkCommand.Subscribe(x => ViewModel.CarName = "what");

        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BlueLink.ViewModel.MainViewModel)value; }
        }
        public BlueLink.ViewModel.MainViewModel ViewModel { get; set; }

        //public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register("ViewModel", typeof(MainViewModel), typeof(MainPage), new PropertyMetadata(null));

        private void btnChangeCarName_Click(object sender, RoutedEventArgs e)
        {
            //ViewModel.SetCarName("Zach's Sonata");
            ViewModel.CarName = "w";
			ViewModel.OkCommand.Execute(ViewModel.CarName);
        }
    }
}
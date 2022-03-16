using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MinionUI.CreateGuest;
using MinionUI.CreateTemplate;
using MinionUI.ExistingGuests;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MinionUI
{
    public sealed partial class MainPage : Page
    {
        #region Fields

        private MainViewModel _mainVm;

        #endregion

        public MainPage()
        {
            this.InitializeComponent();

            _mainVm = new MainViewModel();
            DataContext = _mainVm;

            SubscribeButtonEvents();
        }

        #region Properties



        #endregion

        #region Methods

        private void SubscribeButtonEvents()
        {
            ExistingVmsButton.Click += ExistingVmsButtonOnClick;
            CreateVmButton.Click += CreateVmButtonOnClick;
            CreateTemplateButton.Click += CreateTemplateButtonOnClick;
            
        }

        #endregion

        #region Events

        private void ExistingVmsButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExistingGuestsPage));
        }

        private void CreateVmButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateGuestPage));
        }

        private void CreateTemplateButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateTemplatePage));
        }

        #endregion
    }
}

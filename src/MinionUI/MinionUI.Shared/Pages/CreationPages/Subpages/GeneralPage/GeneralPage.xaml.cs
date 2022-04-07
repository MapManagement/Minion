using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MinionUI.CreationPages.General
{
    public sealed partial class GeneralPage : Page
    {
        #region Fields

        private GeneralViewModel _viewModel;

        #endregion

        public GeneralPage()
        {
            this.InitializeComponent();

            SubscribeToButtonEvents();

            _viewModel = new GeneralViewModel();
            DataContext = _viewModel;
        }

        #region Methods

        private void SubscribeToButtonEvents()
        {
            ResetButton.Click += ResetButtonOnClick;
        }

        #endregion

        #region Events

        private async void ResetButtonOnClick(object sender, RoutedEventArgs e)
        {
            var confirmDialog = new ContentDialog
            {
                Title = "Reset to default",
                Content = "Do you really want to reset all changes you made?",
                PrimaryButtonText = "Confirm",
                SecondaryButtonText = "Go back"
            };
            var dialogResult = await confirmDialog.ShowAsync();

            if (dialogResult == ContentDialogResult.Primary)
            {
                _viewModel.ResetSpecifications();
            }
        }

        #endregion
    }
}

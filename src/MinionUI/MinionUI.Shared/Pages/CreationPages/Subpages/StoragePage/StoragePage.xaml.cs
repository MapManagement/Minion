using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MinionProcesses.Components.Interfaces;
using MinionUI.CreationPages.Storage.Dialog;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MinionUI.CreationPages.Storage
{
    public sealed partial class StoragePage : Page
    {
        #region Fields

        private StorageViewModel _viewModel;

        #endregion

        public StoragePage()
        {
            this.InitializeComponent();

            SubscribeToButtonEvents();

            _viewModel = new StorageViewModel();
            DataContext = _viewModel;
        }

        #region Methods

        private void SubscribeToButtonEvents()
        {
            ResetButton.Click += ResetButtonOnClick;
            AddStorageButton.Click += AddStorageButtonClick;
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

        private async void AddStorageButtonClick(object sender, RoutedEventArgs e)
        {
            var dialog = NewStorageContentDialog();

            await dialog.ShowAsync();
        }

        private NewStorageDialog NewStorageContentDialog()
        {
            NewStorageDialog newStorageDialog = new NewStorageDialog();

            return newStorageDialog;
        }

        #endregion
    }
}

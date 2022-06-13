using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MinionProcesses.Components.Interfaces;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MinionUI.CreationPages.Storage.Dialog
{
    public sealed partial class NewStorageDialog : ContentDialog
    {
        #region Fields

        private NewStorageDialogViewModel _viewModel;

        #endregion

        #region Constructor

        public NewStorageDialog()
        {
            this.InitializeComponent();
            
            _viewModel = new NewStorageDialogViewModel();
            DataContext = _viewModel;
        }

        #endregion

        
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Toolkit.Uwp;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MinionUI.ExistingGuests
{
    public sealed partial class ExistingGuestsPage : Page
    {
        
        #region Fields

        private ExistingGuestsViewModel _mainVm;

        #endregion

        #region Constructor

        public ExistingGuestsPage()
        {
            this.InitializeComponent();

            _mainVm = new ExistingGuestsViewModel();
            DataContext = _mainVm;
        }

        #endregion

        #region Properties



        #endregion
    }
}

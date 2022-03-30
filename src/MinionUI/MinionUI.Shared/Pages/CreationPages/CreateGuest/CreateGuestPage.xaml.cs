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

namespace MinionUI.CreationPages.CreateGuest
{
    public sealed partial class CreateGuestPage : Page
    {
        #region Fields

        private CreateGuestVieModel _mainVm;

        #endregion

        public CreateGuestPage()
        {
            this.InitializeComponent();

            _mainVm = new CreateGuestVieModel();
            DataContext = _mainVm;
        }

        #region Properties



        #endregion
    }
}

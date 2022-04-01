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

namespace MinionUI.CreationPages.Cpu
{
    public sealed partial class CpuPage : Page
    {
        #region Fields

        private CpuViewModel _mainVm;

        #endregion

        public CpuPage()
        {
            this.InitializeComponent();

            _mainVm = new CpuViewModel();
            DataContext = _mainVm;
        }

        #region Properties



        #endregion

        #region Methods

        

        #endregion
    }
}

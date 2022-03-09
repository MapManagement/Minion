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

namespace MinionUI.CreateTemplate
{
    public sealed partial class CreateTemplatePage : Page
    {
        #region Fields

        private CreateTemplateViewModel _mainVm;

        #endregion

        public CreateTemplatePage()
        {
            this.InitializeComponent();

            _mainVm = new CreateTemplateViewModel();
            DataContext = _mainVm;
        }

        #region Properties



        #endregion
    }
}

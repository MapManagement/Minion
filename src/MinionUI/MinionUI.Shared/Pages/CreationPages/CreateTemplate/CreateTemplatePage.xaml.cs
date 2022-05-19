using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MinionUI.CreationPages.CpuMemory;
using MinionUI.CreationPages.General;
using Newtonsoft.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace MinionUI.CreationPages.CreateTemplate
{
    public sealed partial class CreateTemplatePage : Page
    {
        #region Fields

        const string SettingNavItemTag = "settings";
        const string CpuMemoryNavItemTag = "cpu-memory";
        const string GeneralNavItemTag = "general";

        private CreateTemplateViewModel _mainVm;

        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            (CpuMemoryNavItemTag, typeof(CpuMemoryPage)),
            (GeneralNavItemTag, typeof(GeneralPage))
        };

        #endregion

        public CreateTemplatePage()
        {
            this.InitializeComponent();

            _mainVm = new CreateTemplateViewModel();
            DataContext = _mainVm;
        }

        #region Properties



        #endregion


        #region Methods

        #region private Methods

        private void Navigate(string navItemTag, NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            if (navItemTag == SettingNavItemTag)
            {
                return; //TODO: add settings page
            }
            else
            {
                var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
                _page = item.Page;
            }

            var preNavPageType = ContentFrame.CurrentSourcePageType;

            if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
                ContentFrame.Navigate(_page, null, transitionInfo);
            }
        }

        #endregion

        #endregion

        #region Events

        private void PageNavigation_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked == true)
            {
                Navigate(SettingNavItemTag, args.RecommendedNavigationTransitionInfo);
            }
            else if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }

        #endregion


    }
}

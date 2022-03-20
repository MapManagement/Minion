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

        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            ("guest", typeof(CreateGuestPage)),
            ("template", typeof(CreateTemplatePage)),
            ("overview", typeof(ExistingGuestsPage)),
        };

        #endregion

        #region Constructor

        public MainPage()
        {
            this.InitializeComponent();

            _mainVm = new MainViewModel();
            DataContext = _mainVm;
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        private void Navigate(string navItemTag, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            if (navItemTag == "settings")
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

        #region Events

        private void PageNavigation_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked == true)
            {
                Navigate("settings", args.RecommendedNavigationTransitionInfo);
            }
            else if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }

        private void PageNavigation_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            return; //TODO: implement back
        }

        #endregion
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Minion.Windows.Preferences
{
    public partial class PreferencesWindow : Window
    {
        public PreferencesWindow()
        {
            InitializeComponent();

            DataContext = new PreferencesViewModel();
        }
    }
}

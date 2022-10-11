using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Minion.Windows.Main
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }

        #region Events

        public void OnClickMachinesButton(object sender, RoutedEventArgs e)
        {
            
        }

        public void OnClickNewMachineButton(object sender, RoutedEventArgs e)
        {

        }

        public void OnClickTemplatesButton(object sender, RoutedEventArgs e)
        {

        }

        public void OnClickPreferencesButton(object sender, RoutedEventArgs e)
        {
            
        }

        #endregion
    }
}

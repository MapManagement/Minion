using Avalonia.Controls;
using Avalonia.Interactivity;
using Minion.Windows.Machines;
using Minion.Windows.NewMachine;
using Minion.Windows.Preferences;
using Minion.Windows.Templates;


namespace Minion.Windows.Main
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        #region Events

        public void OnClickMachinesButton(object sender, RoutedEventArgs e)
        {
           var machinesWindow = new MachinesWindow();
           machinesWindow.Show();
        }

        public void OnClickNewMachineButton(object sender, RoutedEventArgs e)
        {
            var newMachineWindow = new NewMachineWindow();
            newMachineWindow.Show();
 
        }

        public void OnClickTemplatesButton(object sender, RoutedEventArgs e)
        {
            var templatesWindow= new TemplatesWindow();
            templatesWindow.Show();
        }

        public void OnClickPreferencesButton(object sender, RoutedEventArgs e)
        {
            var preferencesWindow = new PreferencesWindow();
            preferencesWindow.Show();

        }

        #endregion
    }
}

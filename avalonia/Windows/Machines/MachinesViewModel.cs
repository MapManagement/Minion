using System.ComponentModel;
using System.Collections.Generic;
using MinionProcesses.Components.Interfaces;

namespace Minion.Windows.Machines
{
    public class MachinesViewModel : INotifyPropertyChanged
    {
        #region Constructor

        public MachinesViewModel()
        {

        }

        #endregion

        #region Properties

        public List<IGuest> GuestList { get; set; }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

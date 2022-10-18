using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MinionProcesses.Components.Interfaces;
using MinionProcesses.Components;

namespace Minion.Windows.Machines
{
    public class MachinesViewModel : INotifyPropertyChanged
    {
        #region Constructor

        public MachinesViewModel()
        {
            CreateSampleGuests();
        }

        #endregion

        #region Properties

        private List<IGuest> _guestList;
        public List<IGuest> GuestList
        { 
            get { return _guestList; }
            set
            {
                _guestList = value;
                NotifyPropertyChanged();
            }
        }

        public string Test { get; set; }

        #endregion

        #region Methods

        private void CreateSampleGuests()
        {
            GuestList = new List<IGuest>()
            {
                new Guest
                (
                    "Some Guest",
                    "MySuperCoolUUID",
                    "/some/Path",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                ),
                new Guest
                (
                    "Arch",
                    "ArchUUID",
                    "/some/path/to/Arch/iso",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                ),
                new Guest
                (
                    "Win",
                    "WindowsUUID",
                    "/windows/path",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                )
            };
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;  

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}

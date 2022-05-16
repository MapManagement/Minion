using System.ComponentModel;
using System.Runtime.CompilerServices;
using MinionProcesses.Components;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.CreationPages.CreateTemplate
{
    public class CreateTemplateViewModel : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructor

        public CreateTemplateViewModel()
        {
            NewGuestObject = CreateNewGuestObject();
        }

        #endregion

        #region Properties

        private IGuest _newGuestObject;

        public IGuest NewGuestObject
        {

            get { return _newGuestObject; }
            set
            { 
                _newGuestObject = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Methods

        #region private Methods

        //TODO: create guest object here and pass it to all subpages, they edit their part like CPU, USB...
        private IGuest CreateNewGuestObject()
        {
            var newGuestObject = new Guest 
            (
                name: string.Empty,
                uuid: string.Empty,
                isoPath: string.Empty,
                guestDetails: new GuestDetails(),
                cpu: new Cpu(),
                memory: new Memory()
            );

            return newGuestObject;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #endregion

    }
}
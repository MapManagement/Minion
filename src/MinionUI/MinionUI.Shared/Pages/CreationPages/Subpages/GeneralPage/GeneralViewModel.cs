
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using MinionProcesses.Components;
using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.CreationPages.General
{
    public class GeneralViewModel : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        #region Constructor

        public GeneralViewModel()
        {
            //TODO: save any changes that already have been made and load them
            SetDefaultSpecifications();
        }

        #endregion

        #region Properties

        private IGuest _createdGuest;
        public IGuest CreatedGuest
        {

            get { return _createdGuest; }
            set
            { 
                _createdGuest = value;
                OnPropertyChanged();
            }
        }

        private IGuestDetails _createdGuestDetails;
        public IGuestDetails CreatedGuestDetails
        {
            get { return _createdGuestDetails; }
            set
            {
                _createdGuestDetails = value;
                OnPropertyChanged();
            }
        }

        public List<GuestHypervisor> HypervisorList
        {
            get { return Enum.GetValues(typeof(GuestHypervisor)).Cast<GuestHypervisor>().ToList(); }
        }

        public List<GuestArchitecture> ArchitectureList
        {
            get { return Enum.GetValues(typeof(GuestArchitecture)).Cast<GuestArchitecture>().ToList(); }
        }

        public List<GuestChipset> ChipsetList
        {
            get { return Enum.GetValues(typeof(GuestChipset)).Cast<GuestChipset>().ToList(); }
        }
        
        
        #endregion

        #region Methods

        #region Private Methods

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetDefaultSpecifications()
        {
            
        }

        #endregion

        #region Public Methods

        public void ResetSpecifications()
        {
            SetDefaultSpecifications();
        }

        #endregion

        #endregion
    }
}
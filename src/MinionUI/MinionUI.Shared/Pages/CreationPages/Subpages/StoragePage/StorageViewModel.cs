
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using MinionProcesses.Components;
using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.CreationPages.Storage
{
    public class StorageViewModel : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        #region Constructor

        public StorageViewModel()
        {
            //TODO: save any changes that already have been made and load them
            SetDefaultSpecifications();
        }

        #endregion

        #region Properties

        private List<IStorage> _storageList;
        public List<IStorage> StorageList
        {

            get { return _storageList; }
            set
            { 
                _storageList = value;
                OnPropertyChanged();
            }
        }

        public List<StorageType> StorageTypeList
        {
            get { return Enum.GetValues(typeof(StorageType)).Cast<StorageType>().ToList(); }
        }

        public List<StorageBusType> StorageBusTypeList
        {
            get { return Enum.GetValues(typeof(StorageBusType)).Cast<StorageBusType>().ToList(); }
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
            var storageList = new List<IStorage>();

            var drive = new MinionProcesses.Components.Storage("/this/is/my/path", StorageType.Disk, StorageBusType.Sata, false, true, 1);

            storageList.Add(drive);

            StorageList = storageList;

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
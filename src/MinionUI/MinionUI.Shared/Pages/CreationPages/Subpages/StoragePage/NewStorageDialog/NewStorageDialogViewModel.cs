
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using MinionProcesses.Components;
using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.CreationPages.Storage.Dialog
{
    public class NewStorageDialogViewModel : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        #region Constructor

        public NewStorageDialogViewModel()
        {

        }

        #endregion

        #region Properties

        private IStorage _newStorage;
        public IStorage NewStorage
        {

            get { return _newStorage; }
            set
            { 
                _newStorage = value;
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

        #region Public Methods


        #endregion

        #region Private Methods

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #endregion
    }
}
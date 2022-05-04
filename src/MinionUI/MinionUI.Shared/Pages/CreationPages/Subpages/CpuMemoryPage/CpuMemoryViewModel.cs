
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using MinionProcesses.Components;
using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.CreationPages.CpuMemory
{
    public class CpuMemoryViewModel : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        #region Constructor

        public CpuMemoryViewModel()
        {
            //TODO: save any changes that already have been made and load them
            SetDefaultSpecifications();
        }

        #endregion

        #region Properties

        private ICpu _createdCpu;
        public ICpu CreatedCpu
        {

            get { return _createdCpu; }
            set
            { 
                _createdCpu = value;
                OnPropertyChanged();
            }
        }

        private IMemory _createdMemory;
        public IMemory CreatedMemory
        {
            get { return _createdMemory; }
            set
            {
                _createdMemory = value;
                OnPropertyChanged();
            }
        }

        public List<CpuConfiguration> CpuConfigurationList
        {
            get { return Enum.GetValues(typeof(CpuConfiguration)).Cast<CpuConfiguration>().ToList(); }
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
            var newCpu = new Cpu
            {
                Cores = 2,
                Threads = 2,
            };

            var newMemory = new Memory
            {
                Allocation = 2048,
                MaxAllocation = 2048
            };

            CreatedCpu = newCpu;
            CreatedMemory = newMemory;
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
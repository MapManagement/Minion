using System;
using System.Collections.Generic;
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class Guest : IGuest
    {
        #region Constructor

        public Guest(string name, string uuid)
        {
            Name = name;
            Uuid = uuid;
            CreatedAt = DateTime.Now;
        }

        #endregion

        public string Name { get; set;  }
        public string? Template { get; set; }
        public string Uuid { get; set; }
        public string? Description { get; set; }
        public string? IsoPath { get; set; }
        public IGuestDetails? GuestDetails { get; set; }
        public ICpu? Cpu { get; set; }
        public IMemory? Memory { get; set; }
        public INetwork? Network { get; set; }
        public ISound? Sound { get; set; }
        public List<IStorage>? StorageDevices { get; set; }
        public List<IPciDevice>? PciDevices { get; set; }
        public List<IUsbDevice>? UsbDevices { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUsedAt { get; set; }

        public void Clone(bool cloneStorage)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(bool deleteStorage)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
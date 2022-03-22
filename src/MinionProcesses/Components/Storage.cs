using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class Storage : IStorage
    {
        public string? Path { get; set; }
        public StorageType Type { get; set; }
        public StorageBusType BusType { get; set; }
        public float Size { get; set; }
        public bool Readonly { get; set; }
        public bool Shareable { get; set; }
    }
}
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class Memory : IMemory
    {
        public int Allocation { get; set; }
        public int MaxAllocation { get; set; }
    }
}
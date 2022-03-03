namespace MinionProcesses.Components.Interfaces
{
    interface IMemory
    {
        int Allocation { get; set; }

        int MaxAllocation { get; set; }
    }
}
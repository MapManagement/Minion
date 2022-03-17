namespace MinionProcesses.Components.Interfaces
{
    public interface IMemory
    {
        int Allocation { get; set; }

        int MaxAllocation { get; set; }
    }
}
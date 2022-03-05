namespace MinionProcesses.Components.Interfaces
{
    interface IPciDevice
    {
        string Driver { get; set; }

        string Domain { get; set; }

        string Bus { get; set; }

        string Slot { get; set; }

        string Function { get; set; }
    }
}
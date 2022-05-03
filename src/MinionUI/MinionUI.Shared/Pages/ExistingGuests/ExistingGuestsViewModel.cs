using System.Collections.Generic;
using MinionProcesses.Components;
using MinionProcesses.Components.Interfaces;

namespace MinionUI.ExistingGuests
{
    public class ExistingGuestsViewModel
    {
        #region Constructor

        public ExistingGuestsViewModel()
        {
            Guests = new List<IGuest>()
            {
                new Guest
                (
                    "Some Guest",
                    "MySuperCoolUUID",
                    "/some/Path",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                ),
                new Guest
                (
                    "Arch",
                    "ArchUUID",
                    "/some/path/to/Arch/iso",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                ),
                new Guest
                (
                    "Win",
                    "WindowsUUID",
                    "/windows/path",
                    new GuestDetails(),
                    new Cpu(),
                    new Memory()
                )
            };
        }

        #endregion

        #region Properties

        public List<IGuest> Guests { get; set; }

        #endregion
    }
}
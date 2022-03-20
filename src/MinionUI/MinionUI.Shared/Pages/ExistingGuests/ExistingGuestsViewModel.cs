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
                new Guest("Test", "ABCDEF12345")
                {
                    Template = "My Template",
                    LastUsedAt = System.DateTime.Today
                },
                new Guest("Arch", "MyCoolArchId")
                {
                    Template = "Arch Template",
                    LastUsedAt = System.DateTime.Now
                },
                new Guest("Win 11", "MyWinElevenId")
                {
                    Template = "Win11",
                    LastUsedAt = System.DateTime.Today
                },

            };
        }

        #endregion

        #region Properties

        public List<IGuest> Guests { get; set; }

        #endregion
    }
}
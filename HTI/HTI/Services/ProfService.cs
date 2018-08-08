using HTI.Models;
using System.Collections.Generic;

namespace HTI.Services
{
    public class ProfService : IProfService
    {
        public List<Prof> GetProfs()
        {
            return new List<Prof>
            {
                new Prof
                {
                    Id = 1,
                    Name = "Eid Abelhakeem",
                    Email = "prof_eid@hti.com",
                    Password = "hti.123",
                    ConfirmPassword = "hti.123"
                },
                new Prof
                {
                    Id = 2, 
                    Name = "Rania Ragab",
                    Email = "prof_rania@hti.com",
                    Password = "hti.123",
                    ConfirmPassword = "hti.123"
                },
                new Prof
                {
                    Id = 3,
                    Name = "Muhammed Aboelfadl",
                    Email = "prof_fadl@hti.com",
                    Password = "hti.123",
                    ConfirmPassword = "hti.123"
                },
                new Prof
                {
                    Id = 4,
                    Name = "Waleed Khedr",
                    Email = "prog_waleed@hti.com",
                    Password = "hti.123",
                    ConfirmPassword = "hti.123"
                }
            };
        }
    }
}

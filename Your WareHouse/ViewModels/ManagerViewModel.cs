using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_WareHouse.ViewModels
{
    internal class ManagerViewModel
    {
        public int? Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string? RepeatedPassword { get; set; }
    }
}

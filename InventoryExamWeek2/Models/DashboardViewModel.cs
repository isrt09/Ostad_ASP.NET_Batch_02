using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.App.Models
{
    public class DashboardViewModel
    {
        public List<Equipment> Equipments { get; set; }
        public List<Member> Members { get; set; }
    }
}
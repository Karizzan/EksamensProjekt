using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Parent
    {
        string ParentName { get; set; }
        int CrewNumber { get; set; }
        string ParentMail { get; set; }
        string FirstPriority { get; set; }
        string SecondPriority { get; set; }
        List<Child> Children { get; set; }
    }
}

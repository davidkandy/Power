using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class TimeCapsule
    {
        public string Name { get; set; }
        public double TotalSeconds { get; set; }
    }

    public class DialogWindowContext
    {
        // Now this is the property that would be bound to.

        // Follow me to DialogWindow.xaml.cs
        public List<TimeCapsule> Capsules { get; set; } 
            = new List<TimeCapsule>();
    }
}

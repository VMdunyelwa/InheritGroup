using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022___InheritanceExample
{

    abstract class Device
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public abstract string Use();
        public virtual string OperatingSystem()
        {
            return "The OS for this device is: ";
        }
    }
    class Computer:Device 
    {
        //The override keyword invokes methods in the parent classes.
        public override string Use()
        {
            return "This is used for professional purposes.";
        }
        public override string OperatingSystem()
        {
            return base.OperatingSystem()+" Windows.";
        }
    }
}

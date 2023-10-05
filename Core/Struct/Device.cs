using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Struct
{
    public class Device
    {
        public String Name;
        public TypeDev TypeDev;
        public Brand Brand;
        public Connect Connect;
        public Protocol Protocol;
        public String Address;
        public Para Para;
      
        public Device(String Name,TypeDev TypeDev,Brand Brand,Connect Connect,Protocol Protocol, Para Para)
        {
            this.Name = Name;
            this.TypeDev = TypeDev; 
            this.Brand = Brand;
            this.Connect = Connect;
            this.Protocol = Protocol;
            this.Para = Para;
        }
    }
}

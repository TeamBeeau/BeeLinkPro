using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Struct
{
    public class Para
    {
        public string Address;
        public string Port;
        public string Struct;
        public uint TimeOut;

        public Para (string Address, string Port, string Struct, uint TimeOut)
        {
            this.Address = Address;
            this.Port = Port;
            this.Struct = Struct;
            this.TimeOut = TimeOut;
        }
    }
}

using Core.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Struct
{
    public class Unit
    {
        public String Name;
        public GroupUnit GroupUnit;
        public ParaUnit ParaUnit;
        private Node[] node;
        private Device Device;
        public Node[] Node { get => node; set => node = value; }
        public Device Device1 { get => Device; set => Device = value; }

        public Unit(String name,GroupUnit groupUnit,ParaUnit paraUnit, Node[] Node,Device device)
        { 
            Name= name;
            GroupUnit= groupUnit;
            ParaUnit= paraUnit;
            Node = node;
            Device = device;
        }

        
    }
}

using Core.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Unit
{
    public class Unit
    {
        public String Name;
        public GroupUnit GroupUnit;
        public ParaUnit ParaUnit;
        private Node[] node;
        public Node[] Node { get => node; set => node = value; }
        public Unit(String name,GroupUnit groupUnit,ParaUnit paraUnit, Node[] Node)
        { 
            Name= name;
            GroupUnit= groupUnit;
            ParaUnit= paraUnit;
            Node = node;
        }

        
    }
}

using Core.TypeVariable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Core
{
    public class Node
    {
        public string Name;
        public TypeVar TypeVar;
        public Port Port;
        private Position positions = new Position();
        #region Variable
     
        private bool @bool;
        private String @string;
        private double digit;
        public string String { get => @string; set => @string = value; }
        public Position Position { get => positions; set => positions = value; }
        public double Digit { get => digit; set => digit = value; }
        public bool Bool { get => @bool; set => @bool = value; }


        #endregion
        #region Function
        public Node(string name, TypeVar typeVar, Port port)
        {
            this.Name = name;
            this.TypeVar = typeVar;
            Port = port;
        }
        public Node(string name, TypeVar typeVar, Port port, Position position)
        {
            this.Name = name;
            this.TypeVar = typeVar;
            this.Port = port;
            this.Position = position;
        }
        public Node(string name, TypeVar typeVar, Port port,double digit)
        {
            Name = name;
            TypeVar = typeVar;
            Port = port;
            Digit = digit;

        }
        public Node(string name, TypeVar typeVar, Port port, bool bools)
        {
            Name = name;
            TypeVar = typeVar;
            Port = port;
            Bool = bools;

        }
        public Node(string name, TypeVar typeVar, Port port, String strings)
        {
            Name = name;
            TypeVar = typeVar;
            Port = port;
            String = strings;

        }
        #endregion
    }
}

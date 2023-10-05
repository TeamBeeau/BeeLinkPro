using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.TypeVariable
{
    public class Position
    {
        public float x=0;
        public float y=0;
        public float z = 0;
        public float angle = 0;
        public Position(float x, float y, float z, float angle)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.angle = angle;
        }
        public Position()
        {

        }
    }
}

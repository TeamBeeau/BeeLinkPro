using Core.Struct;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Functions
{
    public struct RW_Vision
    {

        public static dynamic Read(Unit unit,string address,TypeVar typeVar) 
        {
           /*Code*/
          
           
            return null;
        }
        public static bool Write(Unit unit, string address,dynamic value)
        {
            /*Code*/
            if(value=="1" )
            return true;
            
                return false;
        }
        public static bool Write(dynamic value)
        {
            /*Code*/
            if (value == "1")
                return true;

            return false;
        }
    }
}

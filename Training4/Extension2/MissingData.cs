using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension2
{
    internal  static class MissingData 
    {
        public static string MileStone4(this Training trai)
        {
            return "MileStone 4 has SQL";
        }
        public static string MileStone5(this Training trai)
        {
            return "Milestone 5 as capstone project";
        } 

    }
}

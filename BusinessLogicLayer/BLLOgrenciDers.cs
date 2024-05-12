using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLOgrenciDers
    {
        public static List<EntityOgrenciDers> OgrenciDersListeleBLL()
        {
            return DALOgrenciDers.OgrenciDersListele();
        }
    }
}

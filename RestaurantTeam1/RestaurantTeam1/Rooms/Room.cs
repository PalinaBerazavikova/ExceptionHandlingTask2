using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Rooms
{
    public abstract class Room
    {
        protected List<Table> tables = new List<Table>();
        public List<Table> Tables { get { return tables; } set { tables = value; } }
        protected string nameOfRoom;
        public string NameOfRoom { get { return nameOfRoom; } set { nameOfRoom = value; } }

        
    }
}

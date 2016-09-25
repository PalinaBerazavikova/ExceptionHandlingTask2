using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Rooms
{
    public class RoomForSmokers : Room
    {
        protected bool ashtray = true;
        public bool Ashtray { get { return ashtray; } private set { ashtray = value; } }


        public RoomForSmokers()
        {
            this.NameOfRoom = "smoke";
            Table table1 = new Table(2);
            Table table2 = new Table(2);
            Table table3 = new Table(4);
            Table table4 = new Table(4);
            Table table5 = new Table(6);
            this.tables.Add(table1);
            this.tables.Add(table2);
            this.tables.Add(table3);
            this.tables.Add(table4);
            this.tables.Add(table5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Rooms
{
    public class RoomForNonSmokers:Room
    {
        public RoomForNonSmokers()
        {
            this.NameOfRoom = "no-smoke";
            Table table1 = new Table(2);
            Table table2 = new Table(2);
            Table table3 = new Table(4);
            Table table4 = new Table(4);
            Table table5 = new Table(4);
            Table table6 = new Table(6);
            this.tables.Add(table1);
            this.tables.Add(table2);
            this.tables.Add(table3);
            this.tables.Add(table4);
            this.tables.Add(table5);
            this.tables.Add(table6);
        }
    }
}

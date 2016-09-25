using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1
{
    public class Guest
    {
        private Order guestOrder;
        public Order GuestOrder { get { return guestOrder; } private set { guestOrder = value; } }

    }

    /* public void ChooseRoom(string room)
     {
         switch (room)
         {
             case "smoke":
                 this.MyRoom = new RoomForSmokers();
                 break;
         }
     }*/

}

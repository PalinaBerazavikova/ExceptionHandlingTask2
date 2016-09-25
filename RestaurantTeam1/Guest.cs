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
        private double money;
        public double Money { get { return money; } private set { money = value; } }
        private string name;
        public string Name { get { return name; } private set { name = value; } }

        public Guest(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }
    }

}

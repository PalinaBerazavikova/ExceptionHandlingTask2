using RestaurantTeam1.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Workers
{
    public class Cooker : Worker
    {
        private int numberOfOrders = 0;
        public int NumberOfOrders { get { return numberOfOrders; } private set { numberOfOrders = value; } }

        public Dish CookOrder(Dish dish)
        {
            Dish preparedDish = dish;
            return preparedDish;
        }
    }
}

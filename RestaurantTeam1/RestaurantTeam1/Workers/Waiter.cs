using RestaurantTeam1.Dishes;
using RestaurantTeam1.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Workers
{
    public class Waiter : Worker
    {
        private List<Table> tablesOfWaiter = new List<Table>();
        public List<Table> TablesOfWaiter { get { return tablesOfWaiter; } set { tablesOfWaiter = value; } }

        public void ServeOrder(Order order, Cooker cooker)
        {
            List<Dish> preparedDishes = new List<Dish>();
            foreach(Dish dish in order.ListOfDishesInOrder)
            {
                preparedDishes.Add(cooker.CookOrder(dish));
            }
        }
    }
}

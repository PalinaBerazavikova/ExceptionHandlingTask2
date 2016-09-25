using RestaurantTeam1.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1
{
    public class Order
    {
        private List<Dish> listOfDishesInOrder = new List<Dish>();
        public List<Dish> ListOfDishesInOrder { get { return listOfDishesInOrder; } private set { listOfDishesInOrder = value; } }
    }
}

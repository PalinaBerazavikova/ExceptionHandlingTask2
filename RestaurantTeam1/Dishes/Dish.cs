using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Dishes
{
    public abstract class Dish
    {
        private double price;
        public double Price { get { return price; } protected set { price = value; } }
        private int priority;
        public int Priority { get { return priority; } protected set { priority = value; } }

        public Dish(double price)
        {
            this.Price = price;
        }

    }
}

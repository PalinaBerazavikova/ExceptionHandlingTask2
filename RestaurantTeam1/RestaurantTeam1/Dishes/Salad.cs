using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Dishes
{
    class Salad:Dish
    {
        public Salad(double price) : base(price)
        {
            this.Priority = 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Dishes
{
    public class Menu
    {
        private List<Dish> listOfDishesInMenu = new List<Dish>();
        public List<Dish> ListOfDishesInMenu { get { return listOfDishesInMenu; }  private set { listOfDishesInMenu = value; } }

        public Menu()
        {
            Desert cake = new Desert(12.3);
            Drink tea = new Drink(2.5);
            Salad greeceSalad = new Salad(22.0);
            Entree beef = new Entree(122.8);
            this.ListOfDishesInMenu.Add(cake);
            this.ListOfDishesInMenu.Add(tea);
            this.ListOfDishesInMenu.Add(greeceSalad);
            this.ListOfDishesInMenu.Add(beef);
        }
    }
}

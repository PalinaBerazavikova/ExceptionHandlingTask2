
using RestaurantTeam1.Dishes;
using RestaurantTeam1.Rooms;
using RestaurantTeam1.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1
{
    class Runner
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            

            //Ivan.TablesOfWaiter.Add(roomForNonSmokers.Tables[1]);
            //Order AleksandrOrder = new Order();
            //AleksandrOrder.ListOfDishesInOrder.Add(myMenu.ListOfDishesInMenu[1]);
            //double sum = 0;
            //foreach (Dish dish in AleksandrOrder.ListOfDishesInOrder)
            //{
            //    sum = sum + dish.Price;
            //}
            //if(sum < Aleksandr.Money)
            //{
            //    Ivan.ServeOrder(AleksandrOrder, Alesya);
            //}
            

            Console.ReadKey();
        }
    }
}

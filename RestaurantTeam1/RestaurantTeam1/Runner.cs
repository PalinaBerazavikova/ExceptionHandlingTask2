
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
            Menu myMenu = new Menu();
            RoomForSmokers roomForSmokers = new RoomForSmokers();
            RoomForNonSmokers roomForNonSmokers = new RoomForNonSmokers();
            List<Waiter> listOfWaiters = new List<Waiter>();
            Waiter Ivan = new Waiter();
            Waiter Petr = new Waiter();
            listOfWaiters.Add(Ivan);
            listOfWaiters.Add(Petr);
            List<Cooker> listOfCookers = new List<Cooker>();
            Cooker Alesya = new Cooker();
            listOfCookers.Add(Alesya);
            List<Guest> listOfGuests = new List<Guest>();
            Guest Aleksandr = new Guest();
            listOfGuests.Add(Aleksandr);
            roomForNonSmokers.Tables[1].GuestAtTable = Aleksandr;
            Ivan.TablesOfWaiter.Add(roomForNonSmokers.Tables[1]);
            Order AleksandrOrder = new Order();
            AleksandrOrder.ListOfDishesInOrder.Add(myMenu.ListOfDishesInMenu[1]);
            Ivan.ServeOrder(AleksandrOrder, Alesya);

            Console.ReadKey();
        }
    }
}

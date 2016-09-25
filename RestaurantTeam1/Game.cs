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
    class Game
    {
        private Guest user;
        public Guest User { get { return user; } private set { user = value; } }
        Menu myMenu = new Menu();
        public Menu MyMenu { get { return myMenu; } private set { myMenu = value; } }
        RoomForSmokers roomForSmokers = new RoomForSmokers();
        public RoomForSmokers RoomForSmokers { get { return roomForSmokers; } private set { roomForSmokers = value; } }
        RoomForNonSmokers roomForNonSmokers = new RoomForNonSmokers();
        public RoomForNonSmokers RoomForNonSmokers { get { return roomForNonSmokers; } private set { roomForNonSmokers = value; } }
        List<Waiter> listOfWaiters = new List<Waiter>();
        public List<Waiter> ListOfWaiters { get { return listOfWaiters; } private set { listOfWaiters = value; } }
        List<Cooker> listOfCookers = new List<Cooker>();
        public List<Cooker> ListOfCookers { get { return listOfCookers; } private set { listOfCookers = value; } }
        List<Guest> listOfGuests = new List<Guest>();
        public List<Guest> ListOfGuests { get { return listOfGuests; } private set { listOfGuests = value; } }


        public void StartGame()
        {
            this.CreateRestaurant();
            this.TakeYourInfo();
            this.ShowInfoAboutRestaurant();
            this.ChooseRoom();

        }

        public void TakeYourInfo()
        {
            Console.WriteLine("Приветствуем Вас в нашем ресторане! Чтобы начать игру, введите свое имя и сумму денег.");
            Console.WriteLine("Ваше имя: ");
            string name = Console.ReadLine();
            double money;
            string inputMoney;
            do
            {
                Console.WriteLine("Сколько у Вас денег(пример: 292.21): ");
                inputMoney = Console.ReadLine();
            } while (!Double.TryParse(inputMoney, out money));
            this.User = new Guest(name, money);
            Console.WriteLine($"Здравствуйте {name}! В вашем кошельке {money} руб.");
            this.listOfGuests.Add(this.User);
        }
        public void ShowInfoAboutRestaurant()
        {
            Console.WriteLine($"В нашем ресторане имеется два зала: для курящих и некурящих. Сейчас в зале для курящих {this.RoomForSmokers.Tables.Count} столов. В зале для некурящих {RoomForNonSmokers.Tables.Count} столов.");
            Console.WriteLine($"Также в ресторане сейчас работает {this.ListOfCookers.Count} поваров и {this.ListOfWaiters.Count} официантов.");
            Console.WriteLine($"В данный момент в ресторане {this.ListOfGuests.Count} посетителей.");


        }

        public void CreateRestaurant()
        {
            Waiter Ivan = new Waiter();
            Waiter Petr = new Waiter();
            this.ListOfWaiters.Add(Ivan);
            this.ListOfWaiters.Add(Petr);
            Cooker Alesya = new Cooker();
            this.ListOfCookers.Add(Alesya);
            Guest Aleksandr = new Guest("Aleksandr", 300);
            this.ListOfGuests.Add(Aleksandr);
            this.roomForNonSmokers.Tables[1].GuestAtTable = Aleksandr;
            Ivan.TablesOfWaiter.Add(roomForNonSmokers.Tables[1]);

        }

        public void ChooseRoom()
        {
            bool rightAnswer;
            Console.WriteLine("Вы курите? Yes/No");
            string choose = string.Empty;
            do
            {
                rightAnswer = true;
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "Yes":
                        {
                            Console.WriteLine("Свободные столы в зале для курящих: ");
                            this.ChooseTable(this.RoomForSmokers);
                            break;
                        }
                    case "No":
                        {
                            Console.WriteLine("Свободные столы в зале для некурящих: ");
                            this.ChooseTable(this.RoomForNonSmokers);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Попробуйте еще раз");
                            rightAnswer = false;
                            break;
                        }
                }
            } while (!rightAnswer);
        }

        public void ChooseTable(Room room)
        {
                foreach (Table table in room.Tables)
                {
                if ((!table.IsReserved) && (table.IsVacant))
                {
                    Console.WriteLine($"Стол номер {room.Tables.IndexOf(table)+1}, где {table.NumberOfChairs} стульев.");
                }
            }
            int numberOfTable;
            do {
                Console.WriteLine("Выберите стол (введите номер стола):");
            }while(!Int32.TryParse(Console.ReadLine(), out numberOfTable));
            room.Tables[numberOfTable - 1].ToTakeTable(this.User);
            Console.WriteLine($"Вы выбрали стол номер {numberOfTable}, где {room.Tables[numberOfTable - 1].NumberOfChairs} стульев.");
        }
    }
}

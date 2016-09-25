using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTeam1.Rooms
{
    public class Table
    {
        private bool isVacant = true;
        public bool IsVacant { get { return isVacant; } private set { isVacant = value; } }
        private int numberOfChairs;
        public int NumberOfChairs { get { return numberOfChairs; } private set { numberOfChairs = value; } }
        private bool isReserved = false;
        public bool IsReserved { get { return isReserved; } private set { isReserved = value; } }
        protected bool ashtray;
        public bool Ashtray { get { return ashtray; } private set { ashtray = value; } }
        protected Guest guestAtTable;
        public Guest GuestAtTable { get { return guestAtTable; }  set { guestAtTable = value; } }


        public Table(int numberOfChairs)
        {
            this.NumberOfChairs = numberOfChairs;

        }

        public Table(int numberOfChairs, bool ashtray)
        {
            this.Ashtray = ashtray;
        }

        public void ToTakeTable()
        {
            if (!this.isReserved)
            {
                this.isVacant = false;
            }
        }

        public void ToReserveTable()
        {
            if (this.isVacant)
            {
                this.isReserved = true;
            }
        }
    }
}

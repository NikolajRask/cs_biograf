using System;
namespace Biograf
{
    internal class Seat
    {

        private int seatNumber;

        private int rowNumber;

        private bool isAvailableBool;

 

        public Seat(int number,int rowNumber, bool isAvailable)
        {
            this.seatNumber = number;
            this.rowNumber = rowNumber;
            this.isAvailableBool = isAvailable;
        }

        public int getSeatNumber() {return this.seatNumber;}
        public int getRowNumber() {return this.rowNumber;}
        public bool isAvailable() {return this.isAvailableBool;}


    }
}

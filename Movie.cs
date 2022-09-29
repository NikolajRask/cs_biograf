using System;
namespace Biograf
{
    internal class Movie
    {

        private string name{ get; set; }
        private int seats;
        private int minimumAge;
        private int runTime;
        private int price;
    
        public Movie(string name, int seats, int minimumAge, int runTime, int price)
        {
            this.name = name;
            this.seats = seats;
            this.minimumAge = minimumAge;
            this.runTime = runTime;
            this.price = price;
        }

        public string getName() { return this.name; }
        public int getSeats() { return this.seats; }
        public int getMinimumAge() { return this.minimumAge; }
        public int getTime() { return this.runTime; }    
        public bool isAvailable() { if (this.seats != 0) {return true;} return false; }

        public bool reserverPlads(int x) {
            if (this.getSeats() >= x) {
                this.seats = this.seats - x;
                return true;
            } else {
                return false;
            }
        }
    }

}
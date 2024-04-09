namespace Day11WebApp.Models
{
    public class ParkingTicketMachine
    {
        public int minutesPrKr = 2;
        public int[] coinsToInsert;
        public int amountInserted;
        public DateTime timeNow;

        public ParkingTicketMachine()
        {
            this.amountInserted = 0;
            this.timeNow = DateTime.Now;
        }

        public int[] CoinsToInsert()
        {
            return this.coinsToInsert;
        }

        public DateTime TimeNow()
        {
            return timeNow;
        }

        public DateTime PaidUntil()
        {
            return timeNow.AddMinutes(minutesPrKr * amountInserted);
        }

        public int AmountInserted()
        {
            return amountInserted;
        }

        public void InsertCoin(int kr)
        {
            amountInserted += kr;
            coinsToInsert.Append(kr);
        }

    }
}

namespace Day11WebApp.Models
{
    public class ParkingTicketMachine
    {
        public int minutesPrKr = 2;
        public int[] coinsToInsert = new int[100];
        public int amountInserted;
        public DateTime timeNow;

        public ParkingTicketMachine()
        {
            this.amountInserted = 0;
            this.timeNow = DateTime.Now;
        }

        public List<int> CoinsToInsert()
        {
            return this.coinsToInsert.ToList();
        }

        public string TimeNow
        {
            get
            {
                return this.timeNow.ToString("HH:mm");
            }
        }

        public string PaidUntil
        {
            get
            {
                return timeNow.AddMinutes(minutesPrKr * amountInserted).ToString("HH:mm");
            }
        }

        public int AmountInserted
        {
            get
            {
                return amountInserted;
            }
            
        }

        public void InsertCoin(int kr)
        {
            amountInserted = kr;
            coinsToInsert.Append(kr);
        }
    }
}

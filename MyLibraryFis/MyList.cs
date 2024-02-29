namespace MyLibraryFis
{
    public class MyList<T>
    {
        private List<int> list;

        public MyList()
        {
            this.list = new List<int>();
        }

        public void AddNumber(int item)
        {
            list.Add(item);
        }

        public void PrintNumbers()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void AddRandom()
        {
            int NumbereOfRandom = 10;
            var rand = new Random();
            for (int i = 0; i < NumbereOfRandom; i++)
            {
                AddNumber(rand.Next(1, 101));
            }
        }
    }
}
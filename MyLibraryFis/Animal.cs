namespace MyLibraryFis
{
    public class Animal(string species) : IAnimal
    {
        private string species = species;

        public bool IsDog()
        {
            return species == "Hund";
        }
    }
}

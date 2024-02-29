using Day3_exercise2;

namespace Day3_Exercise2;
internal class App
{
    public static void Main()
    {
        List<Medarbejder> medarbejders = new List<Medarbejder>();
        var medarbejderCollection = new MedarbejderListe<CprNr>();

        Mekaniker mekaniker1 = new Mekaniker(new CprNr("140586", "2919"), "Anders", "Hjulvej 34", "1", 2019, 125);
        Værkfører værkfører1 = new Værkfører(new CprNr("130586", "2818"), "Hanne", "Hjulvej 33", "2", 2010, 140, 2012, 30);
        Synsmand synsmand1 = new Synsmand(new CprNr("190550", "3019"), "Per", "Hjulvej 10", "3", 1996, 200, 50);

        medarbejders.Add(mekaniker1);
        medarbejders.Add(værkfører1);
        medarbejders.Add(synsmand1);

        foreach(Medarbejder med in medarbejders)
        {
            Console.WriteLine(med.ToString());
            Console.WriteLine(med.Navn + " " + med.Adresse + " Løn pr uge: " + med.CalcWeekSalary());
        }

        medarbejderCollection.AddElement(mekaniker1.Cpr, mekaniker1);
        Console.WriteLine("Collection size: " + medarbejderCollection.size());
    }
}
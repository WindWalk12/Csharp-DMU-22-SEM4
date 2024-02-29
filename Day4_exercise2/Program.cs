using Day4_exercise2;

PowerPlant pp = new PowerPlant();

static void WarningToConsole()
{
    Console.WriteLine("Warning somethings wrong1");
}

static void WarningToConsole2()
{
    Console.WriteLine("Warning somethings wrong2");
}

//pp.SetWarning(WarningToConsole);
pp.EventWarnings += WarningToConsole;
pp.EventWarnings += WarningToConsole2;

for (int i = 0; i < 10; i++)
{
    pp.HeatUp();
}
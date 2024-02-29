
int age;
CalculateAge(new DateTime(1996, 05, 15), out age);
static void CalculateAge(DateTime BirthDateInput, out int age)
{
    age = (DateTime.Now.Date - BirthDateInput.Date).Days/365;
}

Console.WriteLine(age);
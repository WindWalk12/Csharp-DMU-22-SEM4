

static void MyMethodWithError(int num = 0)
{
    if (num == 0)
    {
        throw new Exception("num is 0");
    }
}


static void MyNormalMethod(int num = 0)
{
    try
    {
        MyMethodWithError();
    } catch (Exception ex)
    {
        Console.WriteLine(ex);
    } finally
    {
        Console.WriteLine("Error found");
    }
}

MyNormalMethod();
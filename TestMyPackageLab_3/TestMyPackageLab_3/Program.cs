using System;
using MyPackage;
public class Program
{
    public static int Main()
    {
        MyPackage.Person person = new Person("Egor", 18);
        MyPackage.User user = new MyPackage.User()
        Console.WriteLine(person);
        return 0;
    }
}
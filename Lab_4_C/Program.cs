using System;

namespace Program
{

    struct orders
    {
    public string itemname;  //наименование
    public int unitCount;       //числоединиц
    public double unitCost; //стоимостьоднойединицы

    public double Summ()
    {
        return  unitCost * unitCount;
    }
}

    public class Program
    {
        public static void Main()
        {
            orders order = new orders();
            order.itemname = "ORDERRRRRRR";
            order.unitCost = 10.5;
            order.unitCount = 10;

            System.Console.WriteLine($"Ордер: {order.itemname} суммарно стоит: {order.Summ()}");

        }
    }
}
// using System;

// abstract class HotDrink
// {
//     private int shugar = 3;
//     private int milk = 3;

//     public int Shugar{get;set;}
//     public int Milk{get;set;}

    
//     public void stringDrink(){
//         System.Console.WriteLine("Вы выпили");
//     }
//     public void AddMilk(){
//         Milk ++;
//     }
//     public void AddSugar(){
//         Shugar ++;
//     }

    

// }


// public interface ICup
// {
//     public string Type{get;set;}
//     public float Capacity{get;set;}
//     void Refill();
//     void Wash();
// }

// class CupOfCoffee : HotDrink, ICup
// {
//     public string Type{get;set;}


//     public string BeanType{get;set;}
//     public float Capacity{get;set;}
    
//     public void Refill(){
//         System.Console.WriteLine($"Повторить кофе объемом {Capacity} мл");
//     }
//     public void Wash(){
//         System.Console.WriteLine("Вымыть чашку с кофе");
//     }
//     public override string ToString()
//     {
//         return $"В кофе добавлен сахар: {Shugar}\nВ кофе добавлено молоко: {Milk}\nПолучите кофе: {Type}"; 
//     }

// }

// class CupOfTea: HotDrink, ICup
// {
//     public string Type{get;set;}
//     public string LeafType{get;set;}

//     public CupOfTea(string type, string leafType)
//     {
//         Type = type;
//         LeafType = leafType;
//     }
//     public float Capacity{get;set;}
//     public void Refill(){
//         System.Console.WriteLine($"Повторить чай объемом {Capacity} мл");
//     }
//     public void Wash(){
//         System.Console.WriteLine("Вымыть чашку с чаем");
//     }
//     public override string ToString()
//     {
//         return $"В чай добавлен сахар: {Shugar}\nВ чай добавлено молоко: {Milk}\nПолучите чай: {Type}"; 
//     }
// }

// namespace Program
// {
//     class Program{

//         public static void ProcessCup(object drink)
//         {
//             Type type = drink.GetType();
//             if(type.Equals(typeof(CupOfCoffee)))
//             {
//                 System.Console.WriteLine("\n\n");
//                 CupOfCoffee coffee=  (CupOfCoffee)Convert.ChangeType(drink, typeof(CupOfCoffee));
//                 System.Console.WriteLine(coffee);
//                 coffee.stringDrink();
//                 coffee.Refill();
//                 coffee.Wash();
                
//             }
//             else if (type.Equals(typeof(CupOfTea)))
//             {
//                 CupOfTea tea=  (CupOfTea)Convert.ChangeType(drink, typeof(CupOfTea));
//                 System.Console.WriteLine(tea);
//                 tea.stringDrink();
//                 tea.Refill();
//                 tea.Wash();
//             }

//         }
//         public static  void Main()
//         {


//             System.Console.Write("Выберите напиток: кофе(1) или чай(2): ");
//             int choise = Convert.ToInt32(Console.ReadLine());
            
//             if (choise == 1)
//             {
//                 System.Console.WriteLine("Тип зерен: арабика или робуста (арабика по умолч.)");
//                 System.Console.WriteLine("Сахар: 0 .. 5 (по умолч. 3");
//                 System.Console.WriteLine("Молоко: 0 .. 10 (по умолч. 3");
//                 System.Console.WriteLine("Тип стакана: пластик или стекло (по умолч. пластик");
//                 System.Console.WriteLine("Объем: 0,2 или 0,3 (по умолч. 0,2");
//                 CupOfCoffee coffee = new CupOfCoffee();
//                 System.Console.Write("Тип зерен: ");
//                 coffee.Type = Console.ReadLine();
//                 System.Console.Write("Молоко: ");
//                 int milk = Convert.ToInt32(Console.ReadLine());
//                 System.Console.Write("Сахар: ");
//                 int shugar = Convert.ToInt32(Console.ReadLine());
//                 System.Console.Write("Тип стакана: ");
//                 string cupType = Console.ReadLine();
//                 System.Console.Write("Объем (мл): ");
//                 double  volume = Convert.ToDouble(Console.ReadLine());

//                 // CupOfCoffee coffee = new CupOfCoffee(type, cupType);
//                 for (int i = 0; i < milk; i++)
//                 {
//                     coffee.AddMilk();
//                 }
//                 for (int i = 0; i < shugar; i++)
//                 {
//                     coffee.AddSugar();
//                 }
//                 coffee.Capacity = ((float)volume);

//                 ProcessCup(coffee);

//             }
//             else if (choise == 2)
//             {
//                 System.Console.WriteLine("Тип зерен: пуэр или азерчай (пуэр по умолч.)");
//                 System.Console.WriteLine("Сахар: 0 .. 5 (по умолч. 3");
//                 System.Console.WriteLine("Молоко: 0 .. 10 (по умолч. 3");
//                 System.Console.WriteLine("Тип стакана: пластик или стекло (по умолч. пластик");
//                 System.Console.WriteLine("Объем: 0,2 или 0,3 (по умолч. 0,2");

//             }

//         }
//     }
// }
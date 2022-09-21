using System;

namespace Program{
    public abstract class HotDrink
    {
        private int shugar = 3;
        private int milk = 3;

        public int Shugar{set{
            if ((value > 0) && (value < 10))
            {
                shugar = value;
            }
            else shugar = 3;
        }
        get{
            return shugar;
        }}
        
        public int Milk{set{
            if ((value > 0) && (value < 10))
            {
                milk = value;
            }
            else milk = 3;
        }
        get{
            return milk;
        }}

        public void stringDrink(){System.Console.WriteLine("Выпить");}
        public void AddMilk(int count){Milk = count;}
        public void AddSugar(int count){Shugar = count;}

       
    }

    public interface ICup
    {
         string Type{get;set;}
        public double Capacity{get;set;}
        void Refill();
        void Wash();
    }
    public class CupOfCoffee : HotDrink, ICup
    {
        private string type = "пластик";
        private double capacity = 0.2;
        private string beanType = "арабика";
        public string Type { get{return type;} 
                            set{if ((value == "пластик") || (value == "стекло")){
                                type = value;
        }
        else type = "пластик";
            
            }} //ТИП СТАКАНА
        public double Capacity { get{return capacity;} 
                            set{if ((value == (double)0.2) || (value == (double)0.3)){
                                capacity = value;
        }
        else capacity = 0.2;
            
            }} // ОБЪЕМ
        public string BeanType { get{return beanType;} 
                            set{if ((value == "робуста") || (value == "арабика")){
                                beanType = value;
        }
        else beanType = "арабика";
            
            }} // ТИП ЗЕРЕН 

        public void Refill()
        {
            System.Console.WriteLine($"Повторить кофе объемом {Capacity} мл");
        }

        public void Wash()
        {
            System.Console.WriteLine($"Вымыть {Type} чашку с кофе");
        }
        new public void stringDrink()
        {
            System.Console.WriteLine($"В кофе добавлен сахар: {Shugar}\nВ кофе добавлено молоко: {Milk}\nПолучите кофе: {BeanType}");
        }
        
    }
    public class CupOfTea : HotDrink, ICup
    {
        private string type = "пластик";
        private double capacity = 0.2;
        private string leafType = "черный";
        public string Type { get{return type;} 
                            set{if ((value == "пластик") || (value == "стекло")){
                                type = value;
        }
        else type = "пластик";
            
            }} //ТИП СТАКАНА
        public double Capacity { get{return capacity;} 
                            set{if ((value == (double)0.2) || (value == (double)0.3)){
                                capacity = value;
        }
        else capacity = 0.2;
            
            }} // ОБЪЕМ
        public string LeafType { get{return leafType;} 
                            set{if ((value == "черный") || (value == "зеленый")){
                                leafType = value;
        }
        else leafType = "черный";
            
            }} // ТИП ЧАЯ

        public void Refill()
        {
            System.Console.WriteLine($"Повторить чай объемом {Capacity} мл");
        }

        public void Wash()
        {
            System.Console.WriteLine($"Вымыть {Type} чашку с чаем");
        }
        new public void stringDrink()
        {
            base.stringDrink();
            System.Console.WriteLine($"В чай добавлен сахар: {Shugar}\nВ чай добавлено молоко: {Milk}\nПолучите чай: {LeafType}");
        }
        
    }
    public class Program
    {
        public static void ProcessCup(HotDrink drink)
        {
                   Type type = drink.GetType();
            if(type.Equals(typeof(CupOfCoffee)))
            {
                
                CupOfCoffee coffee =  (CupOfCoffee)Convert.ChangeType(drink, typeof(CupOfCoffee));
                coffee.stringDrink();
                coffee.Refill();
                coffee.Wash();
                
            }
            else if (type.Equals(typeof(CupOfTea)))
            {
                CupOfTea tea=  (CupOfTea)Convert.ChangeType(drink, typeof(CupOfTea));                
                tea.stringDrink();
                tea.Refill();
                tea.Wash();
            }
        }
        public static void Main(){
            System.Console.Write("Выберите напиток: кофе(1) или чай(2): ");
            int choise = Convert.ToInt32(Console.ReadLine());
            dynamic drink = null;
            if (choise == 1){
                drink = new CupOfCoffee();
                System.Console.WriteLine("\n\nТип зерен: арабика или робуста (арабика по умолч.)");
                System.Console.WriteLine("Сахар: 0 .. 5 (по умолч. 3");
                System.Console.WriteLine("Молоко: 0 .. 10 (по умолч. 3");
                System.Console.WriteLine("Тип стакана: пластик или стекло (по умолч. пластик");
                System.Console.WriteLine("Объем: 0,2 или 0,3 (по умолч. 0,2");
                System.Console.Write("\nТип зерен: ");
                drink.BeanType = Console.ReadLine();

            }
            else if(choise == 2)
            {
                drink = new CupOfTea();
                System.Console.WriteLine("\n\nТип чая: черный или зеленый (черный по умолч.)");
                System.Console.WriteLine("Сахар: 0 .. 5 (по умолч. 3");
                System.Console.WriteLine("Молоко: 0 .. 10 (по умолч. 3");
                System.Console.WriteLine("Тип стакана: пластик или стекло (по умолч. пластик");
                System.Console.WriteLine("Объем: 0,2 или 0,3 (по умолч. 0,2");
                System.Console.Write("\nТип зерен: ");
                drink.LeafType = Console.ReadLine();
            }
            else{
                Environment.Exit(0);
            }
                System.Console.Write("Молоко: ");
                int milk = Convert.ToInt32(Console.ReadLine());
                drink.AddMilk(milk);


                System.Console.Write("Сахар: ");
                int shugar = Convert.ToInt32(Console.ReadLine());
                drink.AddSugar(shugar);


                System.Console.Write("Тип стакана: ");
                drink.Type = Console.ReadLine();


                System.Console.Write("Объем (мл): ");
                drink.Capacity = Convert.ToDouble(Console.ReadLine());



            System.Console.WriteLine("--------------------------------");
            ProcessCup(drink);
            
        }
    }
}
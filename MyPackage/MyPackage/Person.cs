namespace MyPackage
{
    public class Person
    {
        string name;
        int age;
        
        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {name}\nAge: {age}";
        }
    }
}
namespace Proje08_Abstract
{
    abstract class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is created!");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Greeting()
        {
            Console.WriteLine("I am a person.");
        }
        public abstract void Intro();//Soyut Intro
    }
    class Student:Person
    {
       
        public Student(string firstName,string lastName,int studentNumber):base (firstName, lastName)
        {

        }
        public int MyProperty { get; set; }

        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
    class Teacher:Person
    {
        
       
        public string Branch { get; set; }
        public Teacher(string firstName,string lastName,string branch):base(firstName,lastName)
        {
            FirstName=firstName;
            LastName=lastName;
            Branch = branch;
        }

        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ayşen", "Umay", 101);
            student1.Greeting();
            student1.Intro();
            Teacher teacher1 = new Teacher("Maria", "Canan", "Fizik");
            teacher1.Greeting();
            teacher1.Intro();
            Console.WriteLine("");
        }
    }
}
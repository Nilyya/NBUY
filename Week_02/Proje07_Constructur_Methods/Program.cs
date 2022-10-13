namespace Proje07_Constructur_Methods
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Merhaba, ben person,şu an yaratıldım!");
        }
        public Person(string firstName, string lastName)

        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student:Person

    {
        public Student(string firstName,string lastName,int studentNumber):base(firstName,lastName)//ctor tab tab// base miras alınan sınıfta kullanımı sağlar
        {
            //FirstName=firstName;
            //LastName=lastName;
            StudentNumber=studentNumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person("Aylin","Aydemir");
            //Console.WriteLine($"{person2.FirstName}{person2.LastName}");

            Student student1 = new Student("Ahmet","Can",254);//bu çalıştığında personda yaratığımız için personda çalışır
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");
            Console.ReadLine();
        }
    }
}
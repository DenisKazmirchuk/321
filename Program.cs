using System;

namespace PersonNamespace
{
    class Person
    {
        string lastName;
        string firstName;
        int age;
        string gender;

        public Person(string lastName, string firstName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
        }

        public Person(string lastName, string firstName, int age, string gender)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.gender = gender;
        }

        // Перший метод: приймає прізвище, ім'я, вік і виводить на консоль
        public void ShowInfo(string lastName, string firstName, int age)
        {
            Console.WriteLine($"Прізвище: {lastName}, Ім'я: {firstName}, Вік: {age}");
        }

        // Другий метод: приймає прізвище, ім'я, вік, стать і виводить на консоль
        public void ShowInfo(string lastName, string firstName, int age, string gender)
        {
            Console.WriteLine($"Прізвище: {lastName}, Ім'я: {firstName}, Вік: {age}, Стать: {gender}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Іванов", "Іван", 30);
            Person person2 = new Person("Петров", "Петро", 25, "Чоловік");

            // Викликаємо перший метод
            person1.ShowInfo("Іванов", "Іван", 30);

            // Викликаємо другий метод
            person2.ShowInfo("Петров", "Петро", 25, "Чоловік");

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    struct Article
    {
        public int Code;
        public string Name;
        public double Price;
        public ArticleType Type;
    }


    enum ArticleType
    {
        Food,
        Electronics,
        Clothing,
        Books
    }


    struct Client
    {
        public int Code;
        public string FullName;
        public string Address;
        public string Phone;
        public int OrdersCount;
        public double TotalOrdersAmount;
        public ClientType Type;
    }


    enum ClientType
    {
        Regular,
        VIP,
        Premium
    }

    struct RequestItem
    {
        public Article Product;
        public int Quantity;
    }


    struct Request
    {
        public int OrderCode;
        public Client Customer;
        public DateTime OrderDate;
        public List<RequestItem> Items;
        public PayType PaymentType;

        public double TotalAmount
        {
            get
            {
                double total = 0;
                foreach (var item in Items)
                {
                    total += item.Product.Price * item.Quantity;
                }
                return total;
            }
        }
    }


    enum PayType
    {
        Cash,
        Card,
        Online
    }


    class Student
    {
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public string Group;
        public int Age;
        public int[][] Grades;

        public Student(string lastName, string firstName, string middleName, string group, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Group = group;
            Age = age;
            Grades = new int[3][];
        }

        public void SetGrade(int subjectIndex, int grade)
        {
            if (subjectIndex >= 0 && subjectIndex < Grades.Length)
            {
                if (Grades[subjectIndex] == null)
                    Grades[subjectIndex] = new int[1] { grade };
                else
                {
                    Array.Resize(ref Grades[subjectIndex], Grades[subjectIndex].Length + 1);
                    Grades[subjectIndex][Grades[subjectIndex].Length - 1] = grade;
                }
            }
        }

        public double GetAverageGrade(int subjectIndex)
        {
            if (subjectIndex >= 0 && subjectIndex < Grades.Length && Grades[subjectIndex] != null)
            {
                double sum = 0;
                foreach (var grade in Grades[subjectIndex])
                {
                    sum += grade;
                }
                return sum / Grades[subjectIndex].Length;
            }
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {LastName} {FirstName} {MiddleName}");
            Console.WriteLine($"Группа: {Group}, Возраст: {Age}");
            Console.WriteLine("Оценки:");
            Console.WriteLine($"- Программирование: {string.Join(", ", Grades[0] ?? new int[0])}");
            Console.WriteLine($"- Администрирование: {string.Join(", ", Grades[1] ?? new int[0])}");
            Console.WriteLine($"- Дизайн: {string.Join(", ", Grades[2] ?? new int[0])}");
        }
    }


    namespace SevenWonders
    {
        class GreatPyramidOfGiza
        {
            public void PrintInfo()
            {
                Console.WriteLine("Пирамида Хеопса — древнее чудо света.");
            }
        }

        class HangingGardensOfBabylon
        {
            public void PrintInfo()
            {
                Console.WriteLine("Висячие сады Семирамиды — древнее чудо света.");
            }
        }

    }


    namespace Country1
    {
        class Capital
        {
            public int Population { get; set; }
        }
    }

    namespace Country2
    {
        class Capital
        {
            public int Population { get; set; }
        }
    }

    namespace Country3
    {
        class Capital
        {
            public int Population { get; set; }
        }
    }
}


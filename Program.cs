using System;

namespace MyConsoleApp
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        
        // Parameterized constructor problem 4
        public Point(int x)
        {
            X = x;
            Y = 0;
        }


        // Override ToString method problem 5
        public override string ToString()
        {
            return $"Point [X={X}, Y={Y}]";
        }
    }

    class TypeA
    {
        public int H { get; set; }
        internal int G { get; set; }
        private int F { get; set; }

        public TypeA()
        {
            H = 10;
            G = 20;
            F = 30;
        }

        public void ModifyG(int value)
        {
            G = value;
        }

        public int GetF()
        {
            return F;
        }
    }

    public struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;
    }

    public string EmployeeName
    {
        get { return Name; }
        set { Name = value; }
    }

    public void SetEmployeeDetails(int EmpId , double Salary)
    {
        EmpId = empId;
        Salary = salary;
    }

    public void DisplayEmployeeDetails()
    {
         Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
    }


    class Program
    {
        static void ModifyPoint(Point p)
        {
            p.X = 100;
        }
        static void ModifyEmployee(Employee e)
        {
            e.Name = "Abowarda Modified";
        }
        {
        static void Main(string[] args)
        {
            #region Problem1 

            Point p1 = new Point(); // Default constructor (X and Y will be 0)
            Point p2 = new Point(10, 20); // Parameterized constructor

            Console.WriteLine($"Default constructor: {p1}");
            Console.WriteLine($"Parameterized constructor: {p2}");

            // Question: Why can't a struct inherit from another struct or class in C#?
            //Structs are value types that are stored on the stack
            //Inheritance is designed for reference types (classes) that are stored on the heap
            //Having inheritance with value types would complicate the memory model and affect performance

            #endregion

            #region Problem2
            Console.WriteLine("\nDemonstrating Access Modifiers:");
            
            TypeA obj = new TypeA();

            Console.WriteLine($"Public H: {obj.H}");

            Console.WriteLine($"Internal G: {obj.G}");
            obj.ModifyG(25);
            Console.WriteLine($"Modified Internal G: {obj.G}");


            Console.WriteLine($"Private F (accessed through public method): {obj.GetF()}");

            /* Access Modifier Impact:
             * - private: Only accessible within the declaring type
             * - internal: Accessible within the same assembly
             * - public: Accessible from anywhere
             * This helps in encapsulation and information hiding
             */
            #endregion

            #region Problem3
            Employee employee = new Employee();
            employee.EmpId = 1;
            employee.Name = "Khalid Abowarda";
            employee.Salary = 50000.0;

            //Question: Why is encapsulation critical in software design?
            //  Encapsulation ensures that internal details of a class are hidden from the outside world,
            //  and can be accessed only through well-defined interfaces.
            #endregion
        
            #region Problem4

            Point p1 = new Point(10);
            Point p2 = new Point(20, 30);
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");

            //Question: What are constructors in structs?
            //Constructors are special methods that are called when an object of a struct is created.
            // They are used to initialize the fields of the struct.
            #endregion

            #region Problem5
            Point p3 = new Point(50, 70);
            Point p4 = new Point(100, 200);
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");

            // Question: How does overriding methods like ToString() improve code readability?
            //Overriding ToString() method improves code readability by providing a clear and meaningful representation of the object's state.
            #endregion
        
            #region Problem6

            Point p = new Point(X = 10 , Y = 20);
            Employee e = new Employee(EmpId = 1, Name = "Khalid Abowarda", Salary = 50000.0);
            ModifyPoint(p);
            ModifyEmployee(e);
            Console.WriteLine($"Modified Point: {p}");
            Console.WriteLine($"Modified Employee: {e}");
        
            // Question: How does memory allocation differ for structs and classes in C#?
            //Structs are value types that are stored on the stack, while classes are reference types that are stored on the heap.
            //Structs are allocated on the stack when they are created, while classes are allocated on the heap when they are created.
            //Structs are immutable, while classes are mutable. 
            #endregion
        
        
        }
    }
}

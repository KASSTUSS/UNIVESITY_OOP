using System;

public class A
{
    public float a, b; // поля класса

    public float C // свойство - деление
    {
        get
        {
            a /= b;
            return a;
        }
    }

    public A(float a, float b)
    {
        this.a = a;
        this.b = b;
    }
}

public class B : A
{
    public float d;

    public B(float a, float b, float d) : base(a, b)
    {
        this.d = d;
    }
    public B() : this(3.14F, 1.62F, 2.71F)
    {
        this.d = 2.71F;
    }

    public float C2
    {
        get
        {
            switch (this.d)
            {
                case 3.14f: 
                    return d*5; 
                    break;
                case 1.62f:
                    return d/5;
                    break;
                case 2.71f:
                    return d * a * b;
                    break;
                default:
                    d = 404;
                    return d;
            }
        }
}

class Program
{
    public static void Main()
    {
            A MyObject = new A(5.43F, 34.22F);

            B ObjectB1 = new B();
            B ObjectB2 = new B(1.1F, 2.2F, 3.3F);
            Console.WriteLine("Object     \t a \t | \t b \t | \t d \t |");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(string.Format("ObjectB1 \t {0} \t | \t {1} \t | \t {2} \t |",
                                            ObjectB1.a, ObjectB1.b, ObjectB1.d));
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(string.Format("ObjectB2 \t {0} \t | \t {1} \t | \t {2} \t |\n",
                                            ObjectB2.a, ObjectB2.b, ObjectB2.d));

            Console.WriteLine(string.Format("MyObject:\n\n\tC result: {0}\n\n",
                                            MyObject.C));

            Console.WriteLine(string.Format("ObjectB1:\n\n\tC result: {0}\n\tC1 result: {1}\n\n",
                                            ObjectB1.C, ObjectB1.C2));

            Console.WriteLine(string.Format("ObjectB2:\n\n\tC result: {0}\n\tC1 result: {1}\n\n",
                                            ObjectB2.C, ObjectB2.C2));
        }
    }
}

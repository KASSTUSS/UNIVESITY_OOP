using System;

public class A1
{
    private float a, b; // поля класса


    public float A
    {
        get { return a; }
    }
    public float B
    {
        get { return b; }
    }
    public float C // свойство - деление
    {
        get
        {
            a /= b;
            return a;
        }
    }

    public A1(float a, float b)
    {
        this.a = a;
        this.b = b;
    }
}

public class B1 : A1
{
    private float[] ara;
    int[] array2 = new int[] { 1, 2, 3, 4, 5 };
    public float d;

    public B1(float a, float b, float d) : base(a, b)
    {
        this.d = d;
    }
    public B1() : this(3.14F, 1.62F, 2.71F)
    {
        this.d = 2.71F;
    }

    public B1(int a) : this(a, 2.71f, 3.14f)
    {
        this.d = 3.14f;
        int x = (int)A;
        ara = new float[x];
        for (int i = 0; i < x; i++)
        {
            ara[i] = C2 * i;
        }
    }

    public float C2
    {
        get
        {
            switch (this.d)
            {
                case 3.14f:
                    return d * 5;
                    break;
                case 1.62f:
                    return d / 5;
                    break;
                case 2.71f:
                    return d * A * B;
                    break;
                default:
                    d = 404;
                    return d;
            }
        }
    }

    public float[] ARA
    {
        get { return ara; }
    }
    public int[] Array2
    {
        get { return array2; }
    }
    public int this[int index]
    {
        get => array2[index];
        set => array2[index] = value;
    }
}

public class C0<T>
{
    public static string message = "This is static";
    private T[] arr = new T[3];
    public T this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }
}

public class Program
{
    public static void Main()
    {
        B1 ObjectB = new B1(7);
        for (int i = 0; i < ObjectB.Array2.Length; i++)
        {
            Console.WriteLine(ObjectB[i]);
        }
        C0<string> str_obj = new C0<string>();
        C0<int> int_obj = new C0<int>();

        for (int i = 0; i < 3; i++)
        {
            str_obj[i] = Convert.ToString(i) + " num";
        }
        for (int i = 0; i < 3; i++)
        {
            int_obj[i] = i;
        }
        Console.WriteLine(C0<int>.message);
        Console.WriteLine("Массив строк");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(str_obj[i]);
        }
        Console.WriteLine("Массив чисел");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(int_obj[i]);
        }
    }
}

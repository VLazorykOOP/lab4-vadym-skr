namespace pro100user;

public class VectorDouble
{
    private double[] FArray { get; }
    private uint num { get; }
    private int codeError { get; set; }
    private static uint num_vd { get; }

    public uint this[int i]
    {
        get
        {
            if (num >= i || i < 0)
            {
                codeError = -1;
            }

            return 0;
        }
        set { codeError = i; }
    }

    public VectorDouble()
    {
        FArray = new double[1]{0};
        num = (uint)FArray.Length;
    }
    
    public VectorDouble(uint num)
    {
        FArray = new double[num];
        this.num = num;
        for (int i = 0; i < num; i++)
        {
            FArray[i] = 0;
        }
    }
    
    public VectorDouble(uint num, double value)
    {
        FArray = new double[num];
        this.num = num;
        for (int i = 0; i < num; i++)
        {
            FArray[i] = value;
        }
    }
    
    ~VectorDouble()
    {
        Console.WriteLine("Диструктор VectorDouble");
    }

    public void Enter()
    {
        Console.WriteLine("\nВведіть значення вектору:");
        try
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Введіть {i} значення: ");
                FArray[i] = double.Parse(Console.ReadLine());
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Ви ввели не вірне значення, попробуйте ще раз.");
        }
    }

    public void Print()
    {
        Console.WriteLine("\nЗначення вектору: ");
        foreach (uint value in FArray)
        {
            Console.WriteLine($"{value} ");
        }
    }

    public void SetValueForAllElements(double value)
    {
        for (int i = 0; i < num; i++)
        {
            FArray[i] = value;
        }
    }

    public static VectorDouble operator +(VectorDouble vector)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = ++vector.FArray[i];
        }

        return vector;
    }
    
    public static VectorDouble operator -(VectorDouble vector)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = --vector.FArray[i];
        }

        return vector;
    }
    
    public static VectorDouble operator +(VectorDouble vector, int scalar)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = vector.FArray[i] + scalar;
        }

        return vector;
    }
    
    public static VectorDouble operator -(VectorDouble vector, double scalar)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = vector.FArray[i] - scalar;
        }

        return vector;
    }
    
    public static VectorDouble operator /(VectorDouble vector, double scalar)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = vector.FArray[i] / scalar;
        }

        return vector;
    }
    
    public static VectorDouble operator *(VectorDouble vector, double scalar)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = vector.FArray[i] / scalar;
        }

        return vector;
    }
    
    public static VectorDouble operator %(VectorDouble vector, double scalar)
    {
        for (int i = 0; i < vector.num; i++)
        {
            vector.FArray[i] = vector.FArray[i] % scalar;
        }

        return vector;
    }
}
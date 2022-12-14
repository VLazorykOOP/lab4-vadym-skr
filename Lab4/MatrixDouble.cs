namespace pro100user;

public class MatrixDouble
{
    private double[,] DArray { get; }
    private int n { get; } 
    private int m { get; }
    private int codeError { get; set; }
    private static int num_mf { get; }

    public uint this[int i, int j]
    {
        get
        {
            if ((i >= n || i < 0) && (j >= m || j < 0))
            {
                codeError = -1;
            }

            return 0;
        }
        set { codeError = i; }
    }

    public MatrixDouble()
    {
        DArray = new double[1, 1]{{0}};
        n = DArray.Length;
        m = 1;
    }
    
    public MatrixDouble(int n, int m)
    {
        DArray = new double[n ,m];
        this.n = n;
        this.m = m;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                DArray[i, j] = 0;
            }
        }
    }
    
    public MatrixDouble(int n, int m, uint value)
    {
        DArray = new double[n ,m];
        this.n = n;
        this.m = m;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                DArray[i, j] = value;
            }
        }
    }
    
    ~MatrixDouble()
    {
        Console.WriteLine("Диструктор MatrixDouble");
    }

    public void Enter()
    {
        Console.WriteLine("\nВведіть значення матриці:");
        try
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введіть matrix[{i}, {j}] значення: ");
                    DArray[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Ви ввели не вірне значення, попробуйте ще раз.");
        }
    }

    public void Print()
    {
        Console.WriteLine("\nЗначення матриці: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{DArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void SetValueForAllElements(double value)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                DArray[i, j] = value;
            }
        }
    }

    public static MatrixDouble operator +(MatrixDouble matrix)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = ++matrix.DArray[i, j];
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator -(MatrixDouble matrix)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = --matrix.DArray[i, j];
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator +(MatrixDouble matrix, double scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = matrix.DArray[i, j] + scalar;
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator -(MatrixDouble matrix, double scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = matrix.DArray[i, j] - scalar;
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator /(MatrixDouble matrix, double scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = matrix.DArray[i, j] / scalar;
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator *(MatrixDouble matrix, double scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = matrix.DArray[i, j] / scalar;
            }
        }

        return matrix;
    }
    
    public static MatrixDouble operator %(MatrixDouble matrix, uint scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.DArray[i, j] = matrix.DArray[i, j] % scalar;
            }
        }

        return matrix;
    }
}
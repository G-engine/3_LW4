namespace task1;

public class MyMatrix
{
    private int[,]? matrix;
    private int n1;
    private int n2;
    private int x;
    private int y;

    public MyMatrix(int x, int y, int number1, int number2)
    {
        matrix = new int[x, y];
        this.x = x;
        this.y = y;
        n1 = number1;
        n2 = number2;
        Random rnd = new Random();
        
        for(int i = 0; i < x; ++i)
            for (int j = 0; j < y; ++j)
                matrix[i, j] = rnd.Next(n1, n2 + 1);
    }
    
    public MyMatrix(int x, int y)
    {
        matrix = new int[x, y];
        this.x = x;
        this.y = y;
    }

    public static MyMatrix operator +(MyMatrix m1, MyMatrix m2)
    {
        if (m1.x == m2.x && m1.y == m2.y)
        {
            MyMatrix m = new MyMatrix(m1.x, m1.y);
            for (int i = 0; i < m1.x; i++)
            for (int j = 0; j < m1.y; j++)
                m[i, j] = m1[i, j] + m2[i, j];
            return m;
        }

        throw new Exception("Non-additive matrix");
    }
    
    public static MyMatrix operator -(MyMatrix m1, MyMatrix m2)
    {
        if (m1.x == m2.x && m1.y == m2.y)
        {
            MyMatrix m = new MyMatrix(m1.x, m1.y);
            for (int i = 0; i < m1.x; i++)
            for (int j = 0; j < m1.y; j++)
                m[i, j] = m1[i, j] - m2[i, j];
            return m;
        }

        throw new Exception("Non-additive matrix");
    }
    
    public static MyMatrix operator *(MyMatrix m1, int n)
    {
        MyMatrix m = new MyMatrix(m1.x, m1.y);
        for (int i = 0; i < m1.x; i++)
            for (int j = 0; j < m1.y; j++)
                m[i, j] = m1[i, j] * n;
        return m;
    }
    
    public static MyMatrix operator /(MyMatrix m1, int n)
    {
        MyMatrix m = new MyMatrix(m1.x, m1.y);
        for (int i = 0; i < m1.x; i++)
        for (int j = 0; j < m1.y; j++)
            m[i, j] = m1[i, j] / n;
        return m;
    }
    
    public static MyMatrix operator *(MyMatrix m1, MyMatrix m2)
    {
        if (m1.y == m2.x)
        {
            int x = m1.x;
            int y = m2.y;

            MyMatrix m = new MyMatrix(x, y);
            
            
            for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < m1.y; ++k)
                    m[i, j] += m1[i, k] * m2[k, j];
            }
            
            return m;
        }
        throw new Exception("Non-multiple matrix");
    }
    
    public int this[int index1, int index2]
    {
        get
        {
            if (index1 < 0 || index1 >= x || index2 < 0 || index2 >= y)
                return 0;
            return matrix[index1, index2];
        }
        set 
        {
            if (index1 < 0 || index1 >= x || index2 < 0 || index2 >= y) {}
            else matrix[index1, index2] = value;
        }
    }
    
    public void Show()
    {
        for (int i = 0; i < x; ++i)
        {
            for (int j = 0; j < y; ++j)
                Console.Write($"{matrix[i,j]} ");
            Console.WriteLine();
        }
    }
}
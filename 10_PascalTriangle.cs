class PascalTriangle
    {
    static void Main()
    {
        int i, j;
        int[,] a = new int[10, 10];
        Console.WriteLine("输入杨辉三角行数:");
        int.TryParse(Console.ReadLine(), out int n);
        for (i = 0; i < n; i++)
        {
            a[i, 0] = 1;
            for (j = 1; j <= i; j++)
            {
                a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
            }
        }
        for (i = 0; i < n; i++)
        {
            for (j = 0; j <= i; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
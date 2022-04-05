//三种循环求阶乘
class loop
{
    static void Main()
    {
        long s = 1;
        int n;
        Console.WriteLine("输入数字求阶乘:");
        int.TryParse(Console.ReadLine(), out int t);

        //for循环
        for (n = t; n > 1; n--)
        {
            s = s * n;
        }
        Console.WriteLine(s);

        //while循环
        n = t;
        s = 1;
        while (n > 1)
        {
            s = s * n;
            n--;
        }
        Console.WriteLine(s);

        //do-while循环
        n = t;
        s = 1;
        do
        {
            s = s * n;
            n--;
        }
        while (n > 1);
        Console.WriteLine(s);
    }

}
//����ѭ����׳�
class loop
{
    static void Main()
    {
        long s = 1;
        int n;
        Console.WriteLine("����������׳�:");
        int.TryParse(Console.ReadLine(), out int t);

        //forѭ��
        for (n = t; n > 1; n--)
        {
            s = s * n;
        }
        Console.WriteLine(s);

        //whileѭ��
        n = t;
        s = 1;
        while (n > 1)
        {
            s = s * n;
            n--;
        }
        Console.WriteLine(s);

        //do-whileѭ��
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
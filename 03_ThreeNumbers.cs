//三个随机数从小到大输出
class ThreeNumbers
{
    static void Main(string[] args)
    {
        int[] num = new int[100];
        for (int i = 0; i < num.Length; i++)
        {
            Random rd = new();
            num[i] = rd.Next(1, 101);
        }

        //bubbleSort
        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j < num.Length - 1 - i; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int t = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = t;
                }
            }
        }
        Console.WriteLine("从小到大：");
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }
    }
}
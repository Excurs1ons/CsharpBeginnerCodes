//输入三角形边长，求周长和面积
class Triangle
{
    static void Main(string[] args)
    {
        double[] side = new double[3];
        for (int i = 0; i < side.Length; i++)
        {
            Console.WriteLine("输入三角形第{0}条边长:", i + 1);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out side[i])) break;
                else
                {
                    Console.WriteLine("输入错误，重新输入");
                    continue;
                }
            }
        }
        if (side[0] + side[1] > side[2] && side[1] + side[2] > side[0] && side[0] + side[2] > side[1] && side[0] > 0 && side[1] > 0 && side[2] > 0)
        {
            //周长和面积
            double c = side[0] + side[1] + side[2];
            var p = c / 2;
            Console.WriteLine("周长：{0},面积：{1}", c, Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2])));
        }
        else
        {
            Console.WriteLine("无法构成三角形");
        }
    }
}


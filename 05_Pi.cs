
class PI
{
    static void Main()
    {
        int n = 100000;
        double a = 0, s = 1;
        //莱布尼茨级数求圆周率
        for (int i = 0; i < n; i++)
        {
            a += s * (1 / (2d * i + 1));
            s = -s;
        }
        Console.WriteLine("莱布尼茨级数{0}次收敛,结果为{1}", n, (a * 4));
        Console.WriteLine("ArcTan公式,结果为{0}", 4 * (Math.Atan(1 / 2d) + Math.Atan(1 / 5d) + Math.Atan(1 / 8d)));
    }

}
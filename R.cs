//输入半径，求对应圆的周长、面积和对应的球体的体积；
class R
{
    const double PI = 3.14;
    static void Main(string[] args)
    {
        Console.WriteLine("输入半径:");
        while (true)
        {
            if (!double.TryParse(Console.ReadLine(), out double r))
            {
                Console.WriteLine("输入有误，重新输入:");
            }
            else
            {
                Console.WriteLine("周长:[0},面积:{1},体积:{2}", 2 * PI * r, PI * r * r, (4d / 3) * PI * r * r * r);
                break;
            }
        }
        Console.WriteLine("按任意键退出");
        Console.ReadKey();
    }
}

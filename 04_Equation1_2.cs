//ax^2+bx+c=0
class Equation1_2 
{
    static void Main1(string[] args)

    {
        Console.WriteLine("解一元二次方程");
        Console.WriteLine("输入二次项系数");
        double.TryParse(Console.ReadLine(), out double a);
        Console.WriteLine("输入一次项系数");
        double.TryParse(Console.ReadLine(), out double b);
        Console.WriteLine("输入常数项");
        double.TryParse(Console.ReadLine(), out double c);
        Console.WriteLine("方程为{0}x^2+{1}x+{2}=0", a, b, c);
        if (b * b >= 4 * a * c)
        {
            Console.WriteLine("X1={0}", (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
            Console.WriteLine("X2={0}", (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
        }
        else
        {
            Console.WriteLine("方程无解");
        }
        Console.WriteLine("按任意键退出");
        Console.ReadKey();
    }
}
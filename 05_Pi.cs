
class PI
{
    static void Main()
    {
        int n = 100000;
        double a = 0, s = 1;
        //������ļ�����Բ����
        for (int i = 0; i < n; i++)
        {
            a += s * (1 / (2d * i + 1));
            s = -s;
        }
        Console.WriteLine("������ļ���{0}������,���Ϊ{1}", n, (a * 4));
        Console.WriteLine("ArcTan��ʽ,���Ϊ{0}", 4 * (Math.Atan(1 / 2d) + Math.Atan(1 / 5d) + Math.Atan(1 / 8d)));
    }

}
//求10学生的平均身高、最高身高、最低身高以及高于平均身高的人数
class Height
{
    static void Main()
    {
        float[] height = new float[10];
        //输入数据
        for (int i = 0; i < height.Length; i++)
        {
            float.TryParse(Console.ReadLine(), out height[i]);
        }
        //求平均值
        float average = 0, max = height[0], min = height[0], n = 0;
        foreach (float i in height)
        {
            average += i / 10f;
        }
        //比较大小
        foreach (float i in height)
        {
            if (i > average) n++;
            if (i < min) min = i;
            if (i > max) max = i;
        }
        //输出结果
        Console.WriteLine("平均身高:{0}、最高身高:{1}、最低身高:{2}、高于平均身高的人数:{3}", average, max, min, n);
    }
}


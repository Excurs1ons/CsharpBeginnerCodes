//��10ѧ����ƽ����ߡ������ߡ��������Լ�����ƽ����ߵ�����
class Height
{
    static void Main()
    {
        float[] height = new float[10];
        //��������
        for (int i = 0; i < height.Length; i++)
        {
            float.TryParse(Console.ReadLine(), out height[i]);
        }
        //��ƽ��ֵ
        float average = 0, max = height[0], min = height[0], n = 0;
        foreach (float i in height)
        {
            average += i / 10f;
        }
        //�Ƚϴ�С
        foreach (float i in height)
        {
            if (i > average) n++;
            if (i < min) min = i;
            if (i > max) max = i;
        }
        //������
        Console.WriteLine("ƽ�����:{0}��������:{1}��������:{2}������ƽ����ߵ�����:{3}", average, max, min, n);
    }
}


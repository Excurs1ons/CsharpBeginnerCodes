//�������10��ͬѧ�ĳɼ���ʹ��ð�ݷ�����
class GradesBubbleSort
{
    static void Main()
    {
        Random random = new Random();
        int[] grade = new int[10];
        Console.WriteLine("����ǰ");
        for (int i = 0; i < grade.Length; i++)
        {
            grade[i] = random.Next(0, 100);
            Console.WriteLine("��{0}��ѧ���ɼ�Ϊ{1}", i + 1, grade[i]);
        }

        for (int i = 0; i < grade.Length - 1; i++)
        {
            for (int j = 0; j < grade.Length - i - 1; j++)
            {
                if (grade[j] > grade[j + 1])
                {
                    int t = grade[j + 1];
                    grade[j + 1] = grade[j];
                    grade[j] = t;
                }
            }
        }
        Console.WriteLine("�����");
        for (int i = 0; i < grade.Length; i++)
        {
            Console.WriteLine("��{0}��ѧ���ɼ�Ϊ{1}", i + 1, grade[i]);
        }
    }
}
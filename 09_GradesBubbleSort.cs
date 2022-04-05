//随机生成10个同学的成绩，使用冒泡法排序
class GradesBubbleSort
{
    static void Main()
    {
        Random random = new Random();
        int[] grade = new int[10];
        Console.WriteLine("排序前");
        for (int i = 0; i < grade.Length; i++)
        {
            grade[i] = random.Next(0, 100);
            Console.WriteLine("第{0}个学生成绩为{1}", i + 1, grade[i]);
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
        Console.WriteLine("排序后");
        for (int i = 0; i < grade.Length; i++)
        {
            Console.WriteLine("第{0}个学生成绩为{1}", i + 1, grade[i]);
        }
    }
}
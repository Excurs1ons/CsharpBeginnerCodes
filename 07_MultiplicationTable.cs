//´òÓ¡³Ë·¨¿Ú¾÷
class MultiplicationTable
{
    static void Main()
    {
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine();
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0}x{1}={2}\t", j, i, i * j);
            }
        }
    }
}
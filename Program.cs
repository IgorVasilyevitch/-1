// Массив образуем, вводя данные с клавиатуры
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string[] StringMassive;
        int count;
        int SymbolLimit = 3;
        string EnterData;
        string[] OldMassive;

        Console.WriteLine("Введите данные для построения массива: ");
        count = 0;
        StringMassive = new string[count];

        do
        {
            EnterData = Console.ReadLine();

            if (EnterData != "")
            {
                count++;

                OldMassive = new string[count];
                                                 

                for (int i = 0; i < OldMassive.Length - 1; i++)
                    OldMassive[i] = StringMassive[i];

                OldMassive[count - 1] = EnterData;

                StringMassive = OldMassive;
            }
        }
        while (EnterData != "");

        Console.Write("[");
        for (int i = 0; i < StringMassive.Length; i++)
        {
            if (StringMassive[i].Length <= SymbolLimit)
                if (i != StringMassive.Length - 1)
                    Console.Write($"{StringMassive[i]}, ");
                else
                    Console.Write($"{StringMassive[i]}"); ;
        }
        Console.Write("]");
    }
}

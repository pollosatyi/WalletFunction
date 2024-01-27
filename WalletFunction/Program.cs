namespace WalletFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для обмена");
            while (true)
            {
                int inputNumber = 0;
                Console.WriteLine("Введите 1 для добавления RUB на счет");
                Console.WriteLine("Введите 0 для выхода");

                string stringInputNumber = Console.ReadLine();
                if (int.TryParse(stringInputNumber, out int number))
                {
                    inputNumber = number;
                }
                else
                {
                    Console.WriteLine("Это не число");
                    continue;
                }
                if (inputNumber == 0)
                {
                    Console.WriteLine("Выход из программы");
                }


                switch (inputNumber)
                {
                    case 1:
                        Console.WriteLine("12122112");
                        

                        break;
                    case 2:
                        break;
                    default: Console.WriteLine("Неверный ввод"); break;
                }
            }
        }
    }
}

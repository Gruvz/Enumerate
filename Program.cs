using MainEnumerate;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Enumerates
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("1 - Программа Example_1 переводит в разные температыные единицы");


            Console.Write("Выбирите номер программы:");
            int Enter = int.Parse(Console.ReadLine());


            switch (Enter)
            {
                case 1:
                    Console.Write("\n \nВведите температару в Цельсиях:");
                    string EnterString = Console.ReadLine().Replace('.', ',');
                    double Temp = Convert.ToDouble(EnterString);
                    var Example_1 = new Example_1("Celsius", Temp);
                    break;

            }




            Console.ReadLine();
        }
    }
}
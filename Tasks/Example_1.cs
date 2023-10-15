using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainEnumerate
{
    /*
     * Создайте перечисление TemperatureUnits для представления единиц измерения температуры (Celsius, Fahrenheit, Kelvin). 
     * Напишите метод, который преобразует температуру Цельсия в другие  единицы
     */
    internal class Example_1
    {
        public enum TemperatureUnits : int
        {
            Celsius = 1,
            Fahrenheit,
            Kelvin
        }

        string _Name;
        double _Temp;

        public Example_1(string _name, double _temp)
        {

            _Name = _name;
            _Temp = _temp;

            string[] TemperatureUnitsNames = Enum.GetNames<TemperatureUnits>();


            Console.WriteLine($"Система может работать со следующими единицуами изменрения");

            for (int i = 1; i < 3; i++)
                foreach (string name in TemperatureUnitsNames)
                {
                    Console.WriteLine($"{i} - {name}");
                    i++;
                }

            Console.WriteLine($"Указанная температура по умолчанию указана в Celsius вы ввели темературу {_Temp}");
            Console.Write("Введи номер в какой формат вы хотите переоброзовать температуру? : ");
            int EnterUser = int.Parse(Console.ReadLine());

            switch (EnterUser)
            {
                case 1:
                    Console.WriteLine($"Указанное вами знанчение уже было в Цельсиях {_Temp}");
                    break;
                case 2:
                    double FahrenheitConvert = Math.Round(_Temp * 1.8 + 32, 2);
                    Console.WriteLine($"Значение указанное в Цельсии {_Temp} в Фаренгейтах будет {FahrenheitConvert}");
                    break;
                case 3:
                    double KelvinConvert = Math.Round(_Temp + 273.15, 2);
                    Console.WriteLine($"Значение указанное в Цельсии {_Temp} в Кельвинах будет {KelvinConvert}");
                    break;
                default:
                    Console.WriteLine("Вы ввели не верный номер");
                    break;

            }





        }
    }
}




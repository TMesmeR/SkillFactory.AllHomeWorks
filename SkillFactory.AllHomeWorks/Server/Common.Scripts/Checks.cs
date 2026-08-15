namespace SkillFactory.AllHomeWorks.Server.Common.Scripts
{
    /// <summary>
    /// Содержит методы для чека в различных случаях
    /// </summary>
    internal static class Checks
    {
        /// <summary>
        /// чек для проверки выбора из категорий товара
        /// </summary>
        /// <param name="keyValuePairs">словарь для категорий</param>
        /// <returns></returns>
        internal static sbyte CheckPick(Dictionary<int, string> keyValuePairs)
        {
            while (true)
            {


                if (sbyte.TryParse(Console.ReadLine(), out var value) && value > -1 && value < keyValuePairs.Count + 1)
                    return value;
                else
                    Console.WriteLine($"Введите число от 1 до {keyValuePairs.Count} для выбора");

            }

        }
        /// <summary>
        /// Чек для проверки выбора из  товаров в определенной категории.
        /// </summary>
        /// <param name="keyValuePairs">словарь с ценами</param>
        /// <returns></returns>
        internal static sbyte CheckPick(Dictionary<int, (string,int)> keyValuePairs)
        {
            while (true)
            {


                if (sbyte.TryParse(Console.ReadLine(), out var value) && value > -1 && value < keyValuePairs.Count + 1)
                    return value;
                else
                    Console.WriteLine($"Введите число от 1 до {keyValuePairs.Count} для выбора");

            }

        }

        internal static sbyte CheckPickMenu()
        {
            while (true)
            {


                if (sbyte.TryParse(Console.ReadLine(), out var value) && value > -1 && value <= 4)
                    return value;
                else
                    Console.WriteLine($"Введите число от 1 до 4 для выбора");

            }

        }

        internal static sbyte CheckPickWayDelivers()
        {
            while (true)
            {


                if (sbyte.TryParse(Console.ReadLine(), out var value) && value > -1 && value <= 3)
                    return value;
                else
                    Console.WriteLine($"Введите число от 1 до 3 для выбора");

            }

        }



    }
}

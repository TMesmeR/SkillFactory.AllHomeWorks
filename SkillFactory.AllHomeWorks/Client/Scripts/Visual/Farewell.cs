namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{
    /// <summary>
    /// Прощание к клиентом
    /// </summary>
    internal class Farewell
    {
        
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine($"Спасибо что был с нами {ServerUser.clientUser.GetUserName()}");
            Console.WriteLine($"Будем ждать твоего возвращения!");
            Console.ReadKey();  
        }
    }
}

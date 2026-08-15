namespace SkillFactory.AllHomeWorks.Server.Products
{
    /// <summary>
    /// Содержит группы и названия продуктов
    /// Ну и заодно реализована индексация
    /// </summary>
    public class ArraysOfProducts
    {

        public static ArraysOfProducts arraysOfProducts = new ArraysOfProducts(); 

        private  string[] _allArraysOfProduct = ("Фрукты,Овощи,Злаки и крупы,Мясо и птица,Рыба и морепродукты," +
            "Молочные продукты,Жиры и масла,Сладости и десерты,Напитки,Приправы и соусы,Орехи и семена").Split(",");


        private string[] _fruits = "Яблоки\r\nБананы\r\nАпельсины\r\nГруши\r\nВиноград\r\nКлубника\r\nМалина\r\nЧерника\r\nАрбуз\r\nДыня\r\nПерсики\r\nАбрикосы".Split("\r\n");
        private string[] _vegetables = "Картофель\r\nМорковь\r\nСвекла\r\nЛук\r\nЧеснок\r\nБрокколи\r\nЦветная капуста\r\nШпинат\r\nСалат\r\nОгурцы\r\nПомидоры\r\nПерец сладкий\r\nКабачки\r\nБаклажаны\r\nГрибы\r\nСельдерей\r\nИмбирь\r\nХрен".Split("\r\n");
        private string[] _cereals = "Хлеб\r\nБулочки\r\nБагет\r\nЦельнозерновой хлеб\r\nРис\r\nГречка\r\nМакароны\r\nОвсянка\r\nКукурузные хлопья\r\nМюсли".Split("\r\n");
        private string[] _meatPoutry = "Куриное филе\r\nГовядина\r\nСвинина\r\nБаранина\r\nИндейка\r\nУтка".Split("\r\n");
        private string[] _fishSeafood = "Лосось\r\nТреска\r\nКреветки\r\nМидии".Split("\r\n");
        private string[] _dairy = "Сыр\r\nТворог\r\nМолоко\r\nКефир\r\nЙогурт\r\nСливки\r\nМасло сливочное\r\nЯйца".Split("\r\n");
        private string[] _fatsOils = "Оливковое масло\r\nПодсолнечное масло\r\nМаргарин".Split("\r\n");
        private string[] _sweetsDesserts = "Сахар\r\nМед\r\nШоколад\r\nКонфеты\r\nПеченье\r\nТорт\r\nМороженое\r\nЖеле\r\nВаренье".Split("\r\n");
        private string[] _drinks = "Чай\r\nКофе\r\nКакао\r\nСок\r\nВода минеральная\r\nЛимонад\r\nКвас\r\nПиво\r\nВино\r\nВодка\r\nБурбон\r\nВиски\r\nРом\r\nТекила\r\nЛикер\r\nАбсент".Split("\r\n");
        private string[] _seasoningsSauce = "Уксус\r\nСоевый соус\r\nТоматная паста\r\nМайонез\r\nКетчуп\r\nГорчица".Split("\r\n");
        private string[] _nutsSeens = "Орехи (грецкие)\r\nОрехи (фундук)\r\nОрехи (миндаль)\r\nСемечки подсолнуха\r\nСемечки тыквы".Split("\r\n");

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameIndex"></param>
        /// <returns>
        /// Индексы: 
        /// allArraysOfProduct - список всех групп продуктов
        /// fruits - список фруктов
        /// vegetable -список овощей
        /// cereals - Злаки и крупы
        /// meatPoutry - Мясо и птица
        /// fishSeafood - Рыба и морепродукты
        /// dairy - Молочные продукты
        /// fatsOils - Жиры и масла
        /// _sweetsDesserts - Сладости и десерты
        /// drinks - Напитки
        /// seasoningsSauce - Приправы и соусы
        /// nutsSeens - Орехи и семена
        /// </returns>
        /// <exception cref="Exception"></exception>
        public string[] this[string nameIndex]
        {
            get
            {
                switch (nameIndex)
                {

                    case "allArraysOfProduct":
                        return _allArraysOfProduct;
                    case "fruits":
                        return _fruits;
                    case "vegetable":
                        return _vegetables;
                    case "cereals":
                        return _cereals;
                    case "meatPoutry":
                        return _meatPoutry;
                    case "fishSeafood":
                        return _fishSeafood;
                    case "dairy":
                        return _dairy;
                    case "fatsOils":
                        return _fatsOils;
                    case "sweetsDesserts":
                        return _sweetsDesserts;
                    case "drinks":
                        return _drinks;
                    case "seasoningsSauce":
                        return _seasoningsSauce;
                    case "nutsSeens":
                        return _nutsSeens;
                    default:
                        throw new Exception("Значение не найдено.");

                }
            }
        }

     
        
    }
}

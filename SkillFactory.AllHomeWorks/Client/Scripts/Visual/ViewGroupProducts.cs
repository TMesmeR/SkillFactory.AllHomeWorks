using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Products;
using SkillFactory.AllHomeWorks.Server.User;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{   /// <summary>
/// Вывод категорий товаров, а так же товаров из категорий.
/// </summary>
    internal class ViewGroupProducts
    {

        internal static void PrintCategories()
        {
            Dictionary<int, string> Group;
            Dictionary<int, (string,int)> Products;
            sbyte pickCategory;
            sbyte pickPosicion;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите 0 для возврата в меню");
                Console.WriteLine("Выберите категорию товаров:");
                Console.WriteLine();
                Group = DictionaryOf.ViewGroups(ArraysOfProducts.arraysOfProducts["allArraysOfProduct"]);

                pickCategory = Checks.CheckPick(Group);

                if (pickCategory == 0)
                {
                    Console.Clear();
                    break;
                }

                Console.Clear();

                //---------------------------------------------------------------------------------------------------------------//
                while (true)
                {
                    
                    Console.WriteLine("Введите 0 для возврата в категории");
                    Console.WriteLine("Выберите товар для добавления в корзину");
                    Console.WriteLine();

                    SwitchPick(pickCategory, out Products);

                    pickPosicion = Checks.CheckPick(Products);


                    if (pickPosicion == 0)
                    {
                        Console.Clear();
                        break;
                    }

                    Console.Clear();
                    BasketUser.AddInBasketUser(pickPosicion, Products);

                    Console.WriteLine("Для продолжение введите Enter..");
                    Console.ReadLine();

                    Console.Clear();
                }
            }
        }




        static void SwitchPick(sbyte num, out Dictionary<int, (string,int)> DictIdNameCost)
        {

            switch (num)
            {
                default:
                case 1:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["fruits"]);
                    break;
                case 2:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["vegetable"]);
                    break;
                case 3:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["cereals"]);
                    break;
                case 4:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["meatPoutry"]);
                    break;
                case 5:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["fishSeafood"]);
                    break;
                case 6:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["dairy"]);
                    break;
                case 7:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["fatsOils"]);
                    break;
                case 8:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["sweetsDesserts"]); ;
                    break;
                case 9:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["drinks"]);
                    break;
                case 10:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["seasoningsSauce"]);
                    break;
                case 11:
                    DictIdNameCost = DictionaryOf.ViewProducts(ArraysOfProducts.arraysOfProducts["nutsSeens"]);
                    break;
            }

        }
    }

}
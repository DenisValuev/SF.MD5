namespace Module_5.Unit_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.Write("Введите имя пользователя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            Console.WriteLine("Введите пять любимых блюд");
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine($"Блюдо номер {i + 1}");
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}

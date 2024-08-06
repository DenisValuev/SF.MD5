namespace Module_5.Unit_2
{
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine(username + ", " + userage + " лет\n" + "Напишите свой любимый цвет на английском языке с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow");
                    break;
            }

            return color;
        }
        static void DisplayColors(string[] colors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] _array)
        {
            int temp;
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        temp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
            return _array;
        }
        static void ShowArray(int[] _array, bool IsSort = false)
        {
            var temp = _array;
            if (IsSort)
            {
                temp = SortArray(_array);
            }
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = int.Parse(Console.ReadLine());
            var favColors = new string[3];
            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor(anketa.name, anketa.age);
            }
            DisplayColors(favColors);
            var array = GetArrayFromConsole(10);
            var sortedarray = SortArray(array);
            ShowArray(array, true);
            
        }
    }
}

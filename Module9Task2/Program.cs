namespace Module9Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]? lastname = null;

            Exception exceptionname = new Exception("Фамилии не введены"); //Исключение, возникает при некорректном вводе данных
            Exception exceptiontype = new Exception("Тип сортировки выбран некорректно"); //Исключение, возникает при не правильном выборе сортироки


            Console.WriteLine("Введите фамилии через пробел");

            var isInput = true;
            while (isInput)
            {
                try
                {
                    lastname = Console.ReadLine().Split(" ");
                    if (lastname.Length <= 1) throw exceptionname;
                    else isInput = false;
                }
                catch (Exception ex) when (ex.Message == "Фамилии не введены")
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    lastname ??= new string[0];
                }
            }

            Console.WriteLine("Выберите способ сортировки 1 - А-Я, 2 - Я-А");

            StartCommand startCommand = new StartCommand();
            startCommand.Notify += NotifyCommand;

            isInput = true;
            while (isInput)
            {
                try
                {
                    var Command = Console.ReadLine();
                    if (Command != "1" && Command != "2")
                        throw exceptiontype;

                    else isInput = false;
                    startCommand.Read(lastname, Command);
                }
                catch (Exception ex) when (ex.Message == "Тип сортировки выбран некорректно")
                {
                    Console.WriteLine(ex.Message);
                }


            }

            Console.WriteLine("Результат:");

            foreach (var item in lastname)
            {
                Console.WriteLine(item);
            }
        }


        /// Метод для обработки событий

        static public void NotifyCommand(string[] lastname, string message)
        {
            switch (message)
            {
                case "Сортировка А-Я":
                    SortString.Sort(lastname, SortString.TypeSort.Down);
                    break;
                case "Сортировка Я-А":
                    SortString.Sort(lastname, SortString.TypeSort.Up);
                    break;
            }
        }
    }
}
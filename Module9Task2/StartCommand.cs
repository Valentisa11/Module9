namespace Module9Task2
{
    /// Класс обработки введенных команд

    public class StartCommand
    {
        public delegate void Input(string[] lastname, string input);
        public event Input? Notify;
        private string[]? LastName;

        public void Read(string[] lastname, string str)
        {
            LastName = lastname;
            switch (str)
            {
                case "1": Notify?.Invoke(LastName, "Сортировка А-Я"); break;
                case "2": Notify?.Invoke(LastName, "Сортировка Я-А"); break;
            }
        }
    }
}
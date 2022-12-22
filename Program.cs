using System.IO;

namespace Module9Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Массив исключений
            Exception[] exception = new Exception[5];
            exception[0] = new FileNotFoundException("Файл не существует");
            exception[1] = new DriveNotFoundException("Диск недоступен или не существует");
            exception[2] = new DirectoryNotFoundException("Каталог не существует или недоступен");
            exception[3] = new ArgumentOutOfRangeException("Аргумент находится за пределами диапазона допустимых значений");
            exception[4] = new MyException("Мое исключение");//Мое собственное исключение
            try
            {
                throw exception[4];//создание моего исключения
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Работает!");
            }
        }
    }
}
public class MyException : Exception
{
    public MyException()
    { }

    public MyException(string message)
        : base(message)
    { }
}
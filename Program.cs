using PointAndLines;

namespace OOPPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(); //Nyt objekt

            user.Username = "Abcde"; //tildeler
            System.Console.WriteLine(user.Username); //udskriver
            user.Password = 21221;
            System.Console.WriteLine(user.Password);

        }
    }
}

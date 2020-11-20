using System;

namespace Exercise_Week4_Robert
{
    public class Hs
    {
        public static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(14);
        }
        public static string HasPassword(string Password)
        {
            return BCrypt.Net.BCrypt.HashPassword(Password, GetRandomSalt());
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Masukkan Username Anda = ");
            string name = Console.ReadLine();

            Console.Write("Password Anda = ");
            string password = Console.ReadLine();
            string hashing = Hs.HasPassword(password);

            Console.WriteLine("Halo " + name);
            Console.Write("Ini Password " + name + " Setelah Di Hashing " + "'" + hashing + "'");

        }
    }
}
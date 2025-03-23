using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj numer roli od 1 do 3: ");
            if (int.TryParse(Console.ReadLine(), out int roleId))
            {
                string role=GetUserRole(roleId);
                Console.WriteLine(role);
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór");
            }
            Console.ReadKey();
        }

        private static string GetUserRole(int roleId)
        {
            if (roleId == 1) return "Admainistrator";
            else if (roleId == 2) return "Menedżer";
            else if (roleId == 3) return "Użytkownik";
            else return "Nieznana rola";
        }
    }
}


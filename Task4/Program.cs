using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 4 
//Створiть клас «Веб-сайт». Необхiдно зберirати у полях класу: назву сайту, шлях до сайту, опис сайту, iр-адресу сайту.
//Реалiзуйте методи класу для введения даних, виведення даних.
//Реалiзуйте доступ до окремих полiв через методи класу. 
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web web = new Web();

            try
            {
                web.Input();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"\n\n{web}\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 5 
//Створiть клас «Журнал». Необхiдно зберirати у полях класу: назву журналу, опис журналу, контактний телефон, email.
//Реалiзуйте методи класу для введения даних, виведення даних.
//Реалiзуйте доступ до окремих полiв через методи класу. 
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal jour = new Journal();
            try
            {
                jour.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\n{jour}\n");
        }
    }
}

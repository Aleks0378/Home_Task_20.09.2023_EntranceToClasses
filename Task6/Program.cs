using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 6
//Створiть клас «Магазин». Необхiдно зберirати у полях
//класу: назву магазину, адреса, опис профiлю магазину,
//контактний телефон, eшail. Реалiзуйте методи класу для
//введения даних, виведення даних. Реалiзуйте доступ до
//окремих полiв через методи класу.
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop newshop = new Shop();
            try
            {
                newshop.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\n{newshop}\n");
        }
    }
}

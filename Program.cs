using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Criando_exceções.Entities;

using Criando_exceções.Entities.Exceptions;
namespace Criando_exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number:  ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());



                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomianException e)
            {
                Console.WriteLine("Error in reservation: "+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("format error: "+e.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine( "Unexpected error: "+e.Message);
            }







        }
    }
}

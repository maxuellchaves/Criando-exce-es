using System;
using System.Text;
using Criando_exceções.Entities.Exceptions;

namespace Criando_exceções.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkout)
        {
            if (checkout <= checkIn)
            {
                throw new DomianException("Error in reservation: Check-out date must be after check-in date ");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            Checkout = checkout;
        }

        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
               throw new DomianException("Error in reservation for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
              throw new DomianException( "Error in reservation: Check-out date must be after check-in date ");
            }

            CheckIn = checkIn;
            Checkout = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            StringBuilder show = new StringBuilder();
            show.Append("Room ");
            show.Append(RoomNumber);
            show.Append(", check-In: ");
            show.Append(CheckIn.ToString("dd/MM/yyyy"));
            show.Append(", check out: ");
            show.Append(Checkout.ToString("dd/MM/yyyy")+", ");
            show.Append(Duration()+" nights");


            return show.ToString();


        }
    }
}

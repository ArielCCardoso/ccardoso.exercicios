using System;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo9.Composition1.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public double TotalValue
        {
            get
            {
                return Hours * ValuePerHour;
            }
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        /*
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
        */
    }
}

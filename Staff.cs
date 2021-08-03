using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStaff
{
    public class Staff
    {
        private const float 5;
        public float Totalpay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        private float hourlyRate;
        private int hWorked;
       

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (HoursWorked > 0)
                {
                    HoursWorked = hWorked;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }

        public Staff()
        {

        }

        public Staff(string name, float rate)
        {
            name = NameOfStaff;
            rate = hourlyRate;
        }

        public Staff(object macario, int v1, int v2)
        {
            this.macario = macario;
            this.v1 = v1;
            this.v2 = v2;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculando el pago ...");
            BasicPay = hWorked * hourlyRate;
            BasicPay = Totalpay;
        }

        public override string ToString()
        {
            string datosStaff = "\n Name: " + NameOfStaff + "\n Hours Worked:  " + HoursWorked + "\n Total Pay:  "  + Totalpay;
            return datosStaff ;
        }

    }
}

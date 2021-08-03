using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStaff
{
  public  class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }

        public Manager (String name) : base (name, managerHourlyRate)
        {

        }

        public override void CalculatePay()
        {
           CalculatePay().base. CalculatePay();

            
            if(HoursWorked > 160)
            {
                Allowance = 1000;
            }
    }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

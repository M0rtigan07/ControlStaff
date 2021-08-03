using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStaff
{
    public class Admin : Staff
    {
        private const float overtimeRate = 15;
        private const float adminHourlyRate = 30;

        public float Overtime { get; private set; }

        public Admin(String name) : base(name, adminHourlyRate)
        {

        }

        public override void CalculatePay()
        {
            base.CalculatePay();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

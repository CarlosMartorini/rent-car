using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}

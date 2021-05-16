using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestWithMoq.Services
{
   public interface IPaymentService
    {
        bool Charge(double total, ICard card);
    }
}

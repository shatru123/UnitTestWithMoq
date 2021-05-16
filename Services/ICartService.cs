using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestWithMoq.Services
{
   public interface ICartService
    {
        double Total();
        IEnumerable<CartItem> Items();
    }
}

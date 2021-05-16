using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestWithMoq.Services
{
   public interface IShipmentService
    {
        void Ship(IAddressInfo info, IEnumerable<CartItem> items);
    }
}

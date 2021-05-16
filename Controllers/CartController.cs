using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestWithMoq.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitTestWithMoq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IPaymentService _paymentService;
        private readonly IShipmentService _shipmentService;

        public CartController(
          ICartService cartService,
          IPaymentService paymentService,
          IShipmentService shipmentService
        )
        {
            _cartService = cartService;
            _paymentService = paymentService;
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public string CheckOut(ICard card, IAddressInfo addressInfo)
        {
            var result = _paymentService.Charge(_cartService.Total(), card);
            if (result)
            {
                _shipmentService.Ship(addressInfo, _cartService.Items());
                return "charged";
            }
            else
            {
                return "not charged";
            }
        }
    }
}

using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.Enum;
using Repo.ViewModel;

namespace Web.Controllers
{
    public class CartController : Controller
    {
        ICart crepo;
        public CartController(ICart crepo)
        {
            this.crepo = crepo;
        }
        public IActionResult AddToCart(Int64 gfid, Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            //Int64 offerid = Convert.ToInt64(HttpContext.Session.GetString("OfferId"));

            if (userid == 0)
            {
                return RedirectToAction("SignIn", "User");
            }
            else  
            {
                var res = this.crepo.AddToCart(gfid, userid, storeid);
                //TempData["Message"] = res.Message;
                return RedirectToAction("gift", "Home");
            }

        }
        public IActionResult AddToGreetingCart(Int64 gcid, Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            //Int64 offerid = Convert.ToInt64(HttpContext.Session.GetString("OfferId"));

            if (userid == 0)
            {
                return RedirectToAction("SignIn", "User");
            }
            else
            {
                var res = this.crepo.AddToGreetingCart(gcid, userid, storeid);
                //TempData["Message"] = res.Message;
                return RedirectToAction("greeting", "Home");
            }

        }
       
        public IActionResult GetCart()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            
             return View(userid);
        }
        public IActionResult DeleteCart(Int64 CartId)
        {
            this.crepo.Delete(CartId);
            return RedirectToAction("GetCart");
        }

        public IActionResult CheckOut(int PaymentMode)
        {
            if (PaymentMode == (int)PaymentModeEnum.CashOnDelivery)
            {
                //TempData["OrderID"] = id.ToString();
                return RedirectToAction("PlaceOrder", new { pmode = PaymentMode });
            }
            else
            {
                //TempData["OrderID"] = id.ToString();
                return RedirectToAction("PaymentGateway", new { pmode = PaymentMode });
            }
        }

        [HttpGet]
        public IActionResult PlaceOrder(int pmode)
        {
            
            //find userid
            //Int64 abcd = orderId1;
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            OrderDeliveryVM odvrec = new OrderDeliveryVM();
            odvrec.DeliveryAddress = HttpContext.Session.GetString("DeliveryAddress");
            odvrec.DeliverToPersonName = HttpContext.Session.GetString("DeliverToPersonName");
            odvrec.PinCode = HttpContext.Session.GetString("PinCode");
            odvrec.ContactNo = HttpContext.Session.GetString("ContactNo");
            odvrec.CityId =Convert.ToInt64(HttpContext.Session.GetString("CityId"));
            var res = this.crepo.PlaceOrder(userid, pmode,odvrec);
            if (res.IsSuccess)
            {
                return View();
            }
            ViewBag.Message = res.Message;
            return RedirectToAction("GetCart");
        }

        [HttpGet]
        public IActionResult PaymentGateway(int pmode)
        {

            //TempData["OrderID"] = orderId1;
            //payment gateway code. 
            ViewBag.PaymentMode = pmode;
            return View();
        }


        [HttpPost]
        [ActionName("PaymentGateway")]
        public IActionResult ProcessPaymentGateway(int pmode)
        {
            OrderDeliveryVM odvrec = new OrderDeliveryVM();
            odvrec.DeliveryAddress = HttpContext.Session.GetString("DeliveryAddress");
            odvrec.DeliverToPersonName = HttpContext.Session.GetString("DeliverToPersonName");
            odvrec.PinCode = HttpContext.Session.GetString("PinCode");
            odvrec.ContactNo = HttpContext.Session.GetString("ContactNo");
            odvrec.CityId = Convert.ToInt64(HttpContext.Session.GetString("CityId"));
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            //Int64 abcd = id;
            var res = this.crepo.PlaceOrder(userid, pmode,odvrec);
            if (res.IsSuccess)
            {
                return View("PlaceOrder");
            }
            ViewBag.Message = res.Message;
            return RedirectToAction("GetCart");
        }

    }
}

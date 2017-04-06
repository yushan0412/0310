using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSalex.Controllers
{
    public class OrderController : Controller
    {
        /// <summary>
        /// 訂單管理系統首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // Models.OrderService orderService = new Models.OrderService();
            // var order = orderService.GetOrderById("111");
            // ViewBag.CustId = order.CustId;

            return View();
        }

        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            ViewBag.Desc1 = "我是ViewBag";
            ViewData["Desc2"] = "我是ViewData";
            TempData["Desc3"] = "我是TempData";

            return RedirectToAction("Index");
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "GSS";
            //result.CustId = "叡揚資訊";

            var result = new Models.Order() { CustId = "GSS", CustName = "叡揚資訊" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
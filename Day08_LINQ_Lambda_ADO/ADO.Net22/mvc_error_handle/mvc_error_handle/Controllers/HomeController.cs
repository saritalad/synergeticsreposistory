using mvc_error_handle.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_error_handle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            try
            {
                c = a / b; //it would cause exception.  
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            finally
            {
            }
            return View();
           
        }
        public ActionResult Index1()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            c = a / b; //it would cause exception.             
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            string action = filterContext.RouteData.Values["action"].ToString();
            Exception e = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
        [HandleError]
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "Error1")]
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "Error2")]
        public ActionResult Index2()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            c = a / b; //it would cause exception.             
            return View();
        }
        [MyExceptionHandler]
        public ActionResult Index3()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            c = a / b; //it would cause exception.             
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
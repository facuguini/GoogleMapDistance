using Parcial1_TFI_FacundoGuini.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial1_TFI_FacundoGuini.Controllers
{
    public class TypeController : Controller
    {
        // GET: Type
        public ActionResult Index()
        {
            return new JsonResult()
            {
                Data = new ShipmentTypeLogic().Get(),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}
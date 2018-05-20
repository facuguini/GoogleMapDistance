using Parcial1_TFI_FacundoGuini.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial1_TFI_FacundoGuini.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            return new JsonResult()
            {
                Data = new VehicleLogic().Get(),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}
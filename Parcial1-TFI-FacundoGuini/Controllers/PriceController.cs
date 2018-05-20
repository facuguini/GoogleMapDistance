using Parcial1_TFI_FacundoGuini.Entities;
using Parcial1_TFI_FacundoGuini.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Parcial1_TFI_FacundoGuini.Controllers
{
    public class PriceController : Controller
    {
        // GET: Price
        public async Task<ActionResult> Index(PriceRequest req)
        {
            return new JsonResult()
            {
                Data = await new PriceLogic().Get(req.Address, req.ShipmentType, req.Vehicle),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}

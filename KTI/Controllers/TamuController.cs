using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTI.Models;
using KTI.DAL;

namespace KTI.Controllers
{
    public class TamuController : Controller
    {
        // GET: Tamu
        public ActionResult Index()
        {
            using (TamuDAL service = new TamuDAL())
            {
                var tamu = service.GetDataTamu().ToList();


                return View(tamu);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tamu tamu)
        {
            using (TamuDAL service = new TamuDAL())
            {
                service.Add(tamu);
            }
            return RedirectToAction("Index");
        }
    }
}
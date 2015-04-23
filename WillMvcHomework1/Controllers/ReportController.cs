using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WillMvcHomework1.Models;

namespace WillMvcHomework1.Controllers
{
    public class ReportController : Controller
    {
        private 客戶資料08Entities db = new 客戶資料08Entities();

        // GET: Report
        public ActionResult Index()
        {
            return View(db.客戶報表.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WillMvcHomework1.Models;

namespace WillMvcHomework1.Controllers
{
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class ValidationController : Controller
    {
        private 客戶資料08Entities db = new 客戶資料08Entities();

        public JsonResult IsMailAvailable(string Email, int 客戶Id, int Id)
        {
            var data = from contact
                       in db.客戶聯絡人
                       where contact.Email == Email && contact.客戶Id == 客戶Id && contact.Id != Id
                       select contact;

            return Json(data.Count() == 0, JsonRequestBehavior.AllowGet);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayUIDemo.Models;

namespace LayUIDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll(int page, int limit)
        {
            List<StuInfo> stulist = new List<StuInfo>();
            using (DBEntities db = new DBEntities())
            {
                stulist = db.StuInfo.OrderBy(x => x.StuID).ToList();
            }
            
            var redata = new {
                code = 0,
                count = stulist.Count(),
                data = stulist.Skip((page - 1) * limit).Take(limit).ToList(),
                msg = "sss"
            };
            //var redata = new ReJson<StuInfo>(){
            //   code = 0,
            //   count = stulist.Count(),
            //   data = stulist.Skip((page - 1) * limit).Take(limit).ToList(),
            //    msg = "sss"
            //};
            return Json(redata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddStu()
        {
            return View();
        }

        public ActionResult GetClassList()
        {
            List<ClassInfo> list = new List<ClassInfo>();
            using (DBEntities db = new DBEntities())
            {
                list = db.ClassInfo.ToList();
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
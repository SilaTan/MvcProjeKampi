using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());

        public PartialViewResult Index(int id=1)
        {
            var contentvalues = cm.GetListByHeadingId(id);
            return PartialView(contentvalues);
        }

        public ActionResult Headings()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
    }
}
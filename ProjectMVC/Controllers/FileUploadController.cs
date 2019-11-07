using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            var name = Request.Form["Name"];

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];

                string mimeType = file.ContentType;

                var guid = Guid.NewGuid();
                var ext = mimeType.Split('/').LastOrDefault();

                ViewBag.Guid = string.Format("{0}.{1}", guid, ext);

                file.SaveAs(Server.MapPath("~/Images/Products/") + string.Format("{0}.{1}", guid, ext));
            }
            
            return View("Show");
        }
    }
}
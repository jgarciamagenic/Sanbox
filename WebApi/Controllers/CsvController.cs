using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CsvController : Controller
    {
        // GET: Csv
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Export2(string contents)
        {
            StringBuilder sb = new StringBuilder(contents);
            StringWriter sw = new StringWriter(sb);
                        
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(sw.ToString());
            return File(buffer, "text/csv");
        }
        
        public ActionResult Export()
        {
            var list = new List<PersonModel>();

            list.Add(new PersonModel() { Id = 1, Name = "Josh" });
            list.Add(new PersonModel() { Id = 2, Name = "Frank" });
            list.Add(new PersonModel() { Id = 1, Name = "Tony" });

            StringWriter sw = new StringWriter();

            sw.WriteLine("\"Id\",\"Name\"");

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Exported_People.csv");
            Response.ContentType = "text/csv";

            foreach (var line in list)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\"",
                                           line.Id,
                                           line.Name));
            }

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(sw.ToString());
            return File(buffer, "text/csv");
        }

    }
}
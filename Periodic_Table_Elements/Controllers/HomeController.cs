using Periodic_Table_Elements.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvHelper;

namespace Periodic_Table_Elements.Controllers
{
    public class HomeController : Controller
    {
        PeriodicTableDBContext db  = new PeriodicTableDBContext();
		List<element> elements = new List<element>();
        public ActionResult Index()
        {
			var data = db.elements.ToList();
            ViewBag.Type = db.elements.Select(m => m.type).Distinct().ToList();
			string directoryPath = @"C:\Users\Admin\Downloads\";

			// Tạo thư mục nếu nó không tồn tại
			Directory.CreateDirectory(directoryPath);

			// Đường dẫn đến file CSV
			string filename = Path.Combine(directoryPath, "elements.csv");

			using (var reader = new StreamReader(filename))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				elements = csv.GetRecords<element>().ToList();
			}
			//// Ghi dữ liệu vào file CSV
			//using (var writer = new StreamWriter(filename))
			//{
			//	// Ghi header
			//	writer.WriteLine("element_id,group,period,atomic_number,atomic_mass,symbol,name,type");

			//	// Ghi dữ liệu từ list 'people' vào file CSV
			//	foreach (var dat in db.elements.ToList())
			//	{
			//		writer.WriteLine($"{dat.element_id},{dat.group},{dat.period},{dat.atomic_number},{dat.atomic_mass},{dat.symbol},{dat.name},{dat.type}");
			//	}
			//}
			return View(elements);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var data = db.elements.ToList();
            return View(data);
        }
    }
}
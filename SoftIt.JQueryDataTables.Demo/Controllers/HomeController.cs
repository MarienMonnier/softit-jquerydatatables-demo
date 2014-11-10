using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SoftIt.JQueryDataTables.Demo.Models;
using SoftIt.JQueryDataTables.Demo.Services;

namespace SoftIt.JQueryDataTables.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData(DTParameters dtModel, FilterViewModel filterModel)
        {
            try
            {
                List<Product> data = new ProductService().GetProducts(dtModel.Search.Value, dtModel.SortOrder, dtModel.Start, dtModel.Length, filterModel.MinPrice, filterModel.MaxPrice);
                int count = new ProductService().Count(dtModel.Search.Value, filterModel.MinPrice, filterModel.MaxPrice);
                DTResult<Product> result = new DTResult<Product>
                                    {
                                        draw = dtModel.Draw,
                                        data = data,
                                        recordsFiltered = count,
                                        recordsTotal = count
                                    };
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }
    }
}
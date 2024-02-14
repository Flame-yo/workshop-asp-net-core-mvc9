using Microsoft.AspNetCore.Mvc;
using SalesWebMvc9.Models;
using SalesWebMvc9.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebMvc9.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            List<SalesRecord> list = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            return View(list);
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}

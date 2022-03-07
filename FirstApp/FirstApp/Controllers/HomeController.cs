using FirstApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Sample()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sample(CustomerViewModel newCustomer)
        {
            if(ModelState.IsValid)
            {
                return View(newCustomer);
            }
            //return RedirectToAction("Error", ModelState);
            return View();
        }

        public IActionResult BadReq()
        {
            return BadRequest(new { Mesaj = "Aradığın sayfayı bulamadık...." });
        }

        public IActionResult Success()
        {
            return Ok(new SuccessViewModel { StatusCode = 200, Message = "İşlem Başarılı." });
        }

        public IActionResult PageNotFound()
        {
            return NotFound();
        }

        public IActionResult ForbiddenPage()
        {
            return StatusCode(403, "Sunucu hatası, bu sayfaya erişim yasaklanmıştır.");
        }

        public IActionResult StatusKodlari()
        {
            return StatusCode(StatusCodes.Status202Accepted);
        }

        public IActionResult ServerError()
        {
            return StatusCode(StatusCodes.Status501NotImplemented);
        }
    }
}

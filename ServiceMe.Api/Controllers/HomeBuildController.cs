using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuildHomeApi.Controllers
{
    public class HomeBuildController : Controller
    {
        private ISampleBusiness sampleBusiness;

        public HomeBuildController(ISampleBusiness sampleBusiness)
        {
            this.sampleBusiness = sampleBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
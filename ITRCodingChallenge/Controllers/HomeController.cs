/**
 * This web app is for the ITR Coding Challenge
 * Written by Michael McMillan
 */

using ITRCodingChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ITRCodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            var rand = new Random();
            var tableNumbers = new List<int>();

            int rowCount = rand.Next(1, 30);

            for (int x = 0; x < rowCount; x++)
            {
                tableNumbers.Add(rand.Next(1, 10000));
            }

            return View(new TableViewModel
            {
                TableNumbers = tableNumbers
            });
        }
    }
}

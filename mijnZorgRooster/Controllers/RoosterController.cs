﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mijnZorgRooster.Data;

namespace mijnZorgRooster.Controllers
{
	public class RoosterController : Controller
	{
		private readonly ZorginstellingContext _context;

		public RoosterController(ZorginstellingContext context)
		{
			_context = context;
		}

		public IActionResult Rooster()
		{
			return View(); 
		}
	}
}
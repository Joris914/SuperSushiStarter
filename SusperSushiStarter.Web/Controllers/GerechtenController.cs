using Microsoft.AspNetCore.Mvc;
using SuperSushi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSushiStarter.Web.Controllers
{
	public class GerechtenController : Controller
	{
		IGerechtRepository repo = new GerechtRepositorySql();
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace officesapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class LoginController : Controller
  {
    [HttpGet]
    public JsonResult Get()
    {
      return Json("Hello world");
    }
  }
}
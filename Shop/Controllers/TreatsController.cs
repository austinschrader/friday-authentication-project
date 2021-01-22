using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shop.Controllers
{
  public class TreatsController : Controller
  {
    private readonly ShopContext _db;

    public TreatsController(ShopContext db)
    {
      _db = db;
    }
  }
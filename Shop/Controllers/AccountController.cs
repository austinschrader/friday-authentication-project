using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Shop.Models;
using System.Threading.Tasks;
using Shop.ViewModels;

namespace Shop.Controllers
{
  public class AccountController : Controller
  {
    private readonly ShopContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ShopContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
  }
}
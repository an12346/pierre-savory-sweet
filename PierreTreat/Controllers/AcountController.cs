using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RecipeBook.Models;
using System.Threading.Tasks;
using RecipeBook.ViewModels;

namespace PierreTreat.Controllers
{
  private readonly PierreTreatContext _db;
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signManager;

  publicAccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierreTreatContext db)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _db = db;
  }

  public ActionResult Index()
  {
    return View();
  }
}
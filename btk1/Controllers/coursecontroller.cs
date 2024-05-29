using Microsoft.AspNetCore.Mvc;
using btk1.Models;
namespace btk1.Controllers;


public class coursecontroller:Controller
{
    public IActionResult Index()
    {
        var model = repository.Application;
        return View(model);
    }
    public IActionResult apply()
    {
        return View();// get için çalýþýyor
    }

    [HttpPost]
    [ValidateAntiForgeryToken] //güvenli iletiþim için
    public IActionResult apply(candidate model)
    {
        if(repository.Application.Any(c=>c.email.Equals(model.email))) {
            ModelState.AddModelError("", "There is already application for you.");
        }

        if (ModelState.IsValid) {
            repository.add(model);
            return View("feedback", model);
        }
        return View();
    }
}
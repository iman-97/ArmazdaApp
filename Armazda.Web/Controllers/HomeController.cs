using Armazda.Models.ViewModels;
using Armazda.Services.Interfaces;
using Armazda.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Armazda.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IImagesService _imagesService;

    public HomeController(ILogger<HomeController> logger, IImagesService imagesService)
    {
        _logger = logger;
        _imagesService = imagesService;
    }

    public IActionResult Index()
    {
        return View(new CreateData());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateData model)
    {
        var result = await _imagesService.AddImage(model);

        if (result == true)
            ViewBag.Notif = "Image Added";
        else
            ViewBag.Notif = "Adding Failed";

        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
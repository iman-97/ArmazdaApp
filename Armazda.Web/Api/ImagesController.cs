using Armazda.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Armazda.Web.Api;

[Route("api/[controller]")]
[ApiController]
public class ImagesController : ControllerBase
{
    private readonly IImagesService _imagesService;

    public ImagesController(IImagesService imagesService)
    {
        _imagesService = imagesService;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetData()
    {
        var data = await _imagesService.GetAllImages();

        return Ok(data);
    }
}

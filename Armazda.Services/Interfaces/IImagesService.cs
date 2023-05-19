using Armazda.Models.Models;
using Armazda.Models.ViewModels;

namespace Armazda.Services.Interfaces;

public interface IImagesService
{
    Task<List<ImageData>> GetAlImages();
    Task<bool> AddImage(CreateData data);
}

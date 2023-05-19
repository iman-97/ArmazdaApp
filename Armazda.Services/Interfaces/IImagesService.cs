using Armazda.Models.DTOs;
using Armazda.Models.Models;
using Armazda.Models.ViewModels;

namespace Armazda.Services.Interfaces;

public interface IImagesService
{
    Task<List<ImageDataDTO>> GetAllImages();
    Task<bool> AddImage(CreateData data);
}

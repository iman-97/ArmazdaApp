using Armazda.DataAccess;
using Armazda.Models.DTOs;
using Armazda.Models.Models;
using Armazda.Models.ViewModels;
using Armazda.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Armazda.Services;

public class ImagesService : IImagesService
{
    private readonly ApplicationDbContext _dbContext;

    public ImagesService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ImageDataDTO>> GetAllImages()
    {
        return await _dbContext.ImageDatas
            .Select(x => new ImageDataDTO
            {
                Name = x.Name,
                VideoLink = x.VideoLink,
                Image = x.Image
            }).ToListAsync();
            
    }

    public async Task<bool> AddImage(CreateData data)
    {
        var imageData = new ImageData
        {
            Name = data.Name,
            VideoLink = data.VideoLink,
            Image = await GetByteArrayFromImage(data.Image)
        };

        await _dbContext.ImageDatas.AddAsync(imageData);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    private async Task<byte[]> GetByteArrayFromImage(IFormFile file)
    {
        using var target = new MemoryStream();

        await file.CopyToAsync(target);
        return target.ToArray();
    }

}

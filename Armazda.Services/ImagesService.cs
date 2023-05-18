using Armazda.DataAccess;
using Armazda.Models.Models;
using Armazda.Services.Interfaces;

namespace Armazda.Services;

public class ImagesService : IImagesService
{
    private readonly ApplicationDbContext _dbContext;

    public ImagesService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<ImageData> GetAlImages()
    {
        return _dbContext.ImageDatas.ToList();
    }

}

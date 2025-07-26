using System.IO;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface ICategoryImporter
    {
        Task<ImportResult> ImportCategoriesAsync(Stream csvStream);
    }
}

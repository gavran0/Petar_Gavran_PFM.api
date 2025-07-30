using PFM.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategoriesAsync(string? parentCode = null);
    }


}

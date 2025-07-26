using PFM.Application.DTO;
using PFM.Application.Services;
using PFM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly PFMDbContext _context;

        public CategoryService(PFMDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryDto>> GetCategoriesAsync(string? parentCode = null)
        {
            var query = _context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(parentCode))
            {
                query = query.Where(c => c.ParentCode == parentCode);
            }
            else
            {
                // Ako nema parentCode, dobij root kategorije (one bez roditelja)
                query = query.Where(c => c.ParentCode == null || c.ParentCode == "");
            }

            var categories = await query
                .Select(c => new CategoryDto
                {
                    Code = c.Code,
                    Name = c.Name,
                    ParentCode = c.ParentCode
                }).ToListAsync();

            return categories;
        }
    }

}

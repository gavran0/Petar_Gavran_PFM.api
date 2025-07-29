using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface IAutoCategorizationService
    {
        Task<int> AutoCategorizeAsync();
    }
}

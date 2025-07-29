using PFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface IRuleLoaderService
    {
        List<CategorizationRule> LoadRules();
    }
}

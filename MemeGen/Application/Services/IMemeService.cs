using System.Collections.Generic;
using System.Threading.Tasks;
using MemeGen.Application.Models;


namespace MemeGen.Application.Services
{
    public interface IMemeService
    {

        Task<List<MemeCatalogDto>> GetMemeCatalog();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using MemeGen.Domain.Entities;

namespace MemeGen.Application.Repositories
{
    public interface IMemeRepository
    {
        Task<List<MemeTemplate>> GetMemeTemplates();
    }
}

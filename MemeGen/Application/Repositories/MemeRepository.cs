using System.Collections.Generic;
using System.Threading.Tasks;
using MemeGen.Domain.Entities;
using MemeGen.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MemeGen.Application.Repositories
{
    public class MemeRepository: IMemeRepository
    {
        private readonly MemeDbContext _context;

        public MemeRepository(MemeDbContext context)
        {
            _context = context;
        }

        public async Task<List<MemeTemplate>> GetMemeTemplates()
        {
            return await _context.MemeTemplates.ToListAsync();
        }
    }
}

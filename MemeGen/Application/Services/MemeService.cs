using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeGen.Application.Models;
using MemeGen.Application.Repositories;
using MemeGen.Domain.Entities;

namespace MemeGen.Application.Services
{
    public class MemeService: IMemeService
    {
        private readonly IMemeRepository _repository;

        public MemeService(IMemeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MemeCatalogDto>> GetMemeCatalog()
        {
            var templates = await _repository.GetMemeTemplates();

            var templatesDto = templates.Select(m =>
                new MemeCatalogDto()
                {
                    Id = m.Id,
                    Name = m.Name
                }).ToList();

            return templatesDto;
        }
    }
}

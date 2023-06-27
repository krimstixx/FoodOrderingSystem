using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using FoodOrderingSystem.Divisions.Dto;
using FoodOrderingSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Divisions
{
    public class DivisionAppservice : AsyncCrudAppService<Division, DivisionDto, int, PagedDivisionResultRequestDto, CreateDivisionDto, DivisionDto>, IDivisionAppService
    {
        private readonly IRepository<Division, int> _repository;
        public DivisionAppservice(IRepository<Division, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<DivisionDto> CreateAsync(CreateDivisionDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<DivisionDto>> GetAllAsync(PagedDivisionResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<DivisionDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<DivisionDto> UpdateAsync(DivisionDto input)
        {
            return base.UpdateAsync(input);
        }
        //added method
        public async Task<List<DivisionDto>> GetAllDivisionAsync()
        {
            var returnQuery = await _repository.GetAll().Select(x => ObjectMapper.Map<DivisionDto>(x)).ToListAsync();
            return returnQuery;
        }
    }
}

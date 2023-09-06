using AutoMapper;
using Core.BusinessModels;
using Core.BusinessModels.Command;
using Core.DBModels;
using Core.RepositoryInterfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepository
{
    public class HumanRepository : IHumanRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public HumanRepository(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region Get methods

        public async Task<IEnumerable<HumanDTO>> GetAllAsync()
        {
            IEnumerable<Human> humanList = await _context.Human.ToListAsync();
            return _mapper.Map<List<HumanDTO>>(humanList);
        }   

        public async Task<HumanDTO> GetHumanByIdAsync(int id)
        {
            Human human = await _context.Human.FindAsync(id);

            if (human != null)
            {
                return _mapper.Map<HumanDTO>(human);
            }

            throw new Exception("Human Entity not found");
        }

        public IEnumerable<HumanDTO> GetMockHumanList()
        {
            List<Human> HumanList = new List<Human> 
            {
                new Human
                {
                    Id = 1,
                    Name = "Mauricio",
                    Genre = GenreEnumerator.Male,
                    Height = 182,
                    Weight = 82
                },
                new Human
                {
                    Id = 240899,
                    Name = "Axel",
                    Genre = GenreEnumerator.Male,
                    Height = 174,
                    Weight = 78.5
                },
                new Human
                {
                    Id = 291199,
                    Name = "Maricela",
                    Genre = GenreEnumerator.Female,
                    Height = 168,
                    Weight = 64
                },
            };
            return _mapper.Map<List<HumanDTO>>(HumanList);
        }

        #endregion

        #region Create methods

        public async Task<HumanDTO> CreateHumanAsync(HumanCommand newHuman)
        {
            var human = _mapper.Map<Human>(newHuman);
            await _context.Human.AddAsync(human);
            await _context.SaveChangesAsync();
            return _mapper.Map<HumanDTO>(human);
        }

        #endregion

        #region Update methods

        public async Task<HumanDTO> UpdateHumanAsync(HumanCommand updatedHuman, int humanId)
        {
            var human = _context.Human.Find(humanId);

            if(human != null)
            {
                human.Name = updatedHuman.Name;
                human.Genre = updatedHuman.Genre;
                human.Age = updatedHuman.Age;
                human.Height = updatedHuman.Height;
                human.Weight = updatedHuman.Weight;
                _context.Update(human);
                await _context.SaveChangesAsync();

                return _mapper.Map<HumanDTO>(human);
            }

            throw new Exception("Human entity not found");
        }

        #endregion
    }
}

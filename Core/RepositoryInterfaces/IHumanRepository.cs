using Core.BusinessModels;
using Core.BusinessModels.Command;

namespace Core.RepositoryInterfaces
{
    public interface IHumanRepository
    {
        IEnumerable<HumanDTO> GetMockHumanList();
        Task<IEnumerable<HumanDTO>> GetAllAsync();
        Task<HumanDTO> GetHumanByIdAsync(int id);
        Task<HumanDTO> CreateHumanAsync(HumanCommand newHuman);
        Task<HumanDTO> UpdateHumanAsync(HumanCommand updatedHuman, int humanId);
    }
}

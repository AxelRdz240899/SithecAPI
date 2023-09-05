using Core.BusinessModels;
using Core.BusinessModels.Command;

namespace Core.RepositoryInterfaces
{
    public interface IHumanRepository
    {
        IEnumerable<HumanDTO> GetMockHumanList();
        IEnumerable<HumanDTO> GetAll();
        HumanDTO GetHumanById(int id);
        public HumanDTO CreateHuman(HumanCommand newHuman);
        public HumanDTO UpdateHuman(HumanCommand updatedHuman, int humanId);
    }
}

using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using AdminPanle.BusinessLayer.Abstract.Base;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Abstract.Other.Ybs_Filo
{
    public interface IBusGetTemp:IEntityBusBase<TEMP_SOSYALYARDIM3>
    {
        Task<ObjectResponse<List<TEMP_SOSYALYARDIM3>>> GetByTCAsync(string TC);
    }
}

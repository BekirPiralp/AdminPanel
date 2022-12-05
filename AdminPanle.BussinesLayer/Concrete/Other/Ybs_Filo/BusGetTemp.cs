﻿using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.YBS_Asis;
using AdminPanel.EntityLayer.Abctract;
using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using AdminPanle.BusinessLayer.Abstract.Other.Ybs_Filo;
using AdminPanle.BusinessLayer.Concrete.Base;
using AdminPanle.BusinessLayer.Other.Extensions;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Concrete.Other.Ybs_Filo
{
    public class BusGetTemp : EntityBusBase<TEMP_SOSYALYARDIM3, IGetTempDAL>, IBusGetTemp
    {
        public BusGetTemp(IGetTempDAL entityDalBase) : base(entityDalBase)
        {
            
        }

        public async Task<ObjectResponse<List<TEMP_SOSYALYARDIM3>>> GetByTCAsync(string TC)
        {
            ObjectResponse<List<TEMP_SOSYALYARDIM3>> response;
            if (TC.isNotEmpty() && TC.Length == 11) {
                List<TEMP_SOSYALYARDIM3> result = null;

                try
                {
                     result = (await this._entityDalBase.GetAsync(p => p.tcNo == TC));
                    if (result.isNotNull())
                    {
                        response = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>(result);
                    }
                    else
                    {
                        response = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>("İlgli TC de kayıt bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    response = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>("ilgili nesneler getirilirken hata oluştu. :\n\t" + ex.Message);
                }
            }
            else
            {
                response = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>("Geçersiz Parametre: geçersiz TC");
            }

                return response;
        }

        public async Task<ObjectResponse<List<TEMP_SOSYALYARDIM3>>> GetPageOrderByDogumYili(int pageItemsCount, int pageIndex)
        {
            ObjectResponse<List<TEMP_SOSYALYARDIM3>> result;

            try
            {
                var entities = await this._entityDalBase.GetPaginationAsync(pageItemsCount, pageIndex,p=>p.dogumYili,null,false);
                if (entities.isNotNull() && entities.isNotEmpty())
                {
                    result = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>(entities);
                }
                else
                    result = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>("İlgili nesneler getirilemedi");
            }
            catch (Exception ex)
            {
                result = new ObjectResponse<List<TEMP_SOSYALYARDIM3>>("Nesneler getirilirken hata ile karşılaşıldı. :\n\t" + ex.Message);
            }

            return result;
        }
    }
}

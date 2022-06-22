using AdminPanel.EntityLayer.Abctract;
using AdminPanel.WebAPI.Definitions;
using AdminPanel.WebAPI.Extension;
using AdminPanle.BusinessLayer.Abstract.Base;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebAPI.Controllers.Base
{
    [ApiController]

    //[Route("[controller]")]
    public class BaseController<ITEntityBusBase, TEntity> : ControllerBase
        where ITEntityBusBase : class, IEntityBusBase<TEntity>
        where TEntity : class, IEntity, new()

    {
        private ITEntityBusBase _entityBusBase;
        public BaseController(ITEntityBusBase entityBusBase) : base()
        {
            _entityBusBase = entityBusBase;
        }

        #region get
        [HttpGet()]
        [Route("[controller]/Get/{Id}")]
        public async Task<ActionResult<TEntity>> GetById(int Id)
        {
            ActionResult<TEntity> result = null;
            if (Id.isNotInvalid())
            {
                try
                {
                    result = Ok(await _entityBusBase.GetByIdAsync(Id));
                }
                catch (Exception e)
                {
                    result = NotFound(new Exception(message: "Id ile nesne getirmede hata oluştu. "));
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz Id");
            }
            return result;
        }



        [HttpGet()]
        [Route("[controller]/GetAll/")]
        public async Task<ActionResult<List<TEntity>>> GetAll()
        {

            ActionResult<List<TEntity>> result;

            try
            {
                var entities = await _entityBusBase.GetAllAsync();
                result = Ok(entities);
            }
            catch (Exception e)
            {
                result = NotFound(new Exception(message: "nesneler getirlirken hata oluştu. "));
            }

            return result;
        }
        #endregion

        #region delete
        [HttpDelete()]
        [Route("[controller]/[Action]/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            ActionResult result;
            try
            {
                result = Ok(await _entityBusBase.DeleteAsync(id));

            }
            catch (Exception)
            {
                result = this.StatusCode((int)ResultCode.SunucuHatasi, "Sunucuda hata gerçekleşti");
            }
            return result;

        }

        [HttpDelete()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult> DeleteByObject([FromBody] TEntity entity)
        {
            ActionResult result;
            if (entity.isIdNotEmpty())
            {
                try
                {
                    result = this.Ok(await _entityBusBase.DeleteAsync(entity));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Sunucuda hata gerçekleşti");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }

            return result;

        }

        [HttpDelete()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult> DeleteByList([FromBody] List<TEntity> entities)
        {
            ActionResult result;
            if (entities.isNotEmpty())
            {
                try
                {
                    result = this.Ok(await _entityBusBase.DeleteAsync(entities));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Sunucuda hata gerçekleşti");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }

            return result;

        }
        #endregion

        #region put
        [HttpPut()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> Put(TEntity entity)
        {
            ActionResult result;
            if (entity.isIdNotEmpty())
            {
                try
                {
                    result = Ok(await _entityBusBase.UpdateAsync(entity));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Sunucuda hata gerçekleşti");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }
            return result;
        }

        [HttpPut()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<TEntity>> PutBy(TEntity entity)
        {
            ActionResult result;
            if (entity.isIdNotEmpty())
            {
                try
                {
                    result = Ok(await _entityBusBase.UpdateByAsync(entity));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Sunucuda hata gerçekleşti");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }
            return result;
        }
        #endregion

        #region post
        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> Post(TEntity entity)
        {
            ActionResult result;
            if (entity.isNotNull())
            {
                try
                {
                    result = Ok(await _entityBusBase.AddAsync(entity));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Beklenmeyen bir hata oluştu");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }
            return result;
        }

        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<TEntity>> PostByObject(TEntity entity)
        {
            ActionResult result;
            if (entity.isNotNull())
            {
                try
                {
                    result = Ok(await _entityBusBase.AddByAsync(entity));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Beklenmeyen bir hata oluştu");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }
            return result;
        }

        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> PostByList(List<TEntity> entities)
        {
            ActionResult result;

            if (entities.isNotEmpty())
            {
                try
                {
                    result = Ok(_entityBusBase.AddAsync(entities));
                }
                catch (Exception)
                {
                    result = this.StatusCode((int)ResultCode.SunucuHatasi, "Beklenmeyen bir hata oluştu");
                }
            }
            else
            {
                result = this.BadRequest("Geçersiz veri");
            }

            return result;
        }
        #endregion
    }

}

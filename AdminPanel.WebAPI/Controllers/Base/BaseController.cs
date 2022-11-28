﻿using AdminPanel.EntityLayer.Abctract;
using AdminPanle.BusinessLayer.Abstract.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebAPI.Controllers.Base
{
    [ApiController]
    //[Authorize]
    //[Route("[controller]")]
    public class BaseController<ITEntityBusBase, TEntity> : ControllerBase
        where ITEntityBusBase : class, IEntityBusBase<TEntity>
        where TEntity : class, IEntity, new()

    {
        private protected ITEntityBusBase _entityBusBase;
        public BaseController(ITEntityBusBase entityBusBase) : base()
        {
            _entityBusBase = entityBusBase;
        }

        #region get
        [HttpGet()]
        [Route("[controller]/Get/{Id}")]
        public async Task<ActionResult<TEntity>> GetById(int Id)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.GetByIdAsync(Id));

            return result;
        }



        [HttpGet()]
        [Route("[controller]/GetAll/")]
        public async Task<ActionResult<List<TEntity>>> GetAll()
        {

            ActionResult result;

            result = dondur(await _entityBusBase.GetAllAsync());

            return result;
        }

        [HttpGet()]
        [Route("[controller]/GetPage/")]
        public async Task<ActionResult<List<TEntity>>> GetPage(int pageItemsCount, int pageIndex)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.GetPage(pageItemsCount,pageIndex));
            
            return result;
        }
        #endregion

        #region delete
        [HttpPost()]
        [Route("[controller]/[Action]/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.DeleteAsync(id));

            return result;

        }

        [HttpDelete()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult> DeleteByObject([FromBody] TEntity entity)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.DeleteAsync(entity));

            return result;

        }

        [HttpDelete()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult> DeleteByList([FromBody] List<TEntity> entities)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.DeleteAsync(entities));

            return result;

        }
        #endregion

        #region put
        [HttpPut()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> Put(TEntity entity)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.UpdateAsync(entity));

            return result;
        }

        [HttpPut()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<TEntity>> PutBy(TEntity entity)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.UpdateByAsync(entity));

            return result;
        }
        #endregion

        #region post
        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> Post(TEntity entity)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.AddAsync(entity));

            return result;
        }

        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<TEntity>> PostByObject(TEntity entity)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.AddByAsync(entity));

            return result;
        }

        [HttpPost()]
        [Route("[controller]/[Action]/")]
        public async Task<ActionResult<bool>> PostByList(List<TEntity> entities)
        {
            ActionResult result;

            result = dondur(await _entityBusBase.AddAsync(entities));

            return result;
        }
        #endregion

        private protected ActionResult dondur(dynamic resource)
        {
            ActionResult result;
            if (resource.Success)
            {
                result = Ok(resource.Data);
            }
            else
                result = BadRequest(resource.Message);

            return result;
        }
    }

}

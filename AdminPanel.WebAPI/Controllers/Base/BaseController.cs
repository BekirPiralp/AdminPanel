using AdminPanel.EntityLayer.Abctract;
using AdminPanle.BusinessLayer.Abstract.Base;
using AdminPanle.BusinessLayer.Other;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

namespace AdminPanel.WebAPI.Controllers.Base
{
    [ApiController]
    //[Route("[controller]")]
    public class BaseController<ITEntityBusBase,TEntity>: ControllerBase
        where TEntity: class,IEntity,new()
        where ITEntityBusBase: class,IEntityBusBase<TEntity>
    {
        private ITEntityBusBase _entityBusBase;
        public BaseController(ITEntityBusBase entityBusBase):base()
        {
            _entityBusBase = entityBusBase;
        }

        [HttpGet()]
        [Route("[controller]/getAll")]
       // [Route("/getAll")]
        public async Task<ActionResult<List<TEntity>>> getAll()
        {
            //_entityBusBase.AddAsync(entity);
            
            return Ok(await _entityBusBase.GetAllAsync());
        }

        [HttpGet()]
        [Route("[controller]/get/{id}")]
        public async Task<ActionResult<TEntity>> get(int id)
        {

            return Ok(await _entityBusBase.GetByIdAsync(id));
        }
    }
}

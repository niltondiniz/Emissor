using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using ApiEmissor.DataLayer;
using ApiEmissor.Repository;

namespace ApiEmissor.Controllers
{
    [Route("api/[controller]")]
    public class RegimeTributarioController : Controller
    {

        IUnitOfWork<RegimeTributario> UnitOfWork { get; set; }

        public RegimeTributarioController()
        {
            this.UnitOfWork = new RegimeTributarioRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<RegimeTributario>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public RegimeTributario Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]RegimeTributario regimeTributario)
        {
            this.UnitOfWork.Save(regimeTributario);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]RegimeTributario regimeTributario)
        {
            await this.UnitOfWork.UpdateAsync(regimeTributario, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]RegimeTributario regimeTributario)
        {
            await this.UnitOfWork.DeleteAsync(regimeTributario);
        }
    }
}

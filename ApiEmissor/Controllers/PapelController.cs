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
    public class PapelController : Controller
    {

        IUnitOfWork<Papel> UnitOfWork { get; set; }

        public PapelController()
        {
            this.UnitOfWork = new PapelRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<Papel>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public Papel Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]Papel papel)
        {
            this.UnitOfWork.Save(papel);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Papel papel)
        {
            await this.UnitOfWork.UpdateAsync(papel, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]Papel papel)
        {
            await this.UnitOfWork.DeleteAsync(papel);
        }
    }
}

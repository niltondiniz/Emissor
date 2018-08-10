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
    public class AcessoController : Controller
    {

        IUnitOfWork<Acesso> UnitOfWork { get; set; }

        public AcessoController()
        {
            this.UnitOfWork = new AcessoRepository();
        }


        // GET api/acesso
        [HttpGet]
        public async Task<IEnumerable<Acesso>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public Acesso Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]Acesso acesso)
        {
            this.UnitOfWork.Save(acesso);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Acesso acesso)
        {
            await this.UnitOfWork.UpdateAsync(acesso, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]Acesso acesso)
        {
            await this.UnitOfWork.DeleteAsync(acesso);
        }
    }
}

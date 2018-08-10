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
    public class PapeisPessoaController : Controller
    {

        IUnitOfWork<PapeisPessoa> UnitOfWork { get; set; }

        public PapeisPessoaController()
        {
            this.UnitOfWork = new PapeisPessoaRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<PapeisPessoa>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public PapeisPessoa Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]PapeisPessoa papeisPessoa)
        {
            this.UnitOfWork.Save(papeisPessoa);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]PapeisPessoa papeisPessoa)
        {
            await this.UnitOfWork.DeleteAsync(papeisPessoa);
        }
    }
}

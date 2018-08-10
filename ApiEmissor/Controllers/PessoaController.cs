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
    public class PessoasController : Controller
    {

        IUnitOfWork<Pessoa> UnitOfWorkPessoa { get; set; }

        public PessoasController()
        {
            this.UnitOfWorkPessoa = new PessoaRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<Pessoa>> Get()
        {
            return await UnitOfWorkPessoa.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            return this.UnitOfWorkPessoa.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]Pessoa pessoa)
        {
            this.UnitOfWorkPessoa.Save(pessoa);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Pessoa pessoa)
        {
            await this.UnitOfWorkPessoa.UpdateAsync(pessoa, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]Pessoa pessoa)
        {
            await this.UnitOfWorkPessoa.DeleteAsync(pessoa);
        }
    }
}

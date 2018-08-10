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
    public class PessoasFiscalController : Controller
    {

        IUnitOfWork<PessoaFiscal> UnitOfWork { get; set; }

        public PessoasFiscalController()
        {
            this.UnitOfWork = new PessoaFiscalRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<PessoaFiscal>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public PessoaFiscal Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]PessoaFiscal pessoaFiscal)
        {
            this.UnitOfWork.Save(pessoaFiscal);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]PessoaFiscal pessoaFiscal)
        {
            await this.UnitOfWork.UpdateAsync(pessoaFiscal, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]PessoaFiscal pessoaFiscal)
        {
            await this.UnitOfWork.DeleteAsync(pessoaFiscal);
        }
    }
}

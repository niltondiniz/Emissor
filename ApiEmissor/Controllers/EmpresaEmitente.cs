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
    public class EmpresaEmitenteController : Controller
    {

        IUnitOfWork<EmpresaEmitente> UnitOfWorkPessoa { get; set; }

        public EmpresaEmitenteController()
        {
            this.UnitOfWorkPessoa = new EmpresaEmitenteRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<EmpresaEmitente>> Get()
        {
            return await UnitOfWorkPessoa.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public EmpresaEmitente Get(int id)
        {
            return this.UnitOfWorkPessoa.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]EmpresaEmitente empresaEmitente)
        {
            this.UnitOfWorkPessoa.Save(empresaEmitente);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]EmpresaEmitente empresaEmitente)
        {
            await this.UnitOfWorkPessoa.UpdateAsync(empresaEmitente, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]EmpresaEmitente empresaEmitente)
        {
            await this.UnitOfWorkPessoa.DeleteAsync(empresaEmitente);
        }
    }
}

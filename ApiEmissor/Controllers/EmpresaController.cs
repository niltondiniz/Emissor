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
    public class EmpresaController : Controller
    {

        IUnitOfWork<Empresa> UnitOfWork { get; set; }

        public EmpresaController()
        {
            this.UnitOfWork = new EmpresaRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<Empresa>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public Empresa Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]Empresa empresa)
        {
            this.UnitOfWork.Save(empresa);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Empresa empresa)
        {
            await this.UnitOfWork.UpdateAsync(empresa, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]Empresa empresa)
        {
            await this.UnitOfWork.DeleteAsync(empresa);
        }
    }
}

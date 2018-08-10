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
    public class EmpresaConfigNFController : Controller
    {

        IUnitOfWork<EmpresaConfigNF> UnitOfWork { get; set; }

        public EmpresaConfigNFController()
        {
            this.UnitOfWork = new EmpresaConfigNFRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<EmpresaConfigNF>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public EmpresaConfigNF Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]EmpresaConfigNF empresaConfigNF)
        {
            this.UnitOfWork.Save(empresaConfigNF);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]EmpresaConfigNF empresaConfigNF)
        {
            await this.UnitOfWork.UpdateAsync(empresaConfigNF, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]EmpresaConfigNF empresaConfigNF)
        {
            await this.UnitOfWork.DeleteAsync(empresaConfigNF);
        }
    }
}

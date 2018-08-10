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
    public class EnderecoController : Controller
    {

        IUnitOfWork<Endereco> UnitOfWork { get; set; }

        public EnderecoController()
        {
            this.UnitOfWork = new EnderecoRepository();
        }


        // GET api/pessoas
        [HttpGet]
        public async Task<IEnumerable<Endereco>> Get()
        {
            return await UnitOfWork.GetAllAsync();
        }

        // GET api/pessoas/5
        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return this.UnitOfWork.GetById(id);
        }

        // POST api/pessoas
        [HttpPost]
        public void Post([FromBody]Endereco endereco)
        {
            this.UnitOfWork.Save(endereco);
        }

        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Endereco endereco)
        {
            await this.UnitOfWork.UpdateAsync(endereco, id);
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public async void Delete(int id, [FromBody]Endereco endereco)
        {
            await this.UnitOfWork.DeleteAsync(endereco);
        }
    }
}

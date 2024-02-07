using APIModelo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIModelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]

        public Pessoa GetPessoa()
        {
            Pessoa vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "Zé Robson";
            vPessoa.NumeroCelular = "(18) 91234-1234";

            return vPessoa;
        }

        [HttpGet("GetPessoas")]

        public List<Pessoa> GetPessoas()
        {
            var vPessoas = new Pessoa();

            return vPessoas.Dados();
        }
    }
}

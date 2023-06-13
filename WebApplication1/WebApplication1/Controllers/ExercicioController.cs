using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercicioController : ControllerBase
    {
        [HttpGet("nome")]
        public string nomeEndPoint()
        {
            return "Jo";
        }
        [HttpGet("idade")]
        public int idadeEndPoint()
        {           
            return 26;
        }
        [HttpPost("nome-idade/{nome}/{idade}")]
        public string GetNomeIdade([FromRoute] string nome, [FromRoute] int idade)
        {
            return $"Nome: {nome}, Idade: {idade}";
        }
        [HttpPost("nome-idade-frase/{nome}/{idade}")]
        public string GetNomeIdadeFrase([FromRoute] string nome, [FromRoute] int idade)
        {
            return $"Nome: {nome}, Idade: {idade}, - {nome} é maior de idade";
        }
        
    }
    
}

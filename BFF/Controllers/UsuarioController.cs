using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly ILogger<UsuarioController> _logger;

        string jsonString = "{\r\n \"id\": 1,\r\n  \"NomeCompleto\": \"João Silva\",\r\n\t\"email\": \"joao.silva@email.com\",\r\n \r\n  \"Sorteio\":[\r\n  \r\n  {\"SorteioId\": 1 ,\"NomeSorteio\":\"N° 1\",\r\n  \r\n\t\"NumerosSorte\": [\r\n\t {\r\n\t \"NumeroSorteId\": \"12345\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t },\r\n\t {\r\n\t \"NumeroSorteId\": \"54321\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"78945\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"54789\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }\r\n\t\t]\r\n  \r\n  },\r\n\r\n  {\r\n\t\"SorteioId\": 2 ,\r\n\t\"NomeSorteio\":\"N° 2\",\r\n  \t\"NumerosSorte\": [\r\n\t {\r\n\t \"NumeroSorteId\": \"12345\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t },\r\n\t \r\n\t {\r\n\t \"NumeroSorteId\": \"54321\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"78945\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"54789\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"74126\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }\r\n\t\t]\r\n  \r\n  },\r\n\r\n  {\r\n  \"SorteioId\": 3 ,\r\n  \"NomeSorteio\":\"N° 3\",\r\n\t\"NumerosSorte\": [\r\n\t {\r\n\t \"NumeroSorteId\": \"12345\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t },\r\n\t {\r\n\t \"NumeroSorteId\": \"54321\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"78945\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"54789\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }, \r\n\t {\r\n\t \"NumeroSorteId\": \"74126\",\r\n\t \"Usado\": false,\r\n\t \"Status\": true,\r\n\t \"DataRecebido\": \"18/06/2024\"\r\n\t }\r\n\t\t]\r\n  }\r\n\r\n  \r\n  ],\r\n\r\n  \"VibesAcumulados\": [\r\n {\r\n \"vibe_id\": 1,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 2,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 3,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 4,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 5,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 6,\r\n \"Usado\": true\r\n },\r\n  {\r\n \"vibe_id\": 7,\r\n \"Usado\": true\r\n }\r\n ]\r\n \r\n\r\n}";
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "BuscaNumero")]
        public IEnumerable<Usuario> BuscaNumero()
        {
            Usuario Usuarios = JsonSerializer.Deserialize<Usuario>(jsonString);
            yield return Usuarios;
        }

    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PocRefit.Dto;
using PocRefit.Interface.Repository;

namespace PocRefit.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public async Task<ViaCepDto> GetAsync([FromServices] IViaCepRepository repository,[FromRoute] string cep)
        {
            try
            {
                var response = await repository.RetornaEndereco(cep);
                return response;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}

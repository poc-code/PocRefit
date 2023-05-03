using Microsoft.AspNetCore.Mvc;
using PocRefit.Dto;
using Refit;

namespace PocRefit.Interface.Repository
{
    public interface IViaCepRepository
    {
        [Get("/{cep}/json")]
        Task<ViaCepDto> RetornaEndereco([FromRoute] string cep);
    }
}

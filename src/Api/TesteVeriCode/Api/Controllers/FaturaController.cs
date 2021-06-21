using System.Collections.Generic;
using System.Threading.Tasks;
using Api.ViewModels;
using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class FaturaController : ControllerBase
    {
        private readonly IFaturaService service;
        private readonly IMapper mapper;
        public FaturaController(IFaturaService faturaService, IMapper _mapper)
        {
            service = faturaService;
            mapper = _mapper;
        }

        [HttpGet("processar-fatura")]
        public async Task<ActionResult<List<FaturaViewModel>>> Processar()
        {
            var listaProcessada =  mapper.Map<List<FaturaViewModel>>(await service.Processar());
            return Ok(listaProcessada);
        }
    }
}

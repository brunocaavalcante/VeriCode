using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using WebSite.ViewModels;

namespace WebSite.Controllers
{
    public class FaturaController : Controller
    {
        private readonly IFaturaService service;
        private readonly IMapper mapper;

        public FaturaController(IFaturaService _service, IMapper _mapper)
        {
            service = _service;
            mapper = _mapper;
        }

        public IActionResult Index(List<FaturaViewModel> lista)
        {
            return View(lista);
        }

        public async Task<IActionResult> ProcessarFaturas()
        {
            var lista = mapper.Map<List<FaturaViewModel>>(await service.ProcessaFaturas());
            return View("Index", lista);
        }
    }
}

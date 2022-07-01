using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;
using Api.Infrastructure.Repository;
using System.Data;
using System.Collections.Generic;
using Microsoft.IdentityModel.Protocols;
using Api.Services.Interfaces;
using Api.Domain.Interfaces;
using Api.Services;
using System.Globalization;
using System.Net;
using System.Net.Http;
using Api.Application.ViewModels;
using Api.Application.ViewModels.Produto;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {

            _produtoService = produtoService;
        }

        // GET: api/Aluno/5
        [HttpGet]
        public async Task<ActionResult<ProdutoViewModel>> GetProduto()
        {
            var produto =  await _produtoService.BuscarProduto();

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);

        }
    }
}

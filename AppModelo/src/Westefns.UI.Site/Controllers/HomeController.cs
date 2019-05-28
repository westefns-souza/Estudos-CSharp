﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Westefns.UI.Site.Data;
using Westefns.UI.Site.Models;

namespace Westefns.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IPedidoRepository _pedidoRepository;
        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}

        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}

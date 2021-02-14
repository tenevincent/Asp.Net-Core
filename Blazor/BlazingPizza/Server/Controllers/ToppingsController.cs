﻿using BlazingPizza.Server.Data;
using BlazingPizza.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server
{
    [Route("toppings")]
    [ApiController]
    public class ToppingsController : Controller
    {
        private readonly PizzaStoreContext _db;

        public ToppingsController(PizzaStoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Topping>>> GetToppings()
        {
            return await _db.Toppings.OrderBy(t => t.Name).ToListAsync();
        }
    }
}

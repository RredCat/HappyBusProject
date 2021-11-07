﻿using AutoMapper;
using HappyBusProject.HappyBusProject.BusinessLayer.Repositories;
using HappyBusProject.HappyBusProject.DataLayer.InputModels;
using HappyBusProject.HappyBusProject.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBusProject.Controllers
{
    [Route("AppAPI/Orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository<IActionResult> _repository;
        public OrdersController(IOrderRepository<IActionResult> repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _repository.GetAllOrders());
        }

        
        [HttpGet("{FullName}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get(string FullName)
        {
            return new ObjectResult(await _repository.GetLastOrder(FullName));
        }


        [HttpPost]
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> Post([FromBody]OrderInputModel orderInput)
        {
            return new ObjectResult(await _repository.CreateOrder(orderInput));
        }

        
        [HttpPut]
        [Authorize(Roles = "User, Admin")]
        public void Put(int id, string value)
        {

        }

        
        [HttpDelete]
        [Authorize(Roles = "User, Admin")]
        public void Delete(int id)
        {

        }
    }
}

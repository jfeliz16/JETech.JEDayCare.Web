﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.JEDayCare.Core.Clients.Interfaces;
using JETech.JEDayCare.Core.Clients.Models;
using JETech.JEDayCare.Core.Data.Entities;
using JETech.JEDayCare.Web.Helper;
using JETech.JEDayCare.Web.Models.Client;
using JETech.NetCoreWeb.Exceptions;
using JETech.NetCoreWeb.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JETech.JEDayCare.Web.Controllers.Api.Client.ClientMant
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IClientConverterHelper _clientConverter;
        private readonly JEDayCareDbContext _dbContext;

        public ClientController(IClientService clientService,
                                       IClientConverterHelper clientConverter,
                                       JEDayCareDbContext dbContext)
        {
            _clientService = clientService;
            _clientConverter = clientConverter;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ActionQueryArgs<ClientModel> args)
        {
            try
            {
                if (!string.IsNullOrEmpty(args.CondictionString))
                {
                    args.Condiction = JETech.DevExtremeCore.Converter.FilterToExpresion<ClientModel>(args.CondictionString);
                }
                var resultCli = _clientService.GetClients(args);

                var result = new ActionPaginationResult<List<ClientModel>>
                {
                    Data = await resultCli.Data.AsNoTracking().ToListAsync(),
                    GroupCount = resultCli.GroupCount,
                    TotalCount = resultCli.TotalCount,
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAjax(ActionQueryArgs<ClientModel> args)
        {          
            try
            {
                if (!string.IsNullOrEmpty(args.CondictionString))
                {
                    args.Condiction = JETech.DevExtremeCore.Converter.FilterToExpresion<ClientModel>(args.CondictionString);
                }
                var resultCli = _clientService.GetClients(args);

                var result = new ActionPaginationResult<List<ClientModel>>
                {
                    Data = await resultCli.Data.AsNoTracking().ToListAsync(),
                    GroupCount = resultCli.GroupCount,
                    TotalCount = resultCli.TotalCount,
                };           
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientViewModel model)
        {
            try
            {
                var clientModel = _clientConverter.ToClientModel(model);
                var resultClient = await _clientService.Create(new ActionArgs<ClientModel> { Data = clientModel });

                var result = new JETech.NetCoreWeb.Types.ActionResult<int>
                {
                    Data = resultClient.Data                    
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Edit(ClientViewModel model)
        {
            try
            {
                var clientModel = _clientConverter.ToClientModel(model);
                var resultClient = await _clientService.Update(new ActionArgs<ClientModel> { Data = clientModel });

                var result = new JETech.NetCoreWeb.Types.ActionResult<bool>
                {
                    Data = resultClient.Data
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAttendacesWeek()
        {
            try
            {
                var result = await _clientService.GetAttandecesWeek(new ActionArgs<DateTime> { Data = DateTime.Now });
                
                return Ok(result.Data);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }
        }
    }
}

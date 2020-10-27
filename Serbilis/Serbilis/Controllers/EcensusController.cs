using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serbilis.Application.Interfaces;
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using System;
using System.Collections.Generic;

namespace Serbilis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcensusController : ControllerBase
    {
        private readonly ILogger<EcensusController> _logger;
        private readonly ISerbilisManager _serbilisManager;

        public EcensusController(ILogger<EcensusController> logger, ISerbilisManager serbilisManager)
        {
            _logger = logger;
            _serbilisManager = serbilisManager;
        }

        [HttpGet]
        public IActionResult  Get()
        {
            try
            {
                IEnumerable<RequestPurposeModel> response = _serbilisManager.GetRequestPurposeModel();
                if (response == null)
                {
                    return Problem("Problem with execution", null, 500);
                }
                return Ok(response);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Problem(ex.Message, null, 500);
            }
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Ecensus
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

     
        [HttpPost]
        [Route("Requester")]
        public IActionResult InsertRequesterDetail(RequesterDetailModel requesterModel)
        {
            try
            {
                string response = _serbilisManager.InsertRequesterDetail(requesterModel);
                if (string.IsNullOrEmpty(response))
                {
                    return Problem("Problem with execution", null, 500);
                }
                return Ok(response);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Problem(ex.Message, null, 500);
            }
        }

        [HttpPost]
        [Route("Request")]
        public IActionResult InsertRequestDetail(RequestDetailModel requestModel)
        {
            try
            {
                requestModel.PrimaryFirstName = GetUnknownAscii(requestModel.PrimaryFirstName);
                requestModel.PrimaryLastName = GetUnknownAscii(requestModel.PrimaryLastName);
                requestModel.SecondaryFirstName = GetUnknownAscii(requestModel.SecondaryFirstName);
                requestModel.SecondaryLastName = GetUnknownAscii(requestModel.SecondaryLastName);
                requestModel.AuxFirstName = GetUnknownAscii(requestModel.AuxFirstName);
                requestModel.AuxLastName = GetUnknownAscii(requestModel.AuxLastName);
                string response = _serbilisManager.InsertRequestDetail(requestModel);
                if (string.IsNullOrEmpty(response))
                {
                    return Problem("Problem with execution", null, 500);
                }
                return Ok(response);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Problem(ex.Message, null, 500);
            }
        }

        private string GetUnknownAscii(string inputText)
        {
            return inputText == GlobalConstants.Defaultvariableunknown ? GlobalConstants.DefaultvariableunknownValue : inputText;

        }
    }
}

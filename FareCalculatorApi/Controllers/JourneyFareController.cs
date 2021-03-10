using DataContracts;
using FareCalculatorApi.Models;
using FareCalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FareCalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyFareController : ControllerBase
    {
        private readonly IFareCalculator fareCalculatorService;

        public JourneyFareController(IFareCalculator service)
        {
            fareCalculatorService = service;
        }

        // GET api/<JourneyFareController>
        [HttpGet]
        public string Get()
        {
            return "Welcome to Journey Fare Calculator Engine api!";
        }

        // POST api/<JourneyFareController>
        [HttpPost]
        [Route("[action]")]
        public int GetTotalFare([FromBody] List<JourneyContract> journeys)
        {
            List<Journey> list = new List<Journey>();

            foreach (var journey in journeys)
            {
                list.Add(TransformJourneyContract(journey));
            }

            return fareCalculatorService.GetTotalFare(list);
        }

        private Journey TransformJourneyContract(JourneyContract journey)
        {
            return new Journey
            {
                FromZone = journey.FromZone,
                ToZone = journey.ToZone,
                StartDateTime = DateTime.Parse(journey.StartDateTime)
            };
        }
    }
}

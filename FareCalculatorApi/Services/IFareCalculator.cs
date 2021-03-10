using FareCalculatorApi.Models;
using System.Collections.Generic;

namespace FareCalculatorApi.Services
{
    public interface IFareCalculator
    {
        int GetTotalFare(List<Journey> journeys);
    }
}

using FareCalculatorApi.Models;
using System.Collections.Generic;

namespace FareCalculatorApi.Services.Calculators
{

    public interface ICalculate
    {
        int GetTotalFare(List<Journey> journeys);
    }
}

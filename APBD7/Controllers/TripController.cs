
using APBD7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APBD7.Controllers
{
    [Route("api")]
    [ApiController]
    public class TripController : ControllerBase
    {
        [HttpGet("trips")]
        public IActionResult GetTrips() {
            S19414Context context = new S19414Context();
            var clients = context.Trips
                .OrderByDescending(trip => trip.DateFrom);
            return Ok(clients);
        }

        [HttpDelete("clients/{idClient}")]
        public IActionResult DeleteTrips(int idClient) {
            S19414Context context = new S19414Context();
            var clients = context.Clients
                .Include(c => c.ClientTrips).ToList();
            return Ok(clients);
        }

        [HttpPost("trips/{idTrip}/clients")]
        public IActionResult AssignCustomerToTrip()
        {
            return null;
        }
    }
}

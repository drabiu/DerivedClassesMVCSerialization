using System;
using System.Text.Json;
using System.Threading;
using DiscoveryTypesCollection.Extensions;
using Microsoft.AspNetCore.Mvc;
using Navtor.Advisory.Models.Models;
using Navtor.Advisory.Models.Models.RouteOptimization;

namespace DiscoveryTypesCollection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvisoryController : ControllerBase
    {
        public AdvisoryController()
        {
        }

        [Route("response")]
        [HttpPost]
        public IActionResult SendResponse([FromBody] Response response,
            CancellationToken cancellationToken = default)
        {
            return Ok(Guid.NewGuid().ToString("D"));
        }

        [Route("response_object")]
        [HttpPost]
        public IActionResult SendResponseObject([FromBody] ResponseObject response,
            CancellationToken cancellationToken = default)
        {
            for (int i = 0; i < response.Advices.Length; ++i)
            {
                JsonElement? adviceElement = response.Advices[i] as JsonElement?;
                if (adviceElement is null)
                    return BadRequest($"Failed to parse advice object {i}");
                //does not seem to work? but we still end up with json inside the object so better to parse it via converter...
                RouteOptimizationAdvice? advice = adviceElement.Value.ToObject<RouteOptimizationAdvice>();
                if (advice is null)
                    return BadRequest($"Failed to parse advice #{i}");


                //if (advice.VoyageSummary is null)
                //    return BadRequest($"Voyage summary in the advice #{i} is empty");
                //if (advice.Route is null)
                //    return BadRequest($"Route in the advice {i} is empty");
                //if (0 != string.Compare(advice.Route.Format, "rtz", StringComparison.OrdinalIgnoreCase))
                //    return BadRequest($"Unexpected route format in the advice #{i} {advice.Route.Format}. rtz is expected");
                //if (advice.Route.Data is null || advice.Route.Data.Length < 1)
                //    return BadRequest($"Route data in the advice #{i} is missing");
            }

            return Ok(Guid.NewGuid().ToString("D"));
        }

        [Route("request")]
        [HttpPost]
        public IActionResult SendRequest([FromBody] Request request,
            CancellationToken cancellationToken = default)
        {
            return Ok(Guid.NewGuid().ToString("D"));
        }
    }
}

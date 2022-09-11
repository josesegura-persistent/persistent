using Microsoft.AspNetCore.Mvc;

namespace PersistentService.Controllers;

[ApiController]
[Route("[controller]")]
public class PersistentController : ControllerBase
{
    private readonly ILogger<PersistentController> _logger;

    public PersistentController(ILogger<PersistentController> logger)
    {
        _logger = logger;
    }

    [HttpGet("CoreValues")]
    public IEnumerable<PersistentValue> Get()
    {
        _logger.LogInformation("The values that drive our company");
        var values = new List<PersistentValue>
        {
            new()
            {
                Name = "Ingenious",
                Description = "We always want to be first to transform new ideas into tangible business results while optimizing our use of resources. We are versatile in action and agile in thought because we believe it’s important to do more with less. For us, ingenious solutions are the ultimate goal"
            },
            new()
            {
                Name = "Responsible",
                Description = "With our clients’ and colleagues’ best interest at heart, we act responsibly and communicate with clarity. Our global practice demands respect and openness towards each other, the communities around us and global society at large. We take seriously the trust placed in us and work hard to earn it every day. We never make a promise that we cannot keep"
            },
            new()
            {
                Name = "Persistent",
                Description = "In the face of complexity and rapid change, we are determined to help our customers and our people around the world succeed. The road to joint success may be long but we’re persistent where our competitors falter. Our optimism is infectious and helps customers trust in our abilities. Together we build momentum towards our shared goals"
            },
            new()
            {
                Name = "Confident",
                Description = "We meet every challenge with respect and confidence. We trust in our abilities and the difference we can make. We also understand the complexities of modern technology well enough to always keep learning. Every accomplishment and customer success adds to our ability and growth. They deserve to be talked about"
            }
        };

        return values;
    }
}

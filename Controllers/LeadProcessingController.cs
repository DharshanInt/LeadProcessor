using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/leadprocessing")]
public class LeadProcessingController : ControllerBase
{
    private readonly LeadProcessorService _leadProcessor;

    public LeadProcessingController(LeadProcessorService leadProcessor)
    {
        _leadProcessor = leadProcessor;
    }

    [HttpPost("processLead")]
    public IActionResult ProcessLead()
    {
        _leadProcessor.ProcessLead();
        return Ok();
    }
}

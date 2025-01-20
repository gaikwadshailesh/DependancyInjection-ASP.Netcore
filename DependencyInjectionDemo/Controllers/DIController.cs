using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DIController : ControllerBase
{
    private readonly SingletonService _singletonService;
    private readonly ScopedService _scopedService;
    private readonly TransientService _transientService;
    private readonly ILogger<DIController> _logger;

    public DIController(
        SingletonService singletonService,
        ScopedService scopedService,
        TransientService transientService,
        ILogger<DIController> logger)
    {
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = new
        {
            Singleton = _singletonService.GetOperationId(),
            Scoped = _scopedService.GetOperationId(),
            Transient = _transientService.GetOperationId()
        };

        _logger.LogInformation("Retrieved service IDs");
        return Ok(result);
    }

    [HttpGet("multiple")]
    public IActionResult GetMultiple()
    {
        var result = new
        {
            FirstCall = new
            {
                Singleton = _singletonService.GetOperationId(),
                Scoped = _scopedService.GetOperationId(),
                Transient = _transientService.GetOperationId()
            },
            SecondCall = new
            {
                Singleton = _singletonService.GetOperationId(),
                Scoped = _scopedService.GetOperationId(),
                Transient = _transientService.GetOperationId()
            }
        };

        _logger.LogInformation("Retrieved multiple service IDs in single request");
        return Ok(result);
    }
} 
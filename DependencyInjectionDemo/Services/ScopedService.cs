using System;

public class ScopedService : IServiceLifetimeDemo
{
    private readonly IOperationService _operationService;

    public ScopedService(IOperationService operationService)
    {
        _operationService = operationService;
    }

    public string GetOperationId() => $"Scoped: {_operationService.OperationId}";
} 
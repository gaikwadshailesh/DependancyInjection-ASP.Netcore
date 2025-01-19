using System;

public class TransientService : IServiceLifetimeDemo
{
    private readonly IOperationService _operationService;

    public TransientService(IOperationService operationService)
    {
        _operationService = operationService;
    }

    public string GetOperationId() => $"Transient: {_operationService.OperationId}";
} 
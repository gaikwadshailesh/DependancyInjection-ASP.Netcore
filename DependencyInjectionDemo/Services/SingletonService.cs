using System;

public class SingletonService : IServiceLifetimeDemo
{
    private readonly IOperationService _operationService;

    public SingletonService(IOperationService operationService)
    {
        _operationService = operationService;
    }

    public string GetOperationId() => $"Singleton: {_operationService.OperationId}";
} 
using System;

public class OperationService : IOperationService
{
    private string _operationId;

    public OperationService()
    {
        _operationId = Guid.NewGuid().ToString()[..8];
    }

    public string OperationId => _operationId;
} 
namespace MedCard.Application.Common.Exceptions;

/// <summary>
/// исключения
/// </summary>
public class NotFoundExceptions : Exception
{
    public NotFoundExceptions(string name, object key) : base($"Entity \"{name}\" ({key}) not found.") {}
}
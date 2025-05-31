namespace Shoppist.Domain.Shared.Results;

public static class ValidationErrorResults
{
    public static readonly ErrorResult RequestIsNull = new("Validation.Request.IsNull", "Request is null");
}

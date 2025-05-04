namespace Shoppist.Domain.Base.Results;

public static class ValidationErrorResults
{
    public static readonly ErrorResult RequestIsNull = new("Validation.Request.IsNull", "Request is null");
}

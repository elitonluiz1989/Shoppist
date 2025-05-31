namespace Shoppist.Domain.Shared.Request;

public abstract record PaginationRequest
{
    public int Page { get; set; }
    public int Size { get; set; }

    public int Skip => (Page - 1) * Size;
}
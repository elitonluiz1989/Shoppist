namespace Shoppist.Domain.Base.Request;

public record PaginationRequest
{
    public int Page { get; set; }
    public int Size { get; set; }

    public int Skip => (Page - 1) * Size;
}
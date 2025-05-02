namespace Shoppist.Domain.Interfaces
{
    public interface IRecordControlEntity
    {
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset UpdatedAt { get; set; }
    }
}

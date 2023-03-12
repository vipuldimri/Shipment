namespace Application.Abstractions
{
    public interface IApplicationRepositoryManager
    {
        IShipperRepository ShipperRepository { get; }
    }
}

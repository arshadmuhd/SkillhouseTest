using BusManagement.Data.Entities;

namespace BusApiWeb.Repositories
{
    public class BusRepository
    {
        public BusInfoContext BusInfoContext { get; set; }
        public BusRepository()
        {
            this.BusInfoContext = new BusInfoContext();
        }
        public List<TblBu> GetAllBus()
        {
            return BusInfoContext.TblBus.ToList();
        }
    }
}

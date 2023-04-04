using BusManagement.Data.Entities;

namespace BusManagementApi.Repositories
{
    public class Repository
    {
        public BusContext BusContext { get; set; }
        public Repository()
        {
            this.BusContext = new BusContext();
        }
        public List<TblBu> GetAllBus()
        {
            return BusContext.TblBus.ToList();
        }

        public TblBu GetBus(string destination)
        {
            var bus = BusContext.TblBus.Where(d => d.BusDestinationCity == destination).FirstOrDefault();
            return bus;

        }
        public void AddBus(TblBu tblBu)
        {
            BusContext.TblBus.Add(tblBu);
            BusContext.SaveChanges();
        }

        public void UpdateBus(TblBu tblBu)
        {
            BusContext.TblBus.Update(tblBu);
            BusContext.SaveChanges();
        }
        public void DeleteBus(int BusNumber)
        {
            var bus=BusContext.TblBus.Where(d=>d.BusNumber== BusNumber).FirstOrDefault();
            BusContext.TblBus.Remove(bus);
            BusContext.SaveChanges();
        }
    }
}

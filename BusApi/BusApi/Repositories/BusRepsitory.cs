using BusManagement.Data.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BusApi.Repositories
{
    public class BusRepsitory
    {
        public BusDataContext BusDataContext { get; set; }
        public BusRepsitory() {
            this.BusDataContext = new BusDataContext();
        }
        public List<TblBusInfo> GetBus()
        {
            return BusDataContext.TblBusInfos.ToList();
        }
        public TblBusInfo GetBus(string destination)
        {
            var bus=BusDataContext.TblBusInfos.Where(d=>d.Destination == destination).FirstOrDefault();
            return bus;
        }

        public void AddBus(TblBusInfo tblBusInfo)
        {
          BusDataContext.TblBusInfos.Add(tblBusInfo);
          BusDataContext.SaveChanges();
        }
        public void DeleteBus(int BusNumber)
        {
            var bus = BusDataContext.TblBusInfos.Where(d => d.BusNumber == BusNumber).FirstOrDefault();
            BusDataContext.Remove(bus);
            BusDataContext.SaveChanges();   
        }

        public void UpdateBus(TblBusInfo tblBusInfo)
        {

            BusDataContext.Update(tblBusInfo);
            BusDataContext.SaveChanges();
        }
    }
}

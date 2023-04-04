using BusManagement.Data.Entities;

namespace BusWebApi.Repositories
{
    public class BusRepository
    {
        public BmsContext BmsContext { get; set; }

        public BusRepository()
        {
            this.BmsContext = new BmsContext();
        }
        public List<BusInfo> GetAllBusesInfo()
        {
            return this.BmsContext.BusInfos.ToList();
        }

        public BusInfo GetBus(string destination)
        {
            if (destination != null)
            {
                var bus = BmsContext.BusInfos.Where(d => d.Destination == destination).FirstOrDefault();
                return bus;
            }
            else
            {
                return null;
            }

        }

        public void DeleteBus(int BusNumber)
        {
            var bus = BmsContext.BusInfos.Where(d => d.BusNumber == BusNumber).FirstOrDefault();
            BmsContext.BusInfos.Remove(bus);




        }


        public void UpdateBus(BusInfo busInfo)
        {


            BmsContext.BusInfos.Update(busInfo);
            BmsContext.SaveChanges();



        }

        public void AddBus(BusInfo busInfo)
        {


            BmsContext.BusInfos.Add(busInfo);
            BmsContext.SaveChanges();


        }

        /*    public void UpdateBus()
            {



                    BmsContext.BusInfos.Update(bus);





            }
    */


    }
}

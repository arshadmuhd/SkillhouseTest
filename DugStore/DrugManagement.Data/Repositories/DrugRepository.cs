using DrugManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugManagement.Data.Repositories
{
    internal class DrugRepository
    {
        DmsContext DmsContext { get; set; } 

        public DrugRepository()
        { 
            this.DmsContext = new DmsContext();
        }
        public List<TblDrug> GetAllDrug()
        {
            var drugs = this.DmsContext.TblDrugs.ToList();
            return drugs;
        }



    }
    
}

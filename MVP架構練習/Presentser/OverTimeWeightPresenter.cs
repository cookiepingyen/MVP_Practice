using IOCServiceCollection.Attributes;
using MVP架構練習.Contracts;
using MVP架構練習.Models;
using MVP架構練習.Models.Repositories;
using MVP架構練習.Models.ViewModel;
using MVP架構練習.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習
{
    [Transient]
    internal class OverTimeWeightPresenter : IOverTimePresenter
    {
        IOverTimeTable table;
        OverTimeRepository repository;
        public OverTimeWeightPresenter(IOverTimeTable table)
        {
            this.table = table;
            this.repository = new OverTimeRepository();
        }
        public void GetOverTimeList(int empID)
        {
            List<OverTime> overTimeList = repository.GetOverTimeByID(empID);

            List<EmpOverTimeTable> empOverTimeTables = Mapper.Map<OverTime, EmpOverTimeTable>(overTimeList).ToList();

            foreach (EmpOverTimeTable overTimeItem in empOverTimeTables)
            {
                overTimeItem.overHours *= 2;
            }

            this.table.OverTimeTableResponse(empOverTimeTables);
        }
    }
}

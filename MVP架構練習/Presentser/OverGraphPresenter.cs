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

namespace MVP架構練習.Presentser
{
    internal class OverGraphPresenter : IOverGraphPresenter
    {
        IOverTimeGraph graph;
        OverTimeRepository repository;

        public OverGraphPresenter(IOverTimeGraph graph)
        {
            this.graph = graph;
            this.repository = new OverTimeRepository();
        }

        public void GetOverTimeListForGraph(int empID)
        {
            List<OverTime> overTimeList = repository.GetOverTimeByID(empID);

            List<EmpOverTimeGraph> empOverTimeGraphs = Mapper.Map<OverTime, EmpOverTimeGraph>(overTimeList).ToList();
            this.graph.OverTimeGraphResponse(empOverTimeGraphs);
        }


    }
}

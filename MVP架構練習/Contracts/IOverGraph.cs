using MVP架構練習.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習.Contracts
{
    interface IOverTimeGraph
    {
        void OverTimeGraphResponse(List<EmpOverTimeGraph> empOverTimeGraphs);
    }

    interface IOverGraphPresenter
    {
        void GetOverTimeListForGraph(int empID);
    }
}

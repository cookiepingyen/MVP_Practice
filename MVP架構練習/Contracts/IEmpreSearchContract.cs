using MVP架構練習.Models;
using MVP架構練習.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習.Contracts
{
    interface IEmpSearchView
    {
        void EmpResponse(List<EmpKeyValuePair> empKeyValuePairs);
    }

    interface IEmpSearchPresenter
    {
        void GetEmpList();
    }
}

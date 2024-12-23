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
    internal class EmpSearchPresenter : IEmpSearchPresenter
    {
        IEmpSearchView view;
        EmpRepository empRepository;
        public EmpSearchPresenter(IEmpSearchView view)
        {
            this.view = view;
            this.empRepository = new EmpRepository();
        }

        public void GetEmpList()
        {
            List<Emp> empList = empRepository.GetEmpList();
            List<EmpKeyValuePair> empKeyValuePairs = Mapper.Map<Emp, EmpKeyValuePair>(empList).ToList();

            this.view.EmpResponse(empKeyValuePairs);
        }
    }
}

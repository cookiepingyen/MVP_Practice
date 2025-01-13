using IOCServiceCollection;
using Microsoft.Extensions.DependencyInjection;
using MVP架構練習.Contracts;
using MVP架構練習.Models.ViewModel;
using MVP架構練習.Presentser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP架構練習
{
    public partial class Form2 : Form, IOverTimeTable, IEmpSearchView
    {
        IEmpSearchPresenter empSearchPresenter;
        IOverTimePresenter overTimePresenter;
        public Form2(PresenterFactory presenterFactory)
        {
            InitializeComponent();
            empSearchPresenter = presenterFactory.Create<IEmpSearchPresenter, IEmpSearchView>(this);

            // 1. 固定只有一個 view 對一個 presenter 的情況
            //overTimePresenter = presenterFactory.Create<IOverTimePresenter, IOverTimeTable>(this);

            // 2. 一個 view 會對上多個 presenter 的情況
            overTimePresenter = presenterFactory.Create<IOverTimePresenter, IOverTimeTable>(this, (x) => new OverTimeWeightPresenter(this));

            empSearchPresenter.GetEmpList();
        }

        void IEmpSearchView.EmpResponse(List<EmpKeyValuePair> empKeyValuePairs)
        {
            this.empComboBox.DataSource = empKeyValuePairs;
            this.empComboBox.DisplayMember = "Name";
            this.empComboBox.ValueMember = "Id";
        }

        void IOverTimeTable.OverTimeTableResponse(List<EmpOverTimeTable> empOverTimeTables)
        {
            this.overTimeGridView.DataSource = empOverTimeTables;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empID = (int)this.empComboBox.SelectedValue;
            overTimePresenter.GetOverTimeList(empID);
        }
    }
}

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
        public Form2()
        {
            InitializeComponent();
            empSearchPresenter = new EmpSearchPresenter(this);
            overTimePresenter = new OverTimePresenter(this);
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

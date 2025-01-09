using MVP架構練習.Contracts;
using MVP架構練習.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using IOCServiceCollection;
using IOCServiceCollection.Attributes;

namespace MVP架構練習
{
    [Singleton]
    public partial class Form1 : Form, IOverTimeTable, IEmpSearchView, IOverTimeGraph
    {
        IEmpSearchPresenter empSearchPresenter;
        IOverTimePresenter overTimePresenter;
        IOverGraphPresenter graphPresenter;

        public Form1(PresenterFactory presenterFactory)
        {
            InitializeComponent();
            empSearchPresenter = presenterFactory.Create<IEmpSearchPresenter, IEmpSearchView>(this);
            overTimePresenter = presenterFactory.Create<IOverTimePresenter, IOverTimeTable>(this);
            graphPresenter = presenterFactory.Create<IOverGraphPresenter, IOverTimeGraph>(this);

            empSearchPresenter.GetEmpList();
        }

        void IEmpSearchView.EmpResponse(List<EmpKeyValuePair> empKeyValuePairs)
        {
            this.empComboBox.DataSource = empKeyValuePairs;
            this.empComboBox.DisplayMember = "Name";
            this.empComboBox.ValueMember = "Id";
        }

        void IOverTimeGraph.OverTimeGraphResponse(List<EmpOverTimeGraph> empOverTimeGraphs)
        {
            //this.overGraphChart.Series[0].Points.DataBindXY(new string[] { "開會", "測試" }, new int[] { 3, 5 });

            this.overGraphChart.Series[0].Points.Clear();
            foreach (var empOverTime in empOverTimeGraphs)
            {
                this.overGraphChart.Series[0].Points.AddXY(empOverTime.Reason, empOverTime.overHours);
            }

        }

        void IOverTimeTable.OverTimeTableResponse(List<EmpOverTimeTable> empOverTimeTables)
        {
            this.overTimeGridView.DataSource = empOverTimeTables;
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            int empID = (int)this.empComboBox.SelectedValue;
            overTimePresenter.GetOverTimeList(empID);

            graphPresenter.GetOverTimeListForGraph(empID);
        }
    }
}

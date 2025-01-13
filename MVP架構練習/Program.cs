using Microsoft.Extensions.DependencyInjection;
using MVP架構練習.Contracts;
using MVP架構練習.Presentser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MVP架構練習
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        /// 

        public static IOCServiceCollection.ServiceProvider provider = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Assembly assembly = Assembly.GetExecutingAssembly();
            IOCServiceCollection.ServiceCollection collection = new IOCServiceCollection.ServiceCollection();
            collection.AutoRegister(assembly);

            collection.AddTransient<IOverTimePresenter, OverTimePresenter>();
            collection.AddTransient<IOverTimePresenter, OverTimeWeightPresenter>();
            collection.AddTransient<IEmpSearchPresenter, EmpSearchPresenter>();

            collection.AddSingleton<Form, Form2>();


            provider = collection.BuildServiceProvider();

            Form form = provider.GetService<Form>();
            Application.Run(form);
        }
    }
}

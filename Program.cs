using pruebaPracticaCoperex.View;
using pruebaPracticaCoperex.Model;
using pruebaPracticaCoperex.Presenter;
using pruebaPracticaCoperex._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace pruebaPracticaCoperex
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
            IProductoView view = new ProductoView();
            IProductoRepository repository = new ProductoRepository(sqlConnectionString);
            new ProductoPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}

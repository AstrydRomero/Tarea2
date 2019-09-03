using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace RepositoryDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaDepartamento : ContentPage
	{
		public ListaDepartamento ()
		{
			InitializeComponent ();
            BindingContext =
                new ViewModel.ListaDepartamentoViewModel
                (new Model.deparmantoRepory
                (Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "DeparEmp.db")));
		}


        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
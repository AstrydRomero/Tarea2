using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositoryDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewCategory : ContentPage
	{
		public AddNewCategory ()
		{
			InitializeComponent ();
            BindingContext =
                new ViewModel.AddDepartamentoViewModel(new Model.deparmantoRepory
                (Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "DeparEM.db")));





        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// bu kısımda seçilen döviz kuru butonunda ilgili sayfaya yönlendirmekte
namespace odev
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();

            dolar_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.dolar());
            };

            euro_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.euro());
            };
            sterlin_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.sterlin());

            };
            yen_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.yen());

            };
            kron_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.kron());

            };
            dinar_btn.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new reelpara.dinar());

            };
        }
	}
}
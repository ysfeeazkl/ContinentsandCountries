using Servis;
using Servis.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sunum.Sayfalar
{
    /// <summary>
    /// Interaction logic for ŞehirListeleSayfası.xaml
    /// </summary>
    public partial class ŞehirListeleSayfası : Page
    {
        IDBKıtalar service = new KıtalarService();
        public ŞehirListeleSayfası()
        {
            InitializeComponent();


            var ŞehirDoldur = service.ŞehirlerListesi("select * from ŞehirBilgileri");
            DGŞehirler.ItemsSource = ŞehirDoldur;
            //var ÜlkeDoldur = service.ÜlkelerListesi("select * from ÜlkeBilgilerii");     
            //DGŞehirler.ItemsSource = ÜlkeDoldur;

        }


    }
}

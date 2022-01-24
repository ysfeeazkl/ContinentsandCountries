using Servis;
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
    /// Interaction logic for KıtaListele.xaml
    /// </summary>
    public partial class KıtaListele : Page
    {
        IDBKıtalar service = new KıtalarService();
        public KıtaListele()
        {
            InitializeComponent();

            var KıtaDoldur = service.KıtalarListesi("select * from KıtaBilgilerii");
            DGKıtalar.ItemsSource = KıtaDoldur; 
        }
    }
}

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
    /// Interaction logic for ÜlkeListeleSayfası.xaml
    /// </summary>
    public partial class ÜlkeListeleSayfası : Page
    {
        IDBKıtalar service = new KıtalarService();
        public ÜlkeListeleSayfası()
        {
            InitializeComponent();

            DGKıtalar.SelectedCellsChanged += DGKıtalar_SelectedCellsChanged;

            var KıtaDoldur = service.KıtalarListesi("select * from KıtaBilgilerii");
            DGKıtalar.ItemsSource = KıtaDoldur;

        }

        private void DGKıtalar_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var seçilenKıta = (KıtalarDTO)DGKıtalar.SelectedItem;

            var ÜlkeDoldur = service.ÜlkelerListesi($"select * from ÜlkeBilgilerii where ÜlkeKıtası = {seçilenKıta.KıtaID}");
            DGÜlkeler.ItemsSource = ÜlkeDoldur;
        }
    }
}

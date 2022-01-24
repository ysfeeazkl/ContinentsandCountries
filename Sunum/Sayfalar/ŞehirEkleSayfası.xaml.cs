using Microsoft.Win32;
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
    /// Interaction logic for ŞehirEkleSayfası.xaml
    /// </summary>
    public partial class ŞehirEkleSayfası : Page
    {
        OpenFileDialog oFd;
        IDBKıtalar service = new KıtalarService();
        BitmapImage sResim;
        public ŞehirEkleSayfası()
        {
            InitializeComponent();
            DGÜlkeler.SelectedCellsChanged += DGÜlkeler_SelectedCellsChanged;
            btnEkle.Click += BtnEkle_Click;          

            var ÜlkeDoldur = service.ÜlkelerListesi("select * from ÜlkeBilgilerii");
            DGÜlkeler.ItemsSource = ÜlkeDoldur; 
        }

        private void DGÜlkeler_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var seçilenÜlke = (ÜlkelerDTO)DGÜlkeler.SelectedItem;

            txtÜlkeAd.Text = seçilenÜlke.ÜlkeAd;
        }



        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            var seçilenÜlke = (ÜlkelerDTO)DGÜlkeler.SelectedItem;

            service.insert($"insert into ŞehirBilgileri(ŞehirAdı,YüzÖlçümü,Nüfusu,TelefonKodu,ÜlkesiID,KıtasıID) values('{txtŞehirAd.Text}','{txtYüzÖlçümü.Text}','{txtNüsfusu.Text}','{txtTelefonKodu.Text}',{seçilenÜlke.ÜlkeID},{seçilenÜlke.ÜlkeKıtası})");

            NavigationService.Content = new ŞehirListeleSayfası();
        }
      
    }
}

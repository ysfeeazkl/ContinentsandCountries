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
    /// Interaction logic for ÜlkeEkleSayfası.xaml
    /// </summary>
    public partial class ÜlkeEkleSayfası : Page
    {
        OpenFileDialog oFd;
        IDBKıtalar service = new KıtalarService();
        BitmapImage sResim;
        public ÜlkeEkleSayfası()
        {
            InitializeComponent();
            DGKıtalar.SelectedCellsChanged += DGKıtalar_SelectedCellsChanged;
            btnEkle.Click += BtnEkle_Click;

            ImgHavaYolu.MouseDown += ImgHavaYolu_MouseDown;


            var KıtaDoldur = service.KıtalarListesi("select * from KıtaBilgilerii");
            DGKıtalar.ItemsSource = KıtaDoldur;
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            var seçilenKıta = (KıtalarDTO)DGKıtalar.SelectedItem;

            service.insert($"insert into ÜlkeBilgilerii(ÜlkeAd,ÜlkeResmi,ÜlkeKıtası) values('{txtÜlkeAd.Text}','{sResim}',{seçilenKıta.KıtaID})");

            NavigationService.Content = new ÜlkeListeleSayfası();
        }

        private void DGKıtalar_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var seçilenKıta = (KıtalarDTO)DGKıtalar.SelectedItem;

            txtKıtaAd.Text = seçilenKıta.KıtaAd;

           
        }

        private void ImgHavaYolu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            oFd = new OpenFileDialog
            {
                Filter = "Resim Dosyaları |*.jpg;*.bmp;*.jpeg;*.png;| Tüm Dosyalar|*.*"
            };
            if (oFd.ShowDialog() == true)
            {
                sResim = new BitmapImage(new Uri(oFd.FileName));
                ImgHavaYolu.Source = sResim;
            }
        }
    }
}

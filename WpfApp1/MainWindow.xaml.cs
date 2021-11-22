using BTL;
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
using WpfApp1.Database;
using Menu = BTL.Menu;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { Model1 db = new Model1();
        public Ban selected;
      
        public MainWindow()
        { 
            InitializeComponent();
            statisticalBodyDataGrip.AutoGenerateColumns = false;
            var products = GetProducts();
            if (products.Count > 0)
            {
                listViewSell.ItemsSource = products;
            }
            var detailproduct = GetDetailProducts();

            if (detailproduct.Count > 0)
            {
                listViewSellDetailProduct.ItemsSource = detailproduct;
            }
          
            manageBodyAccountDataGrip.ItemsSource = LoadAccount();
            //manageBodyGroupOfDishesDataGrip.ItemsSource = LoadGroupOfDishes();
            manageBodyMenusDataGrip.ItemsSource = LoadMenu();
            statisticalBodyDataGrip.ItemsSource = LoadStatistical();
          
            reload();
            reloadGroupOfDishesDataGrip();
        }

        //getdata
        public void reload()
        {     
            manageBodyTableDataGrip.AutoGenerateColumns = false;
            manageBodyAccountDataGrip.AutoGenerateColumns = false;
            manageBodyMenusDataGrip.AutoGenerateColumns = false;
            manageBodyTableDataGrip.ItemsSource = new Model1().Bans.ToList();
            manageBodyAccountDataGrip.ItemsSource = new Model1().DangNhaps.ToList();
            manageBodyMenusDataGrip.ItemsSource = new Model1().ThucDons.ToList();
        }
        public void reloadGroupOfDishesDataGrip()
        {
        
            manageBodyGroupOfDishesDataGrip.AutoGenerateColumns = false;

            manageBodyGroupOfDishesDataGrip.ItemsSource = new Model1().NhomMons.ToList();
        }

        private List<DetailProduct> GetDetailProducts()
        {
            return new List<DetailProduct>(){
                new DetailProduct("Cafe sữa","25.000"),
                 new DetailProduct("Cafe sữa","25.000"),
                 new DetailProduct("Cafe sữa","25.000"),
                 new DetailProduct("Cafe sữa","25.000"),
                 new DetailProduct("Cafe sữa","25.000"),
                   new DetailProduct("Cafe sữa","25.000"),
            };
        }
        private List<ManageTable> LoadCollectionData()
        {
            List<ManageTable> authors = new List<ManageTable>();
            authors.Add(new ManageTable()
            {
                Id = "1",
                TênBan = "Mahesh Chand",
                TrangThai = "Graphics Programming with GDI+",

            });

            authors.Add(new ManageTable()
            {
                Id = "2",
                TênBan = "Mahesh Chand",
                TrangThai = "Graphics Programming with GDI+",
            });

            authors.Add(new ManageTable()
            {
                Id = "3",
                TênBan = "Mahesh Chand",
                TrangThai = "Graphics Programming with GDI+",
            });
            authors.Add(new ManageTable()
            {
                Id = "3",
                TênBan = "Mahesh Chand",
                TrangThai = "Graphics Programming with GDI+",
            });
            authors.Add(new ManageTable()
            {
                Id = "3",
                TênBan = "Mahesh Chand",
                TrangThai = "Graphics Programming with GDI+",
            });

            return authors;
        }
        private List<ManageAccount> LoadAccount()
        {
            List<ManageAccount> accounts = new List<ManageAccount>();
            accounts.Add(new ManageAccount()
            {
                Id = "1",
                NameAccount = "Mahesh Chand",
                PassWord = "Graphics Programming with GDI+",

            });

            accounts.Add(new ManageAccount()
            {
                Id = "2",
                NameAccount = "Mahesh Chand",
                PassWord = "Graphics Programming with GDI+",
            });

            accounts.Add(new ManageAccount()
            {
                Id = "3",
                NameAccount = "Mahesh Chand",
                PassWord = "Graphics Programming with GDI+",
            });
            accounts.Add(new ManageAccount()
            {
                Id = "4",
                NameAccount = "Mahesh Chand",
                PassWord = "Graphics Programming with GDI+",
            });
            accounts.Add(new ManageAccount()
            {
                Id = "5",
                NameAccount = "Mahesh Chand",
                PassWord = "Graphics Programming with GDI+",
            });

            return accounts;
        }
        //private List<GroupOfDishes> LoadGroupOfDishes()
        //{
        //    List<GroupOfDishes> groupOfDishes = new List<GroupOfDishes>();
        //    groupOfDishes.Add(new GroupOfDishes()
        //    {
        //        MaLoai = "1",
        //        TenLoai = "Mahesh Chand",
        //        MauSac = "Graphics Programming with GDI+",

        //    });

        //    groupOfDishes.Add(new GroupOfDishes()
        //    {

        //        MaLoai = "1",
        //        TenLoai = "Mahesh Chand",
        //        MauSac = "Graphics Programming with GDI+",
        //    });

        //    groupOfDishes.Add(new GroupOfDishes()
        //    {

        //        MaLoai = "1",
        //        TenLoai = "Mahesh Chand",
        //        MauSac = "Graphics Programming with GDI+",
        //    });
        //    groupOfDishes.Add(new GroupOfDishes()
        //    {

        //        MaLoai = "1",
        //        TenLoai = "Mahesh Chand",
        //        MauSac = "Graphics Programming with GDI+",
        //    });
        //    groupOfDishes.Add(new GroupOfDishes()
        //    {

        //        MaLoai = "1",
        //        TenLoai = "Mahesh Chand",
        //        MauSac = "Graphics Programming with GDI+",
        //    });

        //    return groupOfDishes;
        //}
        private List<Menu> LoadMenu()
        {
            List<Menu> menus = new List<Menu>();
            menus.Add(new Menu()
            {
                MaMon = "1",
                TenMon = "cafe",
                MaLoai = "cafe",
                DonGia = 12000,
                DVT = "lon"
            });

            menus.Add(new Menu()
            {
                MaMon = "1",
                TenMon = "cafe",
                MaLoai = "cafe",
                DonGia = 12000,
                DVT = "lon"
            });

            menus.Add(new Menu()
            {

                MaMon = "1",
                TenMon = "cafe",
                MaLoai = "cafe",
                DonGia = 12000,
                DVT = "lon"
            });
            menus.Add(new Menu()
            {
                MaMon = "1",
                TenMon = "cafe",
                MaLoai = "cafe",
                DonGia = 12000,
                DVT = "lon"
            });
            menus.Add(new Menu()
            {

                MaMon = "1",
                TenMon = "cafe",
                MaLoai = "cafe",
                DonGia = 12000,
                DVT = "lon"
            });

            return menus;
        }
        private List<Statistical> LoadStatistical()
        {
            List<Statistical> statisticals = new List<Statistical>();
            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });

            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });

            statisticals.Add(new Statistical()
            {

                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });
            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });
            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });
            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });
            statisticals.Add(new Statistical()
            {
                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });
            statisticals.Add(new Statistical()
            {

                MaMon = "123",

                TienMon = 20000,
                GiamGia = 0,
                ThanhTien = 20000,
                DiemBan = "Bàn 1",
                CacMon = "Cafe",
            });

            return statisticals;
        }
        public List<Product> GetProducts()
        {
            return new List<Product>()
      {
        new Product("Bàn 1", 205.46, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 2", 102.50, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 3", 400.99, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 4", 350.26, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 5", 150.10, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 6", 100.02, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 7", 295.25, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
        new Product("Bàn 8", 700.00, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg"),
         new Product("Bàn 8", 700.00, "https://banner2.cleanpng.com/20180218/tle/kisspng-coffee-table-cafe-chair-black-cafe-chairs-vector-material-download-5a89fb88658cf0.609842941518992264416.jpg")
      };
        }
        public void btn_sellBodyLeftImageTable(object sender, RoutedEventArgs e)
        {
            sellBodyRightLeft.Visibility = Visibility.Visible;
            sellBodyRightRightImage.Visibility = Visibility.Visible;
            sellBodyRightImage.Visibility = Visibility.Hidden;
            sellBodyRightLeftBooking.Visibility = Visibility.Visible;
            sellBodyRightLeftOrder.Visibility = Visibility.Visible;
            sellBodyRightLeftComBack.Visibility = Visibility.Visible;
            sellBodyRightLeftCanCel.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightRightRight.Visibility = Visibility.Hidden;
            sellBodyRightLeftChooseDish.Visibility = Visibility.Hidden;



        }

        private void btn_sellBodyRightLeftBooking(object sender, RoutedEventArgs e)
        {

            sellBodyRightLeftStatus.Text = "Đã Đặt Trước";
        }

        private void btn_manageBodyAccount(object sender, RoutedEventArgs e)
        {
            manageBodyAccount.Visibility = Visibility.Visible;
            manageBodyMenu.Visibility = Visibility.Hidden;
            manageBodyTabble.Visibility = Visibility.Hidden;
            manageBodyAccountbutton.Background = Brushes.Green;
            manageBodyGroupOfDishes.Visibility = Visibility.Hidden;
            manageBodyMenuButton.Background = Brushes.DarkViolet;
            manageBodyTableButton.Background = Brushes.DarkViolet;
            manageBodyGroupOfDishesButton.Background = Brushes.DarkViolet;

        }
        private void btn_manageBodyAccountAdd(object sender, RoutedEventArgs e)
        {
            // manageBodyAccountDialogAdd.Visibility = Visibility.Visible;
            manageBodyAccountDialogAdd.Visibility = Visibility.Visible;
        }
        private void btn_manageBodyAccountUpdate(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyAcountDialogAgree(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyAccountDialogCanCelUpdate(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyAccountDelete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButton.OKCancel);
        }

        private void btn_manageBodyAccountDialogCanCel(object sender, RoutedEventArgs e)
        {

            manageBodyAccountDialogAdd.Visibility = Visibility.Hidden;
        }
        private void btn_manageBodyTable(object sender, RoutedEventArgs e)
        {

            manageBodyTabble.Visibility = Visibility.Visible;
            manageBodyTableButton.Background = Brushes.Green;
            manageBodyMenu.Visibility = Visibility.Hidden;

            manageBodyAccount.Visibility = Visibility.Hidden;
            manageBodyGroupOfDishes.Visibility = Visibility.Hidden;

            manageBodyMenuButton.Background = Brushes.DarkViolet;
            manageBodyAccountbutton.Background = Brushes.DarkViolet;
            manageBodyGroupOfDishesButton.Background = Brushes.DarkViolet;

        }
        private void btn_manageBodyTableAdd(object sender, RoutedEventArgs e)
        {
            manageBodyTableDialogAdd.Visibility = Visibility.Visible;
            //   manageBodyAccountDataGrip.Visibility = Visibility.Hidden;
        }
        private void btn_manageBodyTableUpdate(object sender, RoutedEventArgs e)
        {

            manageBodyTableDialogUpdate.Visibility = Visibility.Visible;
        }
        private void btn_manageBodyTableDelete(object sender, RoutedEventArgs e)
        {
           // manageBodyTableDataGrip.Items.RemoveAt(manageBodyTableDataGrip.SelectedIndex);
            MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButton.OKCancel);
        }

        private void btn_manageBodyTableDialogAgree(object sender, RoutedEventArgs e)
        {
            manageBodyTableDialogAdd.Visibility = Visibility.Hidden;
            var ban = new Ban();
            ban.MaBan = DialogDiskTable.Text;
            ban.TenBan = DialogNameTable.Text;
            ban.TrangThai = "Trống";
            db.Bans.Add(ban);
            db.SaveChanges();
            reload();
        }
        private void btn_manageBodyTableDialogCanCel(object sender, RoutedEventArgs e)
        {
            manageBodyTableDialogAdd.Visibility = Visibility.Hidden;
            manageBodyTableDataGrip.Visibility = Visibility.Visible;

        }

        private void btn_manageBodyTableDialogEditCanCel(object sender, RoutedEventArgs e)
        {
            manageBodyTableDialogAdd.Visibility = Visibility.Hidden;
            manageBodyTableDataGrip.Visibility = Visibility.Visible;

        }
        private void btn_manageBodyTableDataGrip(object sender, SelectionChangedEventArgs args)
        {
            select((Ban)manageBodyTableDataGrip.SelectedItem);

        }
        void select(Ban sa)
        {
            selected = sa;
            if (sa != null)
            {
                DialogDiskTableUpdate.Text = sa.MaBan;
                DialogNameTableUpdate.Text = sa.TenBan;
            }
        }
        //btn_manageBodyGroupOfDishes
        private void btn_manageBodyGroupOfDishes(object sender, RoutedEventArgs e)
        {
            manageBodyGroupOfDishes.Visibility = Visibility.Visible;
            manageBodyMenu.Visibility = Visibility.Hidden;
            manageBodyTabble.Visibility = Visibility.Hidden;
            manageBodyAccount.Visibility = Visibility.Hidden;
            manageBodyGroupOfDishesButton.Background = Brushes.Green; ;
            manageBodyMenuButton.Background = Brushes.DarkViolet;
            manageBodyAccountbutton.Background = Brushes.DarkViolet;
            manageBodyTableButton.Background = Brushes.DarkViolet;

        }
        private void btn_manageBodyGroupOfDishestAdd(object sender, RoutedEventArgs e)
        {
            manageBodyGroupOfDishesDialogAdd.Visibility = Visibility.Visible;

        }
        private void btn_manageBodyGroupOfDishesUpdate(object sender, RoutedEventArgs e)
        {
            manageBodyGroupOfDishesDialogUpdate.Visibility = Visibility.Visible;

        }
        private void btn_manageBodyTableDialogUpdateCanCel(object sender, RoutedEventArgs e)
        {
            //manageBodyTableDialogAdd.Visibility = Visibility.Hidden;
            //manageBodyTableDataGrip.Visibility = Visibility.Visible;
            manageBodyTableDialogUpdate.Visibility = Visibility.Hidden;
        }
        private void btn_manageBodyTableDialogUpdateAgree(object sender, RoutedEventArgs e)
        {
            manageBodyTableDialogAdd.Visibility = Visibility.Hidden;
            manageBodyTableDataGrip.Visibility = Visibility.Visible;
            manageBodyTableDialogUpdate.Visibility = Visibility.Hidden;
            Ban exting = db.Bans.Find(selected.MaBan);
            exting.MaBan = DialogDiskTableUpdate.Text;
            exting.TenBan = DialogNameTableUpdate.Text;
            db.SaveChanges();
            reload();

        }
        private void btn_manageBodyGroupOfDishesDelete(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButton.OKCancel);
        }
        private void btn_manageBodyGroupOfDisheDialogAgree(object sender, RoutedEventArgs e)
        {


        }
        private void btn_manageBodyGroupOfDishetDialogCanCel(object sender, RoutedEventArgs e)
        {


            manageBodyGroupOfDishesDialogAdd.Visibility = Visibility.Hidden;
        }
        private void btn_manageBodyGroupOfDisheDialogUpdateAgree(object sender, RoutedEventArgs e)
        {


        }
        private void btn_manageBodyGroupOfDishetDialogUpdateCanCel(object sender, RoutedEventArgs e)
        {


        }
        private void btn_chọn(object sender, RoutedEventArgs e)
        {
            sellBodyDialogChooseProduct.Visibility = Visibility.Visible;
        }
        private void btn_sellBodyRightRightLeft_Cafe(object sender, RoutedEventArgs e)
        {
            sellBodyRightRightRight.Visibility = Visibility.Visible;

            sellBodyRightRightRight1.Visibility = Visibility.Hidden;

        }
        private void btn_sellBodyRightRightLeft_BottledWater(object sender, RoutedEventArgs e)
        {

            sellBodyRightRightRight.Visibility = Visibility.Hidden;
        }
        private void btn_sellBodyRightLeftOrder(object sender, RoutedEventArgs e)
        {
            sellBodyRightRightLeftMenu.Visibility = Visibility.Visible;
            sellBodyRightRightImage.Visibility = Visibility.Hidden;
            sellBodyRightRightRight1.Visibility = Visibility.Visible;
            sellBodyRightLeftOrder.Visibility = Visibility.Hidden;
            sellBodyRightLeftBooking.Visibility = Visibility.Hidden;
            sellBodyRightLeftCanCel.Visibility = Visibility.Visible;
            sellBodyRightLeftComBack.Visibility = Visibility.Hidden;
            sellBodyRightLeftStatus.Text = "Đang Phục Vụ";
            sellBodyRightLeftChooseDishStatus.Text = "Đang Phục Vụ";

        }
        private void btn_sellBodyRightRightLeft_FaintSilver(object sender, RoutedEventArgs e)
        {

        }
        private void btn_sellBodyRightRightLeft_CansOfWater(object sender, RoutedEventArgs e)
        {

        }
        private void btn_sellBodyRightRightLeft_FastFood(object sender, RoutedEventArgs e)
        {

        }
        private void btn_sellBodyRightRightLeft_OtherFood(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyMenuDialogAgreeUpdate(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyMenutDialogCanCelUpdate(object sender, RoutedEventArgs e)
        {
            manageBodyMenusDialogUpdate.Visibility = Visibility.Hidden;
        }
        private void btn_manageBodyMenu(object sender, RoutedEventArgs e)
        {
            manageBodyMenu.Visibility = Visibility.Visible;
            manageBodyTabble.Visibility = Visibility.Hidden;
            manageBodyAccount.Visibility = Visibility.Hidden;
            manageBodyGroupOfDishes.Visibility = Visibility.Hidden;
            manageBodyMenuButton.Background = Brushes.Green;
            manageBodyGroupOfDishesButton.Background = Brushes.DarkViolet;
            manageBodyAccountbutton.Background = Brushes.DarkViolet;
            manageBodyTableButton.Background = Brushes.DarkViolet;
        }
        private void btn_manageBodyMenuAdd(object sender, RoutedEventArgs e)
        {
            manageBodyMenusDialogAdd.Visibility = Visibility.Visible;
        }
        private void btn_manageBodyMenuUpdate(object sender, RoutedEventArgs e)
        {
            manageBodyMenusDialogUpdate.Visibility = Visibility.Visible;
        }
        //btn_manageBodyMenuDelete
        private void btn_manageBodyMenuDelete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButton.OKCancel);
        }
        private void btn_manageBodyMenuDialogAgree(object sender, RoutedEventArgs e)
        {

        }
        private void btn_manageBodyMenutDialogCanCel(object sender, RoutedEventArgs e)
        {
            manageBodyMenusDialogAdd.Visibility = Visibility.Hidden;
        }
        private void btn_sellBodyRightRightRightChooseProduct(object sender, RoutedEventArgs e)
        {
            sellBodyDialogChooseProduct.Visibility = Visibility.Visible;
        }
        private void btn_sellBodyRightLeftCanCel(object sender, RoutedEventArgs e)
        {
            sellBodyRightLeft.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightRightImage.Visibility = Visibility.Hidden;
            sellBodyRightRightRight.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightImage.Visibility = Visibility.Visible;
        }
        private void btn_sellBodyRightLefChooseDishPay(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Bạn Đã Thanh Toán Thành Công", "Thanh Toán", MessageBoxButton.OK);
            sellBodyRightLeft.Visibility = Visibility.Hidden;
            sellBodyRightRightImage.Visibility = Visibility.Hidden;
            sellBodyRightImage.Visibility = Visibility.Hidden;
            sellBodyRightLeftBooking.Visibility = Visibility.Hidden;
            sellBodyRightLeftOrder.Visibility = Visibility.Hidden;
            sellBodyRightLeftComBack.Visibility = Visibility.Hidden;
            sellBodyRightLeftCanCel.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightRightRight.Visibility = Visibility.Hidden;
            sellBodyRightLeftChooseDish.Visibility = Visibility.Hidden;
            sellBodyRightImage.Visibility = Visibility.Visible;
        }
        private void btn_sellBodyDialogChooseProductCanCel(object sender, RoutedEventArgs e)
        {
            sellBodyDialogChooseProduct.Visibility = Visibility.Hidden;
        }
        private void btn_sellBodyDialogChooseProductAgree(object sender, RoutedEventArgs e)
        {
            sellBodyRightLeftChooseDish.Visibility = Visibility.Visible;
            sellBodyRightLeft.Visibility = Visibility.Hidden;
            sellBodyDialogChooseProduct.Visibility = Visibility.Hidden;
        }


        private void btn_sellBodyRightLeftComeBack(object sender, RoutedEventArgs e)
        {

            sellBodyRightLeft.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightRightImage.Visibility = Visibility.Hidden;
            sellBodyRightRightRight.Visibility = Visibility.Hidden;
            sellBodyRightRightLeftMenu.Visibility = Visibility.Hidden;
            sellBodyRightImage.Visibility = Visibility.Visible;
        }

    }
}

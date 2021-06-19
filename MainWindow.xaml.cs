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

namespace Termproject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Uparu
        {
            public int Level { get; set; }
            public int Accu { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
            public string Type1 { get; set; }
            public string Type2 { get; set; }
            public string Type3 { get; set; }
            public string Cbn1 { get; set; }
            public string Cbn2 { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }
            

            public Uparu(int level, int accu, string name, string time, string type1, string type2, string type3, string cbn1, string cbn2, string what, string money,string image)
            {
                Level = level;
                Accu = accu;
                Name = name;
                Time = time;
                Type1 = type1;
                Type2 = type2;
                Type3 = type3;
                Cbn1 = cbn1;
                Cbn2 = cbn2;
                Price = what + " "+ money;
                Image = image;
            }
        }

        protected List<Uparu> UparuList = new List<Uparu>();
        protected List<Uparu> lovingUparuList = new List<Uparu>();

        public MainWindow()
        {
            InitializeComponent();
            Uri mainuri = new Uri("http://cafefiles.naver.net/20130214_150/5248aa_13608458140050irzI_JPEG/%BF%EC%C6%C4%B7%E7%B9%E8%B0%E6%C8%AD%B8%E9.JPG");
            image.Source = new BitmapImage(mainuri);

            DataContext = this;
            MyGrid.ItemsSource = UparuList;
            loveGrid.ItemsSource = lovingUparuList;

            SettingBaseUparu();
            
        }

        public void SettingBaseUparu()
        {
            UparuList.Add(new Uparu(1, 0, "두더루", "15분", "땅", "", "", "두더루", "두더루", "마나볼", "100", "http://blogfiles.naver.net/20130618_41/uhuh1981_1371540119208QUpWJ_JPEG/iPhone_1.jpg"));
            UparuList.Add(new Uparu(1, 0, "프링", "2시간 30분", "숲", "불", "", "포리", "뿌루루", "보석", "30", "http://cafefiles.naver.net/20130310_141/psh1948_13628794331876wQpK_PNG/-1373155190.png"));
            UparuList.Add(new Uparu(1, 0, "도도", "23시간 30분", "불", "천둥", "바람", "MK", "스컬루", "보석", "1000", "http://blogfiles.naver.net/20131201_172/sweetasluv_1385855444408LT1gH_JPEG/%B5%B5%B5%B5.jpg"));
            UparuList.Add(new Uparu(1, 0, "베쿠베쿠", "13시간 45분", "슈가", "매직", "", "푸딩", "마이티", "보석", "500", " http://blogfiles.naver.net/20140905_39/chatokato_1409928267292b0l5T_PNG/IMG_7500.PNG"));
            UparuList.Add(new Uparu(1, 0, "호키", "24시간 30분", "물", "매직", "천둥", "큐피", "퍼시", "보석", "860", " http://blogfiles.naver.net/MjAxODAyMDJfMjQx/MDAxNTE3NTIxNzMyNDUy.xgtJBTJRD8BL0bNRz2uRHPexOZfnl-p-f3pBIYux5WIg.La9qOxmReq_JCFBkTzQ-1NdzuHZ9QTL8pPSJKkVj5fUg.JPEG.ggujibbong/%B2%D9%B9%CC%B1%E2_Capture%2B_2018-02-02-06-37-00.jpg"));
            UparuList.Add(new Uparu(1, 0, "팔레캣", "27시간 45분", "눈", "슈가", "바람", "슈크램", "아이린", "보석", "1150", "http://blogfiles.naver.net/MjAxODA3MTlfMTE5/MDAxNTMxOTcxNDgxMTMz.zTsdHKVOBSXVCq5QcuwbUMgVCXgAuRo96wFnJ3gUx28g.Ie9_XPzguLX9faOF2slQ-gjB2ix95PMqe72eZAdBlIUg.JPEG.ggujibbong/-Capture%2B_2018-07-19-12-03-19.jpg"));
            UparuList.Add(new Uparu(1, 0, "포토비", "18시간 45분", "천둥", "매직", "", "우루루", "챠미", "보석", "650", "http://blogfiles.naver.net/MjAxODA3MTNfMjI1/MDAxNTMxNDgxMjI0NzA0.I80-3QVtPWHO3hJvrFmc5GXUjBJnjHfwz1Ml-EGAC_Eg.GRLr1rMJ7HY0JyXAJUmkmIxjVj57P7pxVq1cneR6f-gg.JPEG.ggujibbong/-Capture%2B_2018-07-13-12-56-14.jpg"));
            UparuList.Add(new Uparu(1, 0, "라플리", "2시간 30분", "불", "풀", "", "루돌", "제로", "보석", "280", "http://blogfiles.naver.net/20150815_42/jdb0203_1439614435257cb4hH_PNG/Screenshot_2015-08-14-22-16-17-1.png"));
            UparuList.Add(new Uparu(1, 0, "츄파", "45분", "얼음", "", "", "츄파", "츄파", "마나볼", "15000", "http://cafefiles.naver.net/20130310_231/psh1948_1362879428163FhQF6_PNG/-881803425.png"));
            UparuList.Add(new Uparu(1, 0, "비빔룡", "24시간 45분", "풀", "불", "천둥", "삼삼", "동크", "보석", "1350", "http://cafefiles.naver.net/20151201_1/hp121377_1448929703101YS2cc_PNG/Screenshot_2015-12-01-08-50-15-1.png"));




        }

        private void OnFood(object sender, RoutedEventArgs e)
        {
            if(loveGrid.SelectedIndex != -1)
            {
                Uparu up = (Uparu)loveGrid.Items[loveGrid.SelectedIndex];
                int levelcnt = (int)up.Level;
                int accufood = (int)up.Accu;

                int cntfood = (int) Math.Pow(2, levelcnt - 1);
                

                if (levelcnt >= 20)
                {
                    MessageBox.Show("이 우파루는 최고레벨입니다.");
                    return;
                }
                    

                accufood += cntfood;
                

                if (accufood >= cntfood * 4)
                {
                    levelcnt++;
                    
                    accufood = 0;
                }
                    

                up.Level = levelcnt;
                up.Accu = accufood;

                loveGrid.Items.Refresh();

            }

            else
                MessageBox.Show("서식지로 이동해서 먹이를 주세요!");

        }

        private void OnlovingAdd(object sender, RoutedEventArgs e)
        {
            if(MyGrid.SelectedIndex != -1)
            {
                lovingUparuList.Add((Uparu)MyGrid.Items[MyGrid.SelectedIndex]);
                UparuList.RemoveAt(MyGrid.SelectedIndex);
                loveGrid.Items.Refresh();
                MyGrid.Items.Refresh();
            }
                
 
        }

        private void OnlovingCancel(object sender, RoutedEventArgs e)
        {
            if(loveGrid.SelectedIndex != -1)
            {
                UparuList.Add((Uparu)loveGrid.Items[loveGrid.SelectedIndex]);
                lovingUparuList.RemoveAt(loveGrid.SelectedIndex);
                loveGrid.Items.Refresh();
                MyGrid.Items.Refresh();

            }

        }

        private void OnFocus(object sender, RoutedEventArgs e)
        {
            loveGrid.SelectedIndex = -1;
        }
        private void OnFocuslove(object sender, RoutedEventArgs e)
        {
            MyGrid.SelectedIndex = -1;
        }



        private void OnAdd(object sender, RoutedEventArgs e)
        {
            
            Uparudlg dlg = new Uparudlg();
            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show("우파루가 소환되었습니다!");
                UparuList.Add(new Uparu(1,0,dlg.Uparudlg_Name, dlg.Uparudlg_Time, dlg.Uparudlg_Type1, dlg.Uparudlg_Type2, dlg.Uparudlg_Type3, dlg.Uparudlg_Cbn1, dlg.Uparudlg_Cbn2, dlg.Uparudlg_What, dlg.Uparudlg_Money,dlg.Uparudlg_Image));
                MyGrid.Items.Refresh();
            }


        }

        private void OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if(MyGrid.SelectedIndex != -1)
            {
                Uparu img = (Uparu)MyGrid.Items[MyGrid.SelectedIndex];

                image.Source = new BitmapImage(new Uri(img.Image));
            }
            
            else if(loveGrid.SelectedIndex != -1)
            {
                Uparu img2 = (Uparu)loveGrid.Items[loveGrid.SelectedIndex];

                image.Source = new BitmapImage(new Uri(img2.Image));

            }
        }
    }
}

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
using System.Windows.Shapes;

namespace Termproject
{
    /// <summary>
    /// Uparudlg.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Uparudlg : Window
    {
        

        public string Uparudlg_Name
        {
            get { return Namedlg.Text; }
        }

        public string Uparudlg_Time
        {
            get { return Timedlg.Text; }
        }

        public string Uparudlg_Type1
        {
            get { return Type1dlg.Text; }
        }

        public string Uparudlg_Type2
        {
            get { return Type2dlg.Text; }
        }

        public string Uparudlg_Type3
        {
            get { return Type3dlg.Text; }
        }
        public string Uparudlg_Cbn1
        {
            get { return Cbn1dlg.Text; }
        }
        public string Uparudlg_Cbn2
        {
            get { return Cbn2dlg.Text; }
        }
        public string Uparudlg_What
        {
            get { return Whatdlg.Text; }
        }
        public string Uparudlg_Money
        {
            get { return Moneydlg.Text; }
        }

        public string Uparudlg_Image
        {
            get { return Imagedlg.Text; }

        }



        public Uparudlg()
        {
            InitializeComponent();
            Namedlg.Focus(); 
        }

        private void OnOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}

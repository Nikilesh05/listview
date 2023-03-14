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

namespace bindingstdinfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        List<details> odetail;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (odetail == null)
            {
                odetail = new List<details>();
            }
            details info = new details();
            info.sid = txtid.Text;
            info.name = txtname.Text;
            info.fname = txtfname.Text;
            info.course = cmbcrs.Text;
            info.dept = cmbdept.Text;
            info.percentage = Convert.ToDecimal(txtper.Text);
            info.email = txtemail.Text;
            info.gender = gen.ToString();
            info.number = Convert.ToInt32(txtnum.Text);
            odetail.Add(info);

            lststud.ItemsSource = odetail;
            lststud.Items.Refresh();


            //foreach (var item in odetail)
            //{
            // MessageBox.Show(item.name);
            // }
           MessageBoxResult res =  MessageBox.Show("Registered Successfully", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (res == MessageBoxResult.OK)
            {
                txtname.Clear();
                txtid.Clear();
                txtfname.Clear();
                txtper.Clear();
                txtemail.Clear();
                txtnum.Clear();
                //gen.Clear();
                cmbcrs.SelectedItem = null;
                cmbdept.SelectedItem = null;
            }
            //else
            //{
            //    foreach (var item in odetail)
            //    {
            //        MessageBox.Show(item.name);
            //    }
            //}



        }
       
    }
    public class details
    {
        public String sid;
        public String name;
        public String fname;
        public String gender;
        public String course;
        public String dept;
        public Decimal percentage;
        public String email;
        public int number;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tra
{
    public partial class 欢迎界面 : Form
    {
        static string city;

        public 欢迎界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (city)
            {
                case "北京": ;
                    北京 form = new 北京();
                    form.Show();
                    this.Hide();
                    break;
                case "上海": ;
                    上海 form1 =new 上海 ();
                    form1.Show ();
                    this.Hide ();
                    break;
                case "深圳": 
                    深圳  form2 =new 深圳 ();
                    form2.Show ();
                    this.Hide ();
                    break;
                    
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items != null && comboBox1.Items.Count > 0 && comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "北京": MessageBox.Show("北京");
                        city = "北京";
                        break; 
                    case "上海": MessageBox.Show("上海");
                        city = "上海";
                        break; 
                    case "深圳": MessageBox.Show("深圳");
                        city = "深圳";
                        break; 
                }
            }
        }

        private void 欢迎界面_Load(object sender, EventArgs e)
        {

        }
    }
}

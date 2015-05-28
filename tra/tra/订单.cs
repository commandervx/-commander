using System;
using System.Collections;
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
    public partial class 订单 : Form
    {
        ArrayList allpresent = new ArrayList();
        string presentpath = "./Present.txt";
        string orderpath = "./order.txt";
        public 订单()
        {
            InitializeComponent();
           /*allpresent= OperateFile.readFromFile (orderpath);
           ListViewItem item = new ListViewItem();
           item.SubItems[0].Text = (string)allpresent[0];
           item.SubItems.Add((string)allpresent[1]);
           item.SubItems.Add((string)allpresent[2]);
         
           listView2.Items.Add(item);*/
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void 订单_Load(object sender, EventArgs e)
        {

        }
    }
}

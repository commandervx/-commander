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
    public partial class 深圳 : Form
    {
        string pathPresent = "./Present.txt";
        ArrayList allPresent = new ArrayList();
        public 深圳()
        {
            InitializeComponent();
            ListViewPrsent_Load();
        }

        private void ListViewPrsent_Load()
        {
            allPresent = OperateFile.readFromFile(pathPresent);
            Present temp_present = null;
            for (int i = 0; i < allPresent.Count; i++)
            {
                temp_present = (Present)allPresent[i];


                if (temp_present.getCity() == "深圳")
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = temp_present.getId();
                    item.SubItems.Add(temp_present.getName());
                    item.SubItems.Add(temp_present.getSex());
                    item.SubItems.Add(temp_present.getType());
                    item.SubItems.Add(temp_present.getAddress());
                    listView1.Items.Add(item);

                }

              

            }
        }
        private void 深圳_Load(object sender, EventArgs e)
        {
            this.listView1.ListViewItemSorter = new tra.ListViewColumnSorter();
            this.listView1.ColumnClick += new ColumnClickEventHandler(tra.ListViewHelper.ListView_ColumnClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定离开？");
            登录 form = new 登录(); 
            form.Show();
            this.Hide();
        }

        private void 浏览_Click(object sender, EventArgs e)
        {
            浏览 form = new 浏览();
            form.id.Text = listView1.CheckedItems[0].Text;
            form.name.Text = listView1.CheckedItems[0].SubItems[1].Text;
            form.sex.Text = listView1.CheckedItems[0].SubItems[2].Text;
            form.type.Text = listView1.CheckedItems[0].SubItems[3].Text;
            form.address.Text = listView1.CheckedItems[0].SubItems[4].Text;
            form.Show();
        }

        private void 选好了_Click(object sender, EventArgs e)
        {

            if (listView1.CheckedItems.Count != 0)
            {

                交易 form = new 交易();
                form.id.Text = listView1.CheckedItems[0].Text;
                form.name.Text = listView1.CheckedItems[0].SubItems[1].Text;
                form.sex.Text = listView1.CheckedItems[0].SubItems[2].Text;
                form.type.Text = listView1.CheckedItems[0].SubItems[3].Text;
                form.address.Text = listView1.CheckedItems[0].SubItems[4].Text;

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("选好了吗");
                return;
            }
        }
    }
}

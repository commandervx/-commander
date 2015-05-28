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
    public partial class 系统界面 : Form
    {

        ArrayList allpresent = new ArrayList();
        string presentpath = "./Present.txt";

        public 系统界面()
        {
            InitializeComponent();

            allpresent = OperateFile.readFromFile(presentpath);
            Present temp_present = null;
            for (int i = 0; i < allpresent.Count; i++)
            {
                temp_present =(Present)allpresent[i];
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = temp_present.getId();
                item.SubItems.Add(temp_present.getName());
                item.SubItems.Add(temp_present.getSex());
                item.SubItems.Add(temp_present.getCity());
                item.SubItems.Add(temp_present.getType());
                item.SubItems.Add(temp_present.getAddress());
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            登录 form = new 登录();
            form.Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            增加  changform1 = new 增加();
            changform1.setParentForm(this);
            changform1.Show();
        }


        private void 系统界面_Load(object sender, EventArgs e)
        {
            this.listView1.ListViewItemSorter = new tra.ListViewColumnSorter();
            this.listView1.ColumnClick += new ColumnClickEventHandler(tra.ListViewHelper.ListView_ColumnClick);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count != 0)
            {
                allpresent.Clear();
                Present temp_present = null;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    temp_present = new Present(listView1.Items[i].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text, listView1.Items[i].SubItems[3].Text, listView1.Items[i].SubItems[4].Text, listView1.Items[i].SubItems[5].Text);
                    allpresent.Add(temp_present);

                }
                OperateFile.writeToFile(allpresent, presentpath);
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("无数据！");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("没有选择要删除的数据");

            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("确定删除所选数据？", "警告", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem tempItem in listView1.Items)//循环遍历listView控件中的每一项
                    {
                        if (tempItem.Checked == true)//如果当前项处于选中状态
                        {
                            tempItem.Remove();//删除当前项

                        }
                    }

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (listView1.CheckedItems.Count==1 )
            {
                
                增加 change = new 增加();
                change.id.Text = listView1.CheckedItems[0].Text;
                change.name.Text = listView1.CheckedItems[0].SubItems[1].Text;
                change.sex.Text = listView1.CheckedItems[0].SubItems[2].Text;
                change.city.Text = listView1.CheckedItems[0].SubItems[3].Text;
                change.type.Text = listView1.CheckedItems[0].SubItems[4].Text;
                change.address.Text = listView1.CheckedItems[0].SubItems[5].Text;
                listView1.CheckedItems[0].Remove();

                change.setParentForm(this);
                change .Show();
               
            }
            else
            {
                MessageBox.Show("请选择要修改的信息");
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            订单 form = new 订单();
            form.Show();

        }
    }
}

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
 
    public partial class 交易 : Form
    {
        
        ArrayList allpresent = new ArrayList();
        string presentpath = "./Present.txt";
        string orderpath = "./order.txt";
        public 交易()
        {
            InitializeComponent();
        }

        private void 交易_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            登录 form = new 登录();
            form.Show();
            this.Hide();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void 住房确认_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*allpresent = OperateFile.readFromFile(presentpath);
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
            }*/
            /*ArrayList all = new ArrayList();
            all[0] = textBox1.Text;
            all[1] = textBox2.Text;
            all[2] = textBox3.Text;

            OperateFile.writeToFile(all, orderpath);*/
            if (textBoxID != null)
            {


                系统界面 form = new 系统界面();


                foreach (ListViewItem tempItem in form.listView1.Items)//循环遍历listView控件中的每一项
                {
                    if (tempItem.Text == textBoxID.Text)//如果当前项处于选中状态
                    {
                        tempItem.Remove();//删除当前项

                    }
                }
                allpresent.Clear();
                Present temp_present = null;
                for (int i = 0; i < form.listView1.Items.Count; i++)
                {
                    temp_present = new Present(form.listView1.Items[i].Text, form.listView1.Items[i].SubItems[1].Text, form.listView1.Items[i].SubItems[2].Text, form.listView1.Items[i].SubItems[3].Text, form.listView1.Items[i].SubItems[4].Text, form.listView1.Items[i].SubItems[5].Text);
                    allpresent.Add(temp_present);

                }
                OperateFile.writeToFile(allpresent, presentpath);
                MessageBox.Show("预约成功!");
            }
            else
            {
                MessageBox.Show("请选择序号");
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

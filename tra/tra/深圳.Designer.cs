namespace tra
{
    partial class 深圳
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(深圳));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.序号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.房主姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.性别 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.住房类型 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.地址 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.浏览 = new System.Windows.Forms.Button();
            this.选好了 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "如下推荐：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(406, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "不满意";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.序号,
            this.房主姓名,
            this.性别,
            this.住房类型,
            this.地址});
            this.listView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(32, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 168);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 序号
            // 
            this.序号.Text = "序号";
            this.序号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 房主姓名
            // 
            this.房主姓名.Text = "房主姓名";
            this.房主姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.房主姓名.Width = 80;
            // 
            // 性别
            // 
            this.性别.Text = "性别";
            this.性别.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.性别.Width = 40;
            // 
            // 住房类型
            // 
            this.住房类型.Text = "住房类型";
            this.住房类型.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.住房类型.Width = 80;
            // 
            // 地址
            // 
            this.地址.Text = "地址";
            this.地址.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.地址.Width = 200;
            // 
            // 浏览
            // 
            this.浏览.BackColor = System.Drawing.Color.MintCream;
            this.浏览.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.浏览.ForeColor = System.Drawing.Color.Black;
            this.浏览.Location = new System.Drawing.Point(250, 271);
            this.浏览.Name = "浏览";
            this.浏览.Size = new System.Drawing.Size(57, 23);
            this.浏览.TabIndex = 9;
            this.浏览.Text = "浏览";
            this.浏览.UseVisualStyleBackColor = false;
            this.浏览.Click += new System.EventHandler(this.浏览_Click);
            // 
            // 选好了
            // 
            this.选好了.BackColor = System.Drawing.Color.MintCream;
            this.选好了.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.选好了.ForeColor = System.Drawing.Color.Black;
            this.选好了.Location = new System.Drawing.Point(92, 271);
            this.选好了.Name = "选好了";
            this.选好了.Size = new System.Drawing.Size(57, 23);
            this.选好了.TabIndex = 10;
            this.选好了.Text = "选好了";
            this.选好了.UseVisualStyleBackColor = false;
            this.选好了.Click += new System.EventHandler(this.选好了_Click);
            // 
            // 深圳
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 338);
            this.Controls.Add(this.选好了);
            this.Controls.Add(this.浏览);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "深圳";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "深圳";
            this.Load += new System.EventHandler(this.深圳_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 序号;
        private System.Windows.Forms.ColumnHeader 房主姓名;
        private System.Windows.Forms.ColumnHeader 性别;
        private System.Windows.Forms.ColumnHeader 住房类型;
        private System.Windows.Forms.ColumnHeader 地址;
        private System.Windows.Forms.Button 浏览;
        private System.Windows.Forms.Button 选好了;
    }
}
namespace Code_group3
{
    partial class AlarmHandler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAlarmActive = new System.Windows.Forms.Button();
            this.btnAlarmDeactive = new System.Windows.Forms.Button();
            this.dgvAlarmActive = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAlarmId = new System.Windows.Forms.ComboBox();
            this.picBoxDeactive = new System.Windows.Forms.PictureBox();
            this.picBoxActive = new System.Windows.Forms.PictureBox();
            this.AlarmList = new System.Windows.Forms.GroupBox();
            this.dgvKvittert = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimerAlarmACtive = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmActive)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxActive)).BeginInit();
            this.AlarmList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvittert)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlarmActive
            // 
            this.btnAlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmActive.Location = new System.Drawing.Point(32, 163);
            this.btnAlarmActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlarmActive.Name = "btnAlarmActive";
            this.btnAlarmActive.Size = new System.Drawing.Size(164, 43);
            this.btnAlarmActive.TabIndex = 0;
            this.btnAlarmActive.Text = "Away (Active)";
            this.btnAlarmActive.UseVisualStyleBackColor = true;
            this.btnAlarmActive.Click += new System.EventHandler(this.btnAlarmActive_Click);
            // 
            // btnAlarmDeactive
            // 
            this.btnAlarmDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmDeactive.Location = new System.Drawing.Point(32, 244);
            this.btnAlarmDeactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlarmDeactive.Name = "btnAlarmDeactive";
            this.btnAlarmDeactive.Size = new System.Drawing.Size(164, 43);
            this.btnAlarmDeactive.TabIndex = 1;
            this.btnAlarmDeactive.Text = "Home (Deactive)";
            this.btnAlarmDeactive.UseVisualStyleBackColor = true;
            this.btnAlarmDeactive.Click += new System.EventHandler(this.btnAlarmDeactive_Click);
            // 
            // dgvAlarmActive
            // 
            this.dgvAlarmActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmActive.GridColor = System.Drawing.Color.Black;
            this.dgvAlarmActive.Location = new System.Drawing.Point(92, 46);
            this.dgvAlarmActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlarmActive.Name = "dgvAlarmActive";
            this.dgvAlarmActive.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvAlarmActive.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlarmActive.RowTemplate.Height = 24;
            this.dgvAlarmActive.Size = new System.Drawing.Size(797, 222);
            this.dgvAlarmActive.TabIndex = 2;
            this.dgvAlarmActive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmActive_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 25);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.cboAlarmId);
            this.panel1.Controls.Add(this.picBoxDeactive);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picBoxActive);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAlarmActive);
            this.panel1.Controls.Add(this.btnAlarmDeactive);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 697);
            this.panel1.TabIndex = 7;
            // 
            // cboAlarmId
            // 
            this.cboAlarmId.FormattingEnabled = true;
            this.cboAlarmId.Location = new System.Drawing.Point(49, 324);
            this.cboAlarmId.Name = "cboAlarmId";
            this.cboAlarmId.Size = new System.Drawing.Size(121, 24);
            this.cboAlarmId.TabIndex = 10;
            // 
            // picBoxDeactive
            // 
            this.picBoxDeactive.Image = global::Code_group3.Properties.Resources._checked;
            this.picBoxDeactive.Location = new System.Drawing.Point(203, 244);
            this.picBoxDeactive.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxDeactive.Name = "picBoxDeactive";
            this.picBoxDeactive.Size = new System.Drawing.Size(57, 43);
            this.picBoxDeactive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDeactive.TabIndex = 9;
            this.picBoxDeactive.TabStop = false;
            this.picBoxDeactive.Visible = false;
            // 
            // picBoxActive
            // 
            this.picBoxActive.Image = global::Code_group3.Properties.Resources.circle_button;
            this.picBoxActive.Location = new System.Drawing.Point(203, 163);
            this.picBoxActive.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxActive.Name = "picBoxActive";
            this.picBoxActive.Size = new System.Drawing.Size(57, 43);
            this.picBoxActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxActive.TabIndex = 9;
            this.picBoxActive.TabStop = false;
            this.picBoxActive.Visible = false;
            // 
            // AlarmList
            // 
            this.AlarmList.Controls.Add(this.dgvAlarmActive);
            this.AlarmList.Location = new System.Drawing.Point(291, 40);
            this.AlarmList.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Padding = new System.Windows.Forms.Padding(4);
            this.AlarmList.Size = new System.Drawing.Size(946, 295);
            this.AlarmList.TabIndex = 8;
            this.AlarmList.TabStop = false;
            this.AlarmList.Text = "Alarm List";
            // 
            // dgvKvittert
            // 
            this.dgvKvittert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKvittert.Location = new System.Drawing.Point(92, 41);
            this.dgvKvittert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKvittert.Name = "dgvKvittert";
            this.dgvKvittert.RowHeadersWidth = 51;
            this.dgvKvittert.RowTemplate.Height = 24;
            this.dgvKvittert.Size = new System.Drawing.Size(797, 222);
            this.dgvKvittert.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKvittert);
            this.groupBox1.Location = new System.Drawing.Point(291, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 311);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acknowledged Alarms";
            // 
            // TimerAlarmACtive
            // 
            this.TimerAlarmACtive.Interval = 1000;
            this.TimerAlarmACtive.Tick += new System.EventHandler(this.TimerAlarmACtive_Tick);
            // 
            // AlarmHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlarmList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlarmHandler";
            this.Text = "AlarmHandler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmActive)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxActive)).EndInit();
            this.AlarmList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvittert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmActive;
        private System.Windows.Forms.Button btnAlarmDeactive;
        private System.Windows.Forms.DataGridView dgvAlarmActive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox AlarmList;
        private System.Windows.Forms.PictureBox picBoxActive;
        private System.Windows.Forms.PictureBox picBoxDeactive;
        private System.Windows.Forms.DataGridView dgvKvittert;
        private System.Windows.Forms.ComboBox cboAlarmId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer TimerAlarmACtive;
    }
}
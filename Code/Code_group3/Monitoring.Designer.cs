namespace Code_group3
{
    partial class Monitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.btnLightOn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.btnLightOff = new System.Windows.Forms.Button();
            this.TimerMonitorActiveAlarm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(479, 115);
            this.dgvM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            this.dgvM.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvM.RowTemplate.Height = 24;
            this.dgvM.Size = new System.Drawing.Size(694, 292);
            this.dgvM.TabIndex = 0;
            this.dgvM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvM_CellContentClick);
            // 
            // btnLightOn
            // 
            this.btnLightOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOn.Location = new System.Drawing.Point(13, 115);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(144, 73);
            this.btnLightOn.TabIndex = 8;
            this.btnLightOn.Text = "Light On";
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(13, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Active Alarms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pbLight);
            this.panel1.Controls.Add(this.btnLightOn);
            this.panel1.Controls.Add(this.btnLightOff);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 702);
            this.panel1.TabIndex = 11;
            // 
            // pbLight
            // 
            this.pbLight.Image = global::Code_group3.Properties.Resources.LightPNG;
            this.pbLight.Location = new System.Drawing.Point(128, 223);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(116, 108);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 11;
            this.pbLight.TabStop = false;
            this.pbLight.Visible = false;
            // 
            // btnLightOff
            // 
            this.btnLightOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOff.Location = new System.Drawing.Point(210, 117);
            this.btnLightOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(144, 71);
            this.btnLightOff.TabIndex = 10;
            this.btnLightOff.Text = "Light Off";
            this.btnLightOff.UseVisualStyleBackColor = true;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // TimerMonitorActiveAlarm
            // 
            this.TimerMonitorActiveAlarm.Tick += new System.EventHandler(this.TimerMonitorActiveAlarm_Tick);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLightOff;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Timer TimerMonitorActiveAlarm;
    }
}
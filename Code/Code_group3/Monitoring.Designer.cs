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
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.txtHeatStatus = new System.Windows.Forms.TextBox();
            this.txtCoolingStatus = new System.Windows.Forms.TextBox();
            this.txtProcessValue = new System.Windows.Forms.TextBox();
            this.txtSetTempValue = new System.Windows.Forms.TextBox();
            this.btnLightManual = new System.Windows.Forms.Button();
            this.btnLightAuto = new System.Windows.Forms.Button();
            this.btnLightOn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLightOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(539, 144);
            this.dgvM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            this.dgvM.RowTemplate.Height = 24;
            this.dgvM.Size = new System.Drawing.Size(784, 390);
            this.dgvM.TabIndex = 0;
            // 
            // txtHeatStatus
            // 
            this.txtHeatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeatStatus.Location = new System.Drawing.Point(15, 56);
            this.txtHeatStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeatStatus.Name = "txtHeatStatus";
            this.txtHeatStatus.Size = new System.Drawing.Size(162, 31);
            this.txtHeatStatus.TabIndex = 2;
            this.txtHeatStatus.Text = "Heat Status";
            // 
            // txtCoolingStatus
            // 
            this.txtCoolingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoolingStatus.Location = new System.Drawing.Point(214, 56);
            this.txtCoolingStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoolingStatus.Name = "txtCoolingStatus";
            this.txtCoolingStatus.Size = new System.Drawing.Size(162, 31);
            this.txtCoolingStatus.TabIndex = 3;
            this.txtCoolingStatus.Text = "Cooling Status";
            // 
            // txtProcessValue
            // 
            this.txtProcessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessValue.Location = new System.Drawing.Point(214, 155);
            this.txtProcessValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessValue.Name = "txtProcessValue";
            this.txtProcessValue.Size = new System.Drawing.Size(162, 31);
            this.txtProcessValue.TabIndex = 4;
            this.txtProcessValue.Text = "Process Value";
            // 
            // txtSetTempValue
            // 
            this.txtSetTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetTempValue.Location = new System.Drawing.Point(15, 155);
            this.txtSetTempValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetTempValue.Name = "txtSetTempValue";
            this.txtSetTempValue.Size = new System.Drawing.Size(162, 31);
            this.txtSetTempValue.TabIndex = 5;
            this.txtSetTempValue.Text = "Set Temp Value";
            // 
            // btnLightManual
            // 
            this.btnLightManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightManual.Location = new System.Drawing.Point(15, 240);
            this.btnLightManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightManual.Name = "btnLightManual";
            this.btnLightManual.Size = new System.Drawing.Size(162, 38);
            this.btnLightManual.TabIndex = 6;
            this.btnLightManual.Text = "Light Manual";
            this.btnLightManual.UseVisualStyleBackColor = true;
            // 
            // btnLightAuto
            // 
            this.btnLightAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightAuto.Location = new System.Drawing.Point(214, 240);
            this.btnLightAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightAuto.Name = "btnLightAuto";
            this.btnLightAuto.Size = new System.Drawing.Size(162, 38);
            this.btnLightAuto.TabIndex = 7;
            this.btnLightAuto.Text = "Light Auto";
            this.btnLightAuto.UseVisualStyleBackColor = true;
            // 
            // btnLightOn
            // 
            this.btnLightOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOn.Location = new System.Drawing.Point(115, 341);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(162, 38);
            this.btnLightOn.TabIndex = 8;
            this.btnLightOn.Text = "Light On";
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(15, 804);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 29);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temperature logger";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLightOff);
            this.panel1.Controls.Add(this.txtHeatStatus);
            this.panel1.Controls.Add(this.txtCoolingStatus);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.txtSetTempValue);
            this.panel1.Controls.Add(this.btnLightOn);
            this.panel1.Controls.Add(this.txtProcessValue);
            this.panel1.Controls.Add(this.btnLightAuto);
            this.panel1.Controls.Add(this.btnLightManual);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 878);
            this.panel1.TabIndex = 11;
            // 
            // btnLightOff
            // 
            this.btnLightOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOff.Location = new System.Drawing.Point(115, 399);
            this.btnLightOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(162, 38);
            this.btnLightOff.TabIndex = 10;
            this.btnLightOff.Text = "Light Off";
            this.btnLightOff.UseVisualStyleBackColor = true;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.TextBox txtHeatStatus;
        private System.Windows.Forms.TextBox txtCoolingStatus;
        private System.Windows.Forms.TextBox txtProcessValue;
        private System.Windows.Forms.TextBox txtSetTempValue;
        private System.Windows.Forms.Button btnLightManual;
        private System.Windows.Forms.Button btnLightAuto;
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLightOff;
    }
}
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
            this.btnOffOn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(479, 115);
            this.dgvM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            this.dgvM.RowTemplate.Height = 24;
            this.dgvM.Size = new System.Drawing.Size(697, 312);
            this.dgvM.TabIndex = 0;
            // 
            // txtHeatStatus
            // 
            this.txtHeatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeatStatus.Location = new System.Drawing.Point(13, 45);
            this.txtHeatStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeatStatus.Name = "txtHeatStatus";
            this.txtHeatStatus.Size = new System.Drawing.Size(144, 27);
            this.txtHeatStatus.TabIndex = 2;
            this.txtHeatStatus.Text = "Heat Status";
            // 
            // txtCoolingStatus
            // 
            this.txtCoolingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoolingStatus.Location = new System.Drawing.Point(190, 45);
            this.txtCoolingStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoolingStatus.Name = "txtCoolingStatus";
            this.txtCoolingStatus.Size = new System.Drawing.Size(144, 27);
            this.txtCoolingStatus.TabIndex = 3;
            this.txtCoolingStatus.Text = "Cooling Status";
            // 
            // txtProcessValue
            // 
            this.txtProcessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessValue.Location = new System.Drawing.Point(190, 124);
            this.txtProcessValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessValue.Name = "txtProcessValue";
            this.txtProcessValue.Size = new System.Drawing.Size(144, 27);
            this.txtProcessValue.TabIndex = 4;
            this.txtProcessValue.Text = "Process Value";
            // 
            // txtSetTempValue
            // 
            this.txtSetTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetTempValue.Location = new System.Drawing.Point(13, 124);
            this.txtSetTempValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetTempValue.Name = "txtSetTempValue";
            this.txtSetTempValue.Size = new System.Drawing.Size(144, 27);
            this.txtSetTempValue.TabIndex = 5;
            this.txtSetTempValue.Text = "Set Temp Value";
            // 
            // btnLightManual
            // 
            this.btnLightManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightManual.Location = new System.Drawing.Point(13, 192);
            this.btnLightManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightManual.Name = "btnLightManual";
            this.btnLightManual.Size = new System.Drawing.Size(144, 30);
            this.btnLightManual.TabIndex = 6;
            this.btnLightManual.Text = "Light Manual";
            this.btnLightManual.UseVisualStyleBackColor = true;
            // 
            // btnLightAuto
            // 
            this.btnLightAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightAuto.Location = new System.Drawing.Point(190, 192);
            this.btnLightAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLightAuto.Name = "btnLightAuto";
            this.btnLightAuto.Size = new System.Drawing.Size(144, 30);
            this.btnLightAuto.TabIndex = 7;
            this.btnLightAuto.Text = "Light Auto";
            this.btnLightAuto.UseVisualStyleBackColor = true;
            // 
            // btnOffOn
            // 
            this.btnOffOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffOn.Location = new System.Drawing.Point(102, 273);
            this.btnOffOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOffOn.Name = "btnOffOn";
            this.btnOffOn.Size = new System.Drawing.Size(133, 30);
            this.btnOffOn.TabIndex = 8;
            this.btnOffOn.Text = "Light Off/On";
            this.btnOffOn.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(13, 643);
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
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temperature logger";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtHeatStatus);
            this.panel1.Controls.Add(this.txtCoolingStatus);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.txtSetTempValue);
            this.panel1.Controls.Add(this.btnOffOn);
            this.panel1.Controls.Add(this.txtProcessValue);
            this.panel1.Controls.Add(this.btnLightAuto);
            this.panel1.Controls.Add(this.btnLightManual);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 702);
            this.panel1.TabIndex = 11;
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
        private System.Windows.Forms.Button btnOffOn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
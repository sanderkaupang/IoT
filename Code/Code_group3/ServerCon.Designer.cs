namespace Code_group3
{
    partial class ServerCon
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
            this.dgvtables = new System.Windows.Forms.DataGridView();
            this.btnCheckTables = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtables
            // 
            this.dgvtables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtables.Location = new System.Drawing.Point(327, 91);
            this.dgvtables.Name = "dgvtables";
            this.dgvtables.RowHeadersWidth = 51;
            this.dgvtables.RowTemplate.Height = 24;
            this.dgvtables.Size = new System.Drawing.Size(591, 333);
            this.dgvtables.TabIndex = 0;
            // 
            // btnCheckTables
            // 
            this.btnCheckTables.Location = new System.Drawing.Point(42, 32);
            this.btnCheckTables.Name = "btnCheckTables";
            this.btnCheckTables.Size = new System.Drawing.Size(124, 40);
            this.btnCheckTables.TabIndex = 1;
            this.btnCheckTables.Text = "CheckTables";
            this.btnCheckTables.UseVisualStyleBackColor = true;
            this.btnCheckTables.Click += new System.EventHandler(this.btnCheckTables_Click);
            // 
            // ServerCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 663);
            this.Controls.Add(this.btnCheckTables);
            this.Controls.Add(this.dgvtables);
            this.Name = "ServerCon";
            this.Text = "ServerCon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtables;
        private System.Windows.Forms.Button btnCheckTables;
    }
}
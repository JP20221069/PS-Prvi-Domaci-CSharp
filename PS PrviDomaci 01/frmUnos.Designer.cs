namespace PS_PrviDomaci_01
{
    partial class frmUnos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajRed = new System.Windows.Forms.Button();
            this.btnObrisiRed = new System.Windows.Forms.Button();
            this.btnSinhronizuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrikaz);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz";
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrikaz.Location = new System.Drawing.Point(3, 16);
            this.dgvPrikaz.MultiSelect = false;
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.Size = new System.Drawing.Size(794, 306);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPrikaz_CellBeginEdit);
            this.dgvPrikaz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikaz_CellEndEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajRed);
            this.groupBox2.Controls.Add(this.btnObrisiRed);
            this.groupBox2.Controls.Add(this.btnSinhronizuj);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unos i izmena";
            // 
            // btnDodajRed
            // 
            this.btnDodajRed.Location = new System.Drawing.Point(174, 28);
            this.btnDodajRed.Name = "btnDodajRed";
            this.btnDodajRed.Size = new System.Drawing.Size(75, 53);
            this.btnDodajRed.TabIndex = 2;
            this.btnDodajRed.Text = "Dodaj red";
            this.btnDodajRed.UseVisualStyleBackColor = true;
            this.btnDodajRed.Click += new System.EventHandler(this.btnDodajred_Click);
            // 
            // btnObrisiRed
            // 
            this.btnObrisiRed.Location = new System.Drawing.Point(93, 28);
            this.btnObrisiRed.Name = "btnObrisiRed";
            this.btnObrisiRed.Size = new System.Drawing.Size(75, 53);
            this.btnObrisiRed.TabIndex = 1;
            this.btnObrisiRed.Text = "Obriši red";
            this.btnObrisiRed.UseVisualStyleBackColor = true;
            this.btnObrisiRed.Click += new System.EventHandler(this.btnObrisiRed_Click);
            // 
            // btnSinhronizuj
            // 
            this.btnSinhronizuj.Location = new System.Drawing.Point(12, 28);
            this.btnSinhronizuj.Name = "btnSinhronizuj";
            this.btnSinhronizuj.Size = new System.Drawing.Size(75, 53);
            this.btnSinhronizuj.TabIndex = 0;
            this.btnSinhronizuj.Text = "Sinhronizuj tabelu";
            this.btnSinhronizuj.UseVisualStyleBackColor = true;
            this.btnSinhronizuj.Click += new System.EventHandler(this.btnSinhronizuj_Click);
            // 
            // frmUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUnos";
            this.Text = "Unos i izmena";
            this.Load += new System.EventHandler(this.frmUnos_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajRed;
        private System.Windows.Forms.Button btnObrisiRed;
        private System.Windows.Forms.Button btnSinhronizuj;
        private System.Windows.Forms.DataGridView dgvPrikaz;
    }
}
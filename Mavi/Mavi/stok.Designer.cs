namespace Mavi
{
    partial class stok
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
            this.btnklit = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnklit
            // 
            this.btnklit.BackColor = System.Drawing.Color.Transparent;
            this.btnklit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnklit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnklit.FlatAppearance.BorderSize = 0;
            this.btnklit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnklit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnklit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnklit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnklit.ForeColor = System.Drawing.Color.White;
            this.btnklit.Image = global::Mavi.Properties.Resources.iconfinder_ic_lock_outline_48px_352525;
            this.btnklit.Location = new System.Drawing.Point(646, 389);
            this.btnklit.Name = "btnklit";
            this.btnklit.Size = new System.Drawing.Size(67, 60);
            this.btnklit.TabIndex = 47;
            this.btnklit.UseVisualStyleBackColor = false;
            this.btnklit.Click += new System.EventHandler(this.btnklit_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.White;
            this.btncikis.Image = global::Mavi.Properties.Resources._1564506_64;
            this.btncikis.Location = new System.Drawing.Point(719, 389);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(79, 60);
            this.btncikis.TabIndex = 46;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(658, 2);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(67, 33);
            this.btnmin.TabIndex = 45;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(731, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(67, 33);
            this.btnclose.TabIndex = 44;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(329, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 285);
            this.dataGridView1.TabIndex = 48;
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(159, 202);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(137, 20);
            this.txturunad.TabIndex = 49;
            this.txturunad.TextChanged += new System.EventHandler(this.txturunad_TextChanged);
            // 
            // combotur
            // 
            this.combotur.FormattingEnabled = true;
            this.combotur.Location = new System.Drawing.Point(159, 161);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(137, 21);
            this.combotur.TabIndex = 50;
            this.combotur.SelectedIndexChanged += new System.EventHandler(this.combotur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ürün Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ürün Adı";
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mavi.Properties.Resources.dark_cyan_texture_printed_old_master_backdrop_for_photography_j_0711_1024x1024;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combotur);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnklit);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "stok";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnklit;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
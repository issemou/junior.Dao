
namespace JuniorWinform.FrmProduct
{
    partial class FrmProductEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_dp = new System.Windows.Forms.Label();
            this.dtpdp = new System.Windows.Forms.DateTimePicker();
            this.lb_px = new System.Windows.Forms.Label();
            this.txt_px = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lb_ref = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.lb_de = new System.Windows.Forms.Label();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(468, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_dp
            // 
            this.lb_dp.AutoSize = true;
            this.lb_dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dp.Location = new System.Drawing.Point(27, 217);
            this.lb_dp.Name = "lb_dp";
            this.lb_dp.Size = new System.Drawing.Size(124, 20);
            this.lb_dp.TabIndex = 17;
            this.lb_dp.Text = "Date Production";
            // 
            // dtpdp
            // 
            this.dtpdp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdp.Location = new System.Drawing.Point(31, 240);
            this.dtpdp.Name = "dtpdp";
            this.dtpdp.Size = new System.Drawing.Size(256, 20);
            this.dtpdp.TabIndex = 12;
            // 
            // lb_px
            // 
            this.lb_px.AutoSize = true;
            this.lb_px.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_px.Location = new System.Drawing.Point(27, 151);
            this.lb_px.Name = "lb_px";
            this.lb_px.Size = new System.Drawing.Size(93, 20);
            this.lb_px.TabIndex = 16;
            this.lb_px.Text = "Prix Unitaire";
            // 
            // txt_px
            // 
            this.txt_px.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_px.Location = new System.Drawing.Point(31, 173);
            this.txt_px.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_px.Name = "txt_px";
            this.txt_px.Size = new System.Drawing.Size(256, 20);
            this.txt_px.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.ForeColor = System.Drawing.Color.Green;
            this.BtnSave.Location = new System.Drawing.Point(468, 375);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(242, 40);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lb_ref
            // 
            this.lb_ref.AutoSize = true;
            this.lb_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ref.Location = new System.Drawing.Point(27, 26);
            this.lb_ref.Name = "lb_ref";
            this.lb_ref.Size = new System.Drawing.Size(84, 20);
            this.lb_ref.TabIndex = 13;
            this.lb_ref.Text = "Reference";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(40, 375);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(256, 40);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // txt_ref
            // 
            this.txt_ref.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ref.Location = new System.Drawing.Point(31, 48);
            this.txt_ref.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(256, 20);
            this.txt_ref.TabIndex = 10;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_des.Location = new System.Drawing.Point(27, 86);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(94, 20);
            this.lb_des.TabIndex = 21;
            this.lb_des.Text = "Designation";
            // 
            // txt_des
            // 
            this.txt_des.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_des.Location = new System.Drawing.Point(31, 108);
            this.txt_des.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(256, 20);
            this.txt_des.TabIndex = 20;
            // 
            // lb_de
            // 
            this.lb_de.AutoSize = true;
            this.lb_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_de.Location = new System.Drawing.Point(27, 281);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(118, 20);
            this.lb_de.TabIndex = 23;
            this.lb_de.Text = "Date Expiration";
            // 
            // dtp_de
            // 
            this.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_de.Location = new System.Drawing.Point(31, 304);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(256, 20);
            this.dtp_de.TabIndex = 22;
            // 
            // FrmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_de);
            this.Controls.Add(this.dtp_de);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_dp);
            this.Controls.Add(this.dtpdp);
            this.Controls.Add(this.lb_px);
            this.Controls.Add(this.txt_px);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lb_ref);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txt_ref);
            this.Name = "FrmProductEdit";
            this.Text = "FrmProductEdit";
            this.Load += new System.EventHandler(this.FrmProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_dp;
        private System.Windows.Forms.DateTimePicker dtpdp;
        private System.Windows.Forms.Label lb_px;
        private System.Windows.Forms.TextBox txt_px;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lb_ref;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label lb_de;
        private System.Windows.Forms.DateTimePicker dtp_de;
    }
}
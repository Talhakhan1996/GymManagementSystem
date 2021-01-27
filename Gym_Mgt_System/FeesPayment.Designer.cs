namespace Gym_Mgt_System
{
    partial class FeesPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeesPayment));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_fees = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_feesdesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dteTmePckr_feedate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_viewpayments = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBx_packagetype = new System.Windows.Forms.ComboBox();
            this.cmbBx_packagename = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBx_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(210, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(362, 48);
            this.label12.TabIndex = 30;
            this.label12.Text = "Diamond Gym and Fitness Club";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(304, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 62);
            this.label11.TabIndex = 29;
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbx_fees
            // 
            this.txtbx_fees.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fees.Location = new System.Drawing.Point(152, 181);
            this.txtbx_fees.Mask = "000/=PKR";
            this.txtbx_fees.Name = "txtbx_fees";
            this.txtbx_fees.Size = new System.Drawing.Size(166, 22);
            this.txtbx_fees.TabIndex = 52;
            this.txtbx_fees.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbx_fees_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 38);
            this.label5.TabIndex = 51;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbx_feesdesc
            // 
            this.txtbx_feesdesc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_feesdesc.Location = new System.Drawing.Point(152, 224);
            this.txtbx_feesdesc.Name = "txtbx_feesdesc";
            this.txtbx_feesdesc.Size = new System.Drawing.Size(166, 88);
            this.txtbx_feesdesc.TabIndex = 54;
            this.txtbx_feesdesc.Text = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(18, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 40);
            this.label6.TabIndex = 53;
            this.label6.Text = "Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dteTmePckr_feedate
            // 
            this.dteTmePckr_feedate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTmePckr_feedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTmePckr_feedate.Location = new System.Drawing.Point(152, 336);
            this.dteTmePckr_feedate.Name = "dteTmePckr_feedate";
            this.dteTmePckr_feedate.Size = new System.Drawing.Size(166, 22);
            this.dteTmePckr_feedate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(21, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 40);
            this.label4.TabIndex = 55;
            this.label4.Text = "Payment Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(110, 473);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(71, 36);
            this.btn_reset.TabIndex = 58;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(26, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 36);
            this.btn_save.TabIndex = 57;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_viewpayments
            // 
            this.btn_viewpayments.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewpayments.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewpayments.Image")));
            this.btn_viewpayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewpayments.Location = new System.Drawing.Point(198, 473);
            this.btn_viewpayments.Name = "btn_viewpayments";
            this.btn_viewpayments.Size = new System.Drawing.Size(124, 36);
            this.btn_viewpayments.TabIndex = 59;
            this.btn_viewpayments.Text = "View Payments";
            this.btn_viewpayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewpayments.UseVisualStyleBackColor = true;
            this.btn_viewpayments.Click += new System.EventHandler(this.btn_viewpayments_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(23, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Package Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBx_packagetype
            // 
            this.cmbBx_packagetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_packagetype.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_packagetype.FormattingEnabled = true;
            this.cmbBx_packagetype.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Expert"});
            this.cmbBx_packagetype.Location = new System.Drawing.Point(152, 423);
            this.cmbBx_packagetype.Name = "cmbBx_packagetype";
            this.cmbBx_packagetype.Size = new System.Drawing.Size(166, 23);
            this.cmbBx_packagetype.TabIndex = 61;
            // 
            // cmbBx_packagename
            // 
            this.cmbBx_packagename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_packagename.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_packagename.FormattingEnabled = true;
            this.cmbBx_packagename.Items.AddRange(new object[] {
            "Standard",
            "Student"});
            this.cmbBx_packagename.Location = new System.Drawing.Point(152, 380);
            this.cmbBx_packagename.Name = "cmbBx_packagename";
            this.cmbBx_packagename.Size = new System.Drawing.Size(166, 23);
            this.cmbBx_packagename.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(23, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Package Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBx_name
            // 
            this.cmbBx_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbBx_name.FormattingEnabled = true;
            this.cmbBx_name.Location = new System.Drawing.Point(152, 139);
            this.cmbBx_name.Name = "cmbBx_name";
            this.cmbBx_name.Size = new System.Drawing.Size(166, 23);
            this.cmbBx_name.TabIndex = 64;
            // 
            // FeesPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Controls.Add(this.cmbBx_name);
            this.Controls.Add(this.cmbBx_packagename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBx_packagetype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewpayments);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dteTmePckr_feedate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_feesdesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_fees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeesPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeesPayment";
            this.Load += new System.EventHandler(this.FeesPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtbx_fees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtbx_feesdesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dteTmePckr_feedate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_viewpayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBx_packagetype;
        private System.Windows.Forms.ComboBox cmbBx_packagename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBx_name;
    }
}
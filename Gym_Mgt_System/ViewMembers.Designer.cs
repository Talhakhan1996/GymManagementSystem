namespace Gym_Mgt_System
{
    partial class ViewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gym_Mgt_SystemDataSet = new Gym_Mgt_System.Gym_Mgt_SystemDataSet();
            this.memberTableAdapter = new Gym_Mgt_System.Gym_Mgt_SystemDataSet2TableAdapters.MemberTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gym_Mgt_SystemDataSet2 = new Gym_Mgt_System.Gym_Mgt_SystemDataSet2();
            this.gymMgtSystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMgtSystemDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gym_Mgt_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Mgt_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMgtSystemDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMgtSystemDataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(305, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(362, 48);
            this.label12.TabIndex = 34;
            this.label12.Text = "Diamond Gym and Fitness Club";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(399, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 62);
            this.label11.TabIndex = 33;
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gym_Mgt_SystemDataSet
            // 
            this.gym_Mgt_SystemDataSet.DataSetName = "Gym_Mgt_SystemDataSet";
            this.gym_Mgt_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 345);
            this.dataGridView1.TabIndex = 35;
            // 
            // gym_Mgt_SystemDataSet2
            // 
            this.gym_Mgt_SystemDataSet2.DataSetName = "Gym_Mgt_SystemDataSet2";
            this.gym_Mgt_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymMgtSystemDataSet2BindingSource
            // 
            this.gymMgtSystemDataSet2BindingSource.DataSource = this.gym_Mgt_SystemDataSet2;
            this.gymMgtSystemDataSet2BindingSource.Position = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.gymMgtSystemDataSet2BindingSource;
            // 
            // gymMgtSystemDataSet2BindingSource1
            // 
            this.gymMgtSystemDataSet2BindingSource1.DataSource = this.gym_Mgt_SystemDataSet2;
            this.gymMgtSystemDataSet2BindingSource1.Position = 0;
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "ViewMembers";
            this.Text = "ViewMembers";
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gym_Mgt_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Mgt_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMgtSystemDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMgtSystemDataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Gym_Mgt_SystemDataSet gym_Mgt_SystemDataSet;
        private Gym_Mgt_SystemDataSet2TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gymMgtSystemDataSet2BindingSource1;
        private Gym_Mgt_SystemDataSet2 gym_Mgt_SystemDataSet2;
        private System.Windows.Forms.BindingSource gymMgtSystemDataSet2BindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}
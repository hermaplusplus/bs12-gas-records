namespace bs12_gas_records
{
    partial class Form1
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
            this.tabOutputs = new System.Windows.Forms.TabControl();
            this.tabPagePublic = new System.Windows.Forms.TabPage();
            this.tabPageMedical = new System.Windows.Forms.TabPage();
            this.tabPageEmployment = new System.Windows.Forms.TabPage();
            this.tabPageSecurity = new System.Windows.Forms.TabPage();
            this.tabOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOutputs
            // 
            this.tabOutputs.Controls.Add(this.tabPagePublic);
            this.tabOutputs.Controls.Add(this.tabPageMedical);
            this.tabOutputs.Controls.Add(this.tabPageEmployment);
            this.tabOutputs.Controls.Add(this.tabPageSecurity);
            this.tabOutputs.Location = new System.Drawing.Point(468, 12);
            this.tabOutputs.Name = "tabOutputs";
            this.tabOutputs.SelectedIndex = 0;
            this.tabOutputs.Size = new System.Drawing.Size(502, 529);
            this.tabOutputs.TabIndex = 0;
            // 
            // tabPagePublic
            // 
            this.tabPagePublic.Location = new System.Drawing.Point(4, 25);
            this.tabPagePublic.Name = "tabPagePublic";
            this.tabPagePublic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublic.Size = new System.Drawing.Size(494, 500);
            this.tabPagePublic.TabIndex = 0;
            this.tabPagePublic.Text = "Public";
            this.tabPagePublic.UseVisualStyleBackColor = true;
            // 
            // tabPageMedical
            // 
            this.tabPageMedical.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedical.Name = "tabPageMedical";
            this.tabPageMedical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedical.Size = new System.Drawing.Size(494, 500);
            this.tabPageMedical.TabIndex = 1;
            this.tabPageMedical.Text = "Medical";
            this.tabPageMedical.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployment
            // 
            this.tabPageEmployment.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployment.Name = "tabPageEmployment";
            this.tabPageEmployment.Size = new System.Drawing.Size(494, 500);
            this.tabPageEmployment.TabIndex = 2;
            this.tabPageEmployment.Text = "Employment";
            this.tabPageEmployment.UseVisualStyleBackColor = true;
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 25);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Size = new System.Drawing.Size(494, 500);
            this.tabPageSecurity.TabIndex = 3;
            this.tabPageSecurity.Text = "tabPageSecurity";
            this.tabPageSecurity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabOutputs);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Giant Armoured Serpentid Record Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOutputs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOutputs;
        private System.Windows.Forms.TabPage tabPagePublic;
        private System.Windows.Forms.TabPage tabPageMedical;
        private System.Windows.Forms.TabPage tabPageEmployment;
        private System.Windows.Forms.TabPage tabPageSecurity;
    }
}


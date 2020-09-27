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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabOutputs = new System.Windows.Forms.TabControl();
            this.tabPagePublic = new System.Windows.Forms.TabPage();
            this.rtxPublic = new System.Windows.Forms.RichTextBox();
            this.tabPageMedical = new System.Windows.Forms.TabPage();
            this.rtxMedical = new System.Windows.Forms.RichTextBox();
            this.tabPageEmployment = new System.Windows.Forms.TabPage();
            this.rtxEmployment = new System.Windows.Forms.RichTextBox();
            this.tabPageSecurity = new System.Windows.Forms.TabPage();
            this.rtxSecurity = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemplateUpdate = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.barProgress = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOccupation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrainingCentre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkPassed = new System.Windows.Forms.CheckBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listCourses = new System.Windows.Forms.ListBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtColouration = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.tabOutputs.SuspendLayout();
            this.tabPagePublic.SuspendLayout();
            this.tabPageMedical.SuspendLayout();
            this.tabPageEmployment.SuspendLayout();
            this.tabPageSecurity.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOutputs
            // 
            this.tabOutputs.Controls.Add(this.tabPagePublic);
            this.tabOutputs.Controls.Add(this.tabPageMedical);
            this.tabOutputs.Controls.Add(this.tabPageEmployment);
            this.tabOutputs.Controls.Add(this.tabPageSecurity);
            this.tabOutputs.Location = new System.Drawing.Point(468, 0);
            this.tabOutputs.Name = "tabOutputs";
            this.tabOutputs.SelectedIndex = 0;
            this.tabOutputs.Size = new System.Drawing.Size(516, 555);
            this.tabOutputs.TabIndex = 14;
            this.tabOutputs.SelectedIndexChanged += new System.EventHandler(this.tabOutputs_SelectedIndexChanged);
            // 
            // tabPagePublic
            // 
            this.tabPagePublic.Controls.Add(this.rtxPublic);
            this.tabPagePublic.Location = new System.Drawing.Point(4, 25);
            this.tabPagePublic.Name = "tabPagePublic";
            this.tabPagePublic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublic.Size = new System.Drawing.Size(508, 526);
            this.tabPagePublic.TabIndex = 0;
            this.tabPagePublic.Text = "Public";
            this.tabPagePublic.UseVisualStyleBackColor = true;
            // 
            // rtxPublic
            // 
            this.rtxPublic.BackColor = System.Drawing.SystemColors.Window;
            this.rtxPublic.DetectUrls = false;
            this.rtxPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxPublic.Location = new System.Drawing.Point(7, 7);
            this.rtxPublic.Name = "rtxPublic";
            this.rtxPublic.ReadOnly = true;
            this.rtxPublic.Size = new System.Drawing.Size(495, 513);
            this.rtxPublic.TabIndex = 15;
            this.rtxPublic.Text = "";
            // 
            // tabPageMedical
            // 
            this.tabPageMedical.Controls.Add(this.rtxMedical);
            this.tabPageMedical.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedical.Name = "tabPageMedical";
            this.tabPageMedical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedical.Size = new System.Drawing.Size(508, 526);
            this.tabPageMedical.TabIndex = 1;
            this.tabPageMedical.Text = "Medical";
            this.tabPageMedical.UseVisualStyleBackColor = true;
            // 
            // rtxMedical
            // 
            this.rtxMedical.BackColor = System.Drawing.SystemColors.Window;
            this.rtxMedical.DetectUrls = false;
            this.rtxMedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMedical.Location = new System.Drawing.Point(7, 7);
            this.rtxMedical.Name = "rtxMedical";
            this.rtxMedical.ReadOnly = true;
            this.rtxMedical.Size = new System.Drawing.Size(495, 513);
            this.rtxMedical.TabIndex = 1;
            this.rtxMedical.Text = "";
            // 
            // tabPageEmployment
            // 
            this.tabPageEmployment.Controls.Add(this.rtxEmployment);
            this.tabPageEmployment.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployment.Name = "tabPageEmployment";
            this.tabPageEmployment.Size = new System.Drawing.Size(508, 526);
            this.tabPageEmployment.TabIndex = 2;
            this.tabPageEmployment.Text = "Employment";
            this.tabPageEmployment.UseVisualStyleBackColor = true;
            // 
            // rtxEmployment
            // 
            this.rtxEmployment.BackColor = System.Drawing.SystemColors.Window;
            this.rtxEmployment.DetectUrls = false;
            this.rtxEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxEmployment.Location = new System.Drawing.Point(7, 7);
            this.rtxEmployment.Name = "rtxEmployment";
            this.rtxEmployment.ReadOnly = true;
            this.rtxEmployment.Size = new System.Drawing.Size(495, 513);
            this.rtxEmployment.TabIndex = 1;
            this.rtxEmployment.Text = "";
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.Controls.Add(this.rtxSecurity);
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 25);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Size = new System.Drawing.Size(508, 526);
            this.tabPageSecurity.TabIndex = 3;
            this.tabPageSecurity.Text = "Security";
            this.tabPageSecurity.UseVisualStyleBackColor = true;
            // 
            // rtxSecurity
            // 
            this.rtxSecurity.BackColor = System.Drawing.SystemColors.Window;
            this.rtxSecurity.DetectUrls = false;
            this.rtxSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxSecurity.Location = new System.Drawing.Point(7, 7);
            this.rtxSecurity.Name = "rtxSecurity";
            this.rtxSecurity.ReadOnly = true;
            this.rtxSecurity.Size = new System.Drawing.Size(495, 513);
            this.rtxSecurity.TabIndex = 1;
            this.rtxSecurity.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giant Armoured Serpentid Record Utility";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(317, 521);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(149, 23);
            this.btnCode.TabIndex = 13;
            this.btnCode.Text = "View code on GitHub";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnTemplateUpdate
            // 
            this.btnTemplateUpdate.Location = new System.Drawing.Point(249, 521);
            this.btnTemplateUpdate.Name = "btnTemplateUpdate";
            this.btnTemplateUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnTemplateUpdate.TabIndex = 12;
            this.btnTemplateUpdate.Text = "Update";
            this.btnTemplateUpdate.UseVisualStyleBackColor = true;
            this.btnTemplateUpdate.Click += new System.EventHandler(this.btnTemplateUpdate_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(13, 521);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(230, 23);
            this.txtPath.TabIndex = 11;
            this.txtPath.Text = "templates/default/";
            // 
            // barProgress
            // 
            this.barProgress.Location = new System.Drawing.Point(13, 492);
            this.barProgress.Maximum = 90;
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(276, 23);
            this.barProgress.Step = 1;
            this.barProgress.TabIndex = 6;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(295, 492);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(171, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy from selected tab";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grade";
            // 
            // comboGrade
            // 
            this.comboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-"});
            this.comboGrade.Location = new System.Drawing.Point(16, 122);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(121, 24);
            this.comboGrade.TabIndex = 0;
            this.comboGrade.SelectedIndexChanged += new System.EventHandler(this.comboGrade_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Occupation";
            // 
            // comboOccupation
            // 
            this.comboOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOccupation.FormattingEnabled = true;
            this.comboOccupation.Location = new System.Drawing.Point(144, 122);
            this.comboOccupation.Name = "comboOccupation";
            this.comboOccupation.Size = new System.Drawing.Size(318, 24);
            this.comboOccupation.TabIndex = 1;
            this.comboOccupation.SelectedIndexChanged += new System.EventHandler(this.comboOccupation_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // comboSex
            // 
            this.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Plural"});
            this.comboSex.Location = new System.Drawing.Point(147, 176);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(77, 24);
            this.comboSex.TabIndex = 3;
            this.comboSex.SelectedIndexChanged += new System.EventHandler(this.comboSex_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sex";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(230, 175);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(61, 22);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = " ";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Training Centre";
            // 
            // txtTrainingCentre
            // 
            this.txtTrainingCentre.Location = new System.Drawing.Point(16, 224);
            this.txtTrainingCentre.Name = "txtTrainingCentre";
            this.txtTrainingCentre.Size = new System.Drawing.Size(121, 22);
            this.txtTrainingCentre.TabIndex = 7;
            this.txtTrainingCentre.TextChanged += new System.EventHandler(this.txtTrainingCentre_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Training Courses";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRemoveAll);
            this.panel1.Controls.Add(this.btnRemoveSelected);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.checkPassed);
            this.panel1.Controls.Add(this.txtCourseName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCourseCode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.listCourses);
            this.panel1.Location = new System.Drawing.Point(16, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 189);
            this.panel1.TabIndex = 9;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(351, 161);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveAll.TabIndex = 15;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Enabled = false;
            this.btnRemoveSelected.Location = new System.Drawing.Point(216, 161);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveSelected.TabIndex = 14;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkPassed
            // 
            this.checkPassed.AutoSize = true;
            this.checkPassed.Checked = true;
            this.checkPassed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPassed.Location = new System.Drawing.Point(360, 132);
            this.checkPassed.Name = "checkPassed";
            this.checkPassed.Size = new System.Drawing.Size(77, 21);
            this.checkPassed.TabIndex = 12;
            this.checkPassed.Text = "Passed";
            this.checkPassed.UseVisualStyleBackColor = true;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(51, 132);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(303, 22);
            this.txtCourseName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Course Name";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(4, 132);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(41, 22);
            this.txtCourseCode.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Code";
            // 
            // listCourses
            // 
            this.listCourses.FormattingEnabled = true;
            this.listCourses.ItemHeight = 16;
            this.listCourses.Location = new System.Drawing.Point(4, 4);
            this.listCourses.Name = "listCourses";
            this.listCourses.Size = new System.Drawing.Size(436, 100);
            this.listCourses.TabIndex = 9;
            this.listCourses.SelectedIndexChanged += new System.EventHandler(this.listCourses_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(147, 224);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(315, 22);
            this.txtNotes.TabIndex = 8;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "General Notes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Colouration";
            // 
            // txtColouration
            // 
            this.txtColouration.Location = new System.Drawing.Point(362, 175);
            this.txtColouration.Name = "txtColouration";
            this.txtColouration.Size = new System.Drawing.Size(100, 22);
            this.txtColouration.TabIndex = 6;
            this.txtColouration.Text = " ";
            this.txtColouration.TextChanged += new System.EventHandler(this.txtColouration_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(297, 175);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(59, 22);
            this.txtAge.TabIndex = 5;
            this.txtAge.Text = " ";
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtColouration);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTrainingCentre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboOccupation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.barProgress);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnTemplateUpdate);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabOutputs);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Giant Armoured Serpentid Record Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOutputs.ResumeLayout(false);
            this.tabPagePublic.ResumeLayout(false);
            this.tabPageMedical.ResumeLayout(false);
            this.tabPageEmployment.ResumeLayout(false);
            this.tabPageSecurity.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOutputs;
        private System.Windows.Forms.TabPage tabPagePublic;
        private System.Windows.Forms.TabPage tabPageMedical;
        private System.Windows.Forms.TabPage tabPageEmployment;
        private System.Windows.Forms.TabPage tabPageSecurity;
        private System.Windows.Forms.RichTextBox rtxPublic;
        private System.Windows.Forms.RichTextBox rtxMedical;
        private System.Windows.Forms.RichTextBox rtxEmployment;
        private System.Windows.Forms.RichTextBox rtxSecurity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemplateUpdate;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ProgressBar barProgress;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOccupation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTrainingCentre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listCourses;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkPassed;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtColouration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAge;
    }
}


namespace Registrate
{
    partial class SingInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_user = new System.Windows.Forms.GroupBox();
            this.nup_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.gbx_gender = new System.Windows.Forms.GroupBox();
            this.rbn_nb = new System.Windows.Forms.RadioButton();
            this.rbn_masc = new System.Windows.Forms.RadioButton();
            this.rbn_fem = new System.Windows.Forms.RadioButton();
            this.gbx_courses = new System.Windows.Forms.GroupBox();
            this.chb_js = new System.Windows.Forms.CheckBox();
            this.chb_c_plus = new System.Windows.Forms.CheckBox();
            this.chb_c_charp = new System.Windows.Forms.CheckBox();
            this.ltb_country = new System.Windows.Forms.ListBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.btn_getin = new System.Windows.Forms.Button();
            this.gbx_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_age)).BeginInit();
            this.gbx_gender.SuspendLayout();
            this.gbx_courses.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_user
            // 
            this.gbx_user.Controls.Add(this.nup_age);
            this.gbx_user.Controls.Add(this.lbl_age);
            this.gbx_user.Controls.Add(this.txb_address);
            this.gbx_user.Controls.Add(this.lbl_address);
            this.gbx_user.Controls.Add(this.txb_name);
            this.gbx_user.Controls.Add(this.lbl_name);
            this.gbx_user.Location = new System.Drawing.Point(32, 29);
            this.gbx_user.Name = "gbx_user";
            this.gbx_user.Size = new System.Drawing.Size(226, 163);
            this.gbx_user.TabIndex = 0;
            this.gbx_user.TabStop = false;
            this.gbx_user.Text = "Detalles del usuario";
            // 
            // nup_age
            // 
            this.nup_age.Location = new System.Drawing.Point(76, 114);
            this.nup_age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_age.Name = "nup_age";
            this.nup_age.Size = new System.Drawing.Size(120, 23);
            this.nup_age.TabIndex = 5;
            this.nup_age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(6, 122);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(33, 15);
            this.lbl_age.TabIndex = 4;
            this.lbl_age.Text = "Edad";
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(76, 67);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(120, 23);
            this.txb_address.TabIndex = 3;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(6, 75);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(57, 15);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Dirección";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(76, 25);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(120, 23);
            this.txb_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 33);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre";
            // 
            // gbx_gender
            // 
            this.gbx_gender.Controls.Add(this.rbn_nb);
            this.gbx_gender.Controls.Add(this.rbn_masc);
            this.gbx_gender.Controls.Add(this.rbn_fem);
            this.gbx_gender.Location = new System.Drawing.Point(298, 29);
            this.gbx_gender.Name = "gbx_gender";
            this.gbx_gender.Size = new System.Drawing.Size(127, 128);
            this.gbx_gender.TabIndex = 1;
            this.gbx_gender.TabStop = false;
            this.gbx_gender.Text = "Género";
            // 
            // rbn_nb
            // 
            this.rbn_nb.AutoSize = true;
            this.rbn_nb.Location = new System.Drawing.Point(17, 99);
            this.rbn_nb.Name = "rbn_nb";
            this.rbn_nb.Size = new System.Drawing.Size(81, 19);
            this.rbn_nb.TabIndex = 2;
            this.rbn_nb.TabStop = true;
            this.rbn_nb.Text = "No Binario";
            this.rbn_nb.UseVisualStyleBackColor = true;
            // 
            // rbn_masc
            // 
            this.rbn_masc.AutoSize = true;
            this.rbn_masc.Location = new System.Drawing.Point(15, 65);
            this.rbn_masc.Name = "rbn_masc";
            this.rbn_masc.Size = new System.Drawing.Size(80, 19);
            this.rbn_masc.TabIndex = 1;
            this.rbn_masc.TabStop = true;
            this.rbn_masc.Text = "Masculino";
            this.rbn_masc.UseVisualStyleBackColor = true;
            // 
            // rbn_fem
            // 
            this.rbn_fem.AutoSize = true;
            this.rbn_fem.Location = new System.Drawing.Point(17, 33);
            this.rbn_fem.Name = "rbn_fem";
            this.rbn_fem.Size = new System.Drawing.Size(78, 19);
            this.rbn_fem.TabIndex = 0;
            this.rbn_fem.TabStop = true;
            this.rbn_fem.Text = "Femenino";
            this.rbn_fem.UseVisualStyleBackColor = true;
            // 
            // gbx_courses
            // 
            this.gbx_courses.Controls.Add(this.chb_js);
            this.gbx_courses.Controls.Add(this.chb_c_plus);
            this.gbx_courses.Controls.Add(this.chb_c_charp);
            this.gbx_courses.Location = new System.Drawing.Point(298, 172);
            this.gbx_courses.Name = "gbx_courses";
            this.gbx_courses.Size = new System.Drawing.Size(127, 119);
            this.gbx_courses.TabIndex = 2;
            this.gbx_courses.TabStop = false;
            this.gbx_courses.Text = "Cursos";
            // 
            // chb_js
            // 
            this.chb_js.AutoSize = true;
            this.chb_js.Location = new System.Drawing.Point(12, 94);
            this.chb_js.Name = "chb_js";
            this.chb_js.Size = new System.Drawing.Size(78, 19);
            this.chb_js.TabIndex = 2;
            this.chb_js.Text = "JavaScript";
            this.chb_js.UseVisualStyleBackColor = true;
            // 
            // chb_c_plus
            // 
            this.chb_c_plus.AutoSize = true;
            this.chb_c_plus.Location = new System.Drawing.Point(12, 60);
            this.chb_c_plus.Name = "chb_c_plus";
            this.chb_c_plus.Size = new System.Drawing.Size(50, 19);
            this.chb_c_plus.TabIndex = 1;
            this.chb_c_plus.Text = "C++";
            this.chb_c_plus.UseVisualStyleBackColor = true;
            // 
            // chb_c_charp
            // 
            this.chb_c_charp.AutoSize = true;
            this.chb_c_charp.Location = new System.Drawing.Point(12, 22);
            this.chb_c_charp.Name = "chb_c_charp";
            this.chb_c_charp.Size = new System.Drawing.Size(41, 19);
            this.chb_c_charp.TabIndex = 0;
            this.chb_c_charp.Text = "C#";
            this.chb_c_charp.UseVisualStyleBackColor = true;
            // 
            // ltb_country
            // 
            this.ltb_country.FormattingEnabled = true;
            this.ltb_country.ItemHeight = 15;
            this.ltb_country.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.ltb_country.Location = new System.Drawing.Point(32, 234);
            this.ltb_country.Name = "ltb_country";
            this.ltb_country.Size = new System.Drawing.Size(226, 94);
            this.ltb_country.TabIndex = 3;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(32, 216);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(28, 15);
            this.lbl_country.TabIndex = 4;
            this.lbl_country.Text = "País";
            // 
            // btn_getin
            // 
            this.btn_getin.Location = new System.Drawing.Point(298, 305);
            this.btn_getin.Name = "btn_getin";
            this.btn_getin.Size = new System.Drawing.Size(127, 23);
            this.btn_getin.TabIndex = 5;
            this.btn_getin.Text = "Ingresar";
            this.btn_getin.UseVisualStyleBackColor = true;
            this.btn_getin.Click += new System.EventHandler(this.btn_getin_Click);
            // 
            // SingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 363);
            this.Controls.Add(this.btn_getin);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.ltb_country);
            this.Controls.Add(this.gbx_courses);
            this.Controls.Add(this.gbx_gender);
            this.Controls.Add(this.gbx_user);
            this.Name = "SingInForm";
            this.Text = "Registrarse";
            this.gbx_user.ResumeLayout(false);
            this.gbx_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_age)).EndInit();
            this.gbx_gender.ResumeLayout(false);
            this.gbx_gender.PerformLayout();
            this.gbx_courses.ResumeLayout(false);
            this.gbx_courses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbx_user;
        private NumericUpDown nup_age;
        private Label lbl_age;
        private TextBox txb_address;
        private Label lbl_address;
        private TextBox txb_name;
        private Label lbl_name;
        private GroupBox gbx_gender;
        private RadioButton rbn_nb;
        private RadioButton rbn_masc;
        private RadioButton rbn_fem;
        private GroupBox gbx_courses;
        private CheckBox chb_js;
        private CheckBox chb_c_plus;
        private CheckBox chb_c_charp;
        private ListBox ltb_country;
        private Label lbl_country;
        private Button btn_getin;
    }
}
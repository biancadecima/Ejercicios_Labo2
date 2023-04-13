namespace WinFormsApp2
{
    partial class FormPerson
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
            this.btn_load = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_file = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Coral;
            this.btn_load.Location = new System.Drawing.Point(184, 277);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(303, 88);
            this.txb_name.Name = "txb_name";
            this.txb_name.PlaceholderText = "Enter name";
            this.txb_name.Size = new System.Drawing.Size(100, 23);
            this.txb_name.TabIndex = 1;
            // 
            // txb_file
            // 
            this.txb_file.Location = new System.Drawing.Point(303, 188);
            this.txb_file.Name = "txb_file";
            this.txb_file.PlaceholderText = "Enter file";
            this.txb_file.Size = new System.Drawing.Size(100, 23);
            this.txb_file.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Coral;
            this.btn_cancel.Location = new System.Drawing.Point(448, 278);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(301, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_file.Location = new System.Drawing.Point(303, 147);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(25, 15);
            this.lbl_file.TabIndex = 5;
            this.lbl_file.Text = "File";
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txb_file);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.btn_load);
            this.Name = "FormPerson";
            this.Text = "FormPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_load;
        private TextBox txb_name;
        private TextBox txb_file;
        private Button btn_cancel;
        private Label lbl_name;
        private Label lbl_file;
    }
}
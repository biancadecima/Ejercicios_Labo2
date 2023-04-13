using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
            DialogResult= DialogResult.Cancel;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(txb_file.Text, out int file);
            if (isNumber && file > 0 && txb_name.Text.Length > 0 )
            {
                Person person = new Person(txb_name.Text, file);
                Form1 form = new Form1(person);
                form.Show();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

    }
}

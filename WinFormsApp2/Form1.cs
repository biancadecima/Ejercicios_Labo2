namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Person p) : this()
        {
            label1.Text = p.Name;
            label2.Text = p.File.ToString();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormPerson = new FormPerson();
            FormPerson.Show();
        }


    }
}
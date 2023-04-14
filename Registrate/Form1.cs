using Entrants;
using System.Security.Cryptography.X509Certificates;

namespace Registrate
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
        }

        private string[] gbx_courses_Selected()
        {
            string[] checkedCourses = new string[3];
            if (chb_js.Checked)
            {
                checkedCourses[0] = chb_js.Text;
            }
            if(chb_c_plus.Checked)
            {
                checkedCourses[1] = chb_c_plus.Text;
            }
            if(chb_c_charp.Checked)
            {
                checkedCourses[2] = chb_c_charp.Text;
            }

            return checkedCourses;
        }

        private string gbx_gender_Selected()
        {
            if (rbn_fem.Checked)
                return rbn_fem.Text;
            else if (rbn_masc.Checked)
                return rbn_masc.Text;
            return rbn_nb.Text;
        }

        private void btn_getin_Click(object sender, EventArgs e)
        {

            if(Validator.IsName(txb_name.Text) && !String.IsNullOrWhiteSpace(txb_address.Text) && int.TryParse(nup_age.Text, out int formAge) && !String.IsNullOrWhiteSpace(ltb_country.SelectedItem.ToString()))
            {
                
                Entrant newEntrant = new Entrant(gbx_courses_Selected(), txb_address.Text, formAge, gbx_gender_Selected(), txb_name.Text, ltb_country.SelectedItem.ToString());
                MessageBox.Show(Entrant.ShowEntrant(newEntrant));
            }
            else
            {
                MessageBox.Show("No se pudo mostrar el ingresante...");
            }
            

        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminator_Genesys_Item_Planer
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
            tb_forschung.Text = Properties.Settings.Default.Auto_Forschung.ToString();
            tb_bau.Text = Properties.Settings.Default.Auto_Bau.ToString();
            tb_marsch.Text = Properties.Settings.Default.Auto_Marsch.ToString();
            tb_belagerung.Text = Properties.Settings.Default.Auto_Belagerung.ToString();
            tb_inf.Text = Properties.Settings.Default.Auto_Infantrie.ToString();
            tb_iridium.Text = Properties.Settings.Default.Auto_Iridium.ToString();
            tb_kav.Text = Properties.Settings.Default.Auto_Kavallerie.ToString();
            tb_luftwaffe.Text = Properties.Settings.Default.Auto_Luftwaffe.ToString();
            tb_muni.Text = Properties.Settings.Default.Auto_Munition.ToString();
            tb_sturm.Text = Properties.Settings.Default.Auto_Sturm.ToString();
            tb_abw.Text = Properties.Settings.Default.Auto_TruppenAbwehr.ToString();
            tb_ges.Text = Properties.Settings.Default.Auto_TruppenGesundheit.ToString();
        }

        private void btn_settings_save_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        private void btn_settings_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.Auto_Forschung = (float)Convert.ToDouble(tb_forschung.Text);
            Properties.Settings.Default.Auto_Bau = (float)Convert.ToDouble(tb_bau.Text);
            Properties.Settings.Default.Auto_Marsch = (float)Convert.ToDouble(tb_marsch.Text);
            Properties.Settings.Default.Auto_Belagerung = (float)Convert.ToDouble(tb_belagerung.Text);
            Properties.Settings.Default.Auto_Infantrie = (float)Convert.ToDouble(tb_inf.Text);
            Properties.Settings.Default.Auto_Iridium = (float)Convert.ToDouble(tb_iridium.Text);
            Properties.Settings.Default.Auto_Kavallerie = (float)Convert.ToDouble(tb_kav.Text);
            Properties.Settings.Default.Auto_Luftwaffe = (float)Convert.ToDouble(tb_luftwaffe.Text);
            Properties.Settings.Default.Auto_Munition = (float)Convert.ToDouble(tb_muni.Text);
            Properties.Settings.Default.Auto_Sturm = (float)Convert.ToDouble(tb_sturm.Text);
            Properties.Settings.Default.Auto_TruppenAbwehr = (float)Convert.ToDouble(tb_abw.Text);
            Properties.Settings.Default.Auto_TruppenGesundheit = (float)Convert.ToDouble(tb_ges.Text);
        }
    }
}

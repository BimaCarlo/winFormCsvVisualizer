using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvVisualizer
{
    public partial class dgvResponsive : Form
    {
        public dgvResponsive()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            impostaDGV();
            cambiaSorgenteDGV();

        }

        private void impostaDGV()
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
        }

        private void cambiaSorgenteDGV()
        {
            string file = richediNomeFile();
            if (file == "-1")
            {
                MessageBox.Show("Nessun File Selezionato");
                //this.Close();
                return;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int righeCaricate = caricaDGV(file);
            sw.Stop();
            lblTesto.Text = "Caricate " + righeCaricate.ToString() + " in " + sw.ElapsedMilliseconds + " ms";
            controllaLarghezzaColonne();
        }

        public string richediNomeFile()
        {
            aprifile.Title = "Prendere il file CSV";
            aprifile.FileName = "data.csv";
            aprifile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            aprifile.DefaultExt = "csv";
            if (DialogResult.OK == aprifile.ShowDialog())
            {
                return aprifile.FileName;
            }
            else
                return "-1";

        }

        private void controllaLarghezzaColonne()
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Width = (dgv.Width / dgv.Columns.Count) - 10;
            }
        }

        private int caricaDGV(string nomeFile)
        {
            //RESET
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            StreamReader sr = new StreamReader(nomeFile);
            string[] righe = sr.ReadToEnd().Replace("\r", "").Split('\n');
            string[] intestazione = righe[0].Split(',');
            for (int i = 0; i < intestazione.Length; i++)
            {
                dgv.Columns.Add(intestazione[i], intestazione[i]);
            }
            dgv.Rows.Add(righe.Length);
            for (int i = 1; i < righe.Length; i++)
            {
                dgv.Rows[i].ReadOnly = true;
                string[] values = righe[i].Split(',');
                for (int j = 0; j < values.Length; j++)
                {
                    dgv.Rows[i].Cells[j].Value = values[j];
                }
            }
            sr.Close();
            return righe.Length;
        }

        private void dgv_SizeChanged(object sender, EventArgs e)
        {
            controllaLarghezzaColonne();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            cambiaSorgenteDGV();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace datagridviewApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-8GEL792\SQLEXPRESS; Initial Catalog=DGVDB; Integrated Security = True;";
        public Form1()
        {
            InitializeComponent();
        }

        void LlenarPosicionComboBox() 
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString)) 
            {
                sqlConn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM estado", sqlConn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbxEstado.ValueMember = "estadoID";
                cbxEstado.DisplayMember = "estado";

                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Seleccionar-";
                dtbl.Rows.InsertAt(topItem,0);

                cbxEstado.DataSource = dtbl;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarPosicionComboBox();
        }
    }
}

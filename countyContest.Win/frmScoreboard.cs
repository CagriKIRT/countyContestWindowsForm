using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace countyContest.Win
{
    public partial class frmScoreboard : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-PN8NELI\\SQLEXPRESS; Initial Catalog = CountryContestDatabase; Integrated Security = true;");

        private SqlDataAdapter dataAdaptar = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        private string cmdString = "";

        public frmScoreboard()
        {
            InitializeComponent();
        }

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                cmdString = "SELECT nickname,score FROM CountryContestTable order by score desc";
                dataAdaptar = new SqlDataAdapter(cmdString, sqlConnection);
                dataAdaptar.Fill(dataTable);
                sqlConnection.Close();
                gridControl1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
            }
        }
    }
}
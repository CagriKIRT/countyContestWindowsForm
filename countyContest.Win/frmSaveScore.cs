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
    public partial class frmSaveScore : DevExpress.XtraEditors.XtraForm
    {
        private int correctAnswer = 0;
        private int answerCount = 0;
        private SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-PN8NELI\\SQLEXPRESS; Initial Catalog = CountryContestDatabase; Integrated Security = true;");
        private string cmdString = "";
        private SqlCommand cmd = new SqlCommand();

        public frmSaveScore(int correctAnswer, int answerCount)
        {
            this.correctAnswer = correctAnswer;
            this.answerCount = answerCount;
            InitializeComponent();
        }

        private void frmSaveScore_Load(object sender, EventArgs e)
        {
            txtCorrectAnswer.Text = correctAnswer.ToString();
            txtIncorrectAnswer.Text = (answerCount - correctAnswer).ToString();
            txtTotalPoints.Text = (correctAnswer * 10).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNickname.Text.ToString().Trim()) || string.IsNullOrWhiteSpace(txtNickname.Text.ToString().Trim()))
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sqlConnection.Open();
                cmdString = "Insert Into CountryContestTable(nickname,score) values('" + txtNickname.Text.ToString() + "'," + txtTotalPoints.Text.ToString() + ")";
                cmd = new SqlCommand(cmdString, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
            }
        }
    }
}
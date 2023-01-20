using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Web.Configuration;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace OBE_Desktop.Reports.SemsterGPA
{
    public partial class StudentSemesterGPA : Form
    {
        private int studentId;
        private int _courseSecid;

        private string connectionString;
        private ReportDocument rpt;

        public StudentSemesterGPA()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            rpt = new ReportDocument();
        }

        public StudentSemesterGPA(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            rpt = new ReportDocument();

        }

        private void StudentSemesterGPA_Load(object sender, System.EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                rpt.Load(Path.Combine(Environment.CurrentDirectory, "Reports", "SemesterTranscriptReport.rpt"));
                SqlCommand cmd = new SqlCommand("sp_StudentSemesterResult", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", studentId));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                rpt.SetDataSource(dt);
                StudentTranscript_RV.ReportSource = rpt;
            }
        }
    }
}

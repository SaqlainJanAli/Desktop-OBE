using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.GPA
{
    public partial class MarksGPA : Form
    {
        //Fields

        //private List<SubActivity> _subActivities = new List<SubActivity>();
        //private CLO_BLL _cloBll = new CLO_BLL();
        //private Activity_BLL _activityBll = new Activity_BLL();
        //private ResultModel _resultModel = new ResultModel();
        //private ClassActivity_BLL _ClassActivityBll = new ClassActivity_BLL();
        //private OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment.ClassActivity _classActivityBEL =
        //    new OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment.ClassActivity();
        //private Institute _instForm = new Institute();
        //private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();
        //decimal _totalweight = Convert.ToDecimal(0.00);
        //private List<ActivityWeight> activityWeights = new List<ActivityWeight>();
        //private EnrollStudent _enrolledStudentBEL = new EnrollStudent();
        //private EnrollStudent_BLL _enrollStudentBll = new EnrollStudent_BLL();
        //private StudentUser_BLL _studentUserBll = new StudentUser_BLL();
        private int _courseSecId;
        private int _assignmentWghtId = 0;
        private int _quizWghtId = 0;
        private int _midtermWghtId = 0;
        private int _finalWghtId = 0;

        private List<EnrollStudent> EnrolledStdList = new List<EnrollStudent>();

        private List<StudentCourseSectionResult> CourseSectionResults = new List<StudentCourseSectionResult>();
       
        
        //Constructor
        public MarksGPA()
        {
            InitializeComponent();
        }

        public MarksGPA(int id)
        {
            this._courseSecId = id;
            InitializeComponent();

        }

        //On Load Event
        private void MarksGPA_Load(object sender, EventArgs e)
        {
            //GetStudentUsers();
            //GetTotalWieghtage();
            GetResults();
        }

        //Get Results
        private void GetResults()
        {
            var results = new MarksGPA_BLL().GetActiviyResultsBLL(_courseSecId);
            MarksGPADataGrid.AutoGenerateColumns = false;
            MarksGPADataGrid.DataSource = results;
            CourseSectionResults = results;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in MarksGPADataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        //Save Result Button CLick
        private void saveResult_Btn_Click(object sender, EventArgs e)
        {
            SaveResult();
        }
        //Save Method
        private void SaveResult()
        {
            GetResults();

            Institute _instituteForm = new Institute();
            ResultModel _resultModel = new ResultModel();
            _resultModel = new MarksGPA_BLL().SaveCourseSecResultsBLL(CourseSectionResults);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Refresh Button Click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetResults();
        }



        //private void GetStudentUsers()
        //{
        //    EnrolledStdList = new ClassStudent_BLL().GetAllStudentsBySecIdBLL(_courseSecId);
        //}




        //private void GetTotalWieghtage()
        //{
        //    //Getting activitye types ID for later use
        //    var activityTypes = new Activity_BLL().GetActTypesByCourseSecIdBLL(_courseSecId);
        //    foreach (var activityType in activityTypes)
        //    {
        //        if (activityType.Name.StartsWith("A"))
        //        {
        //            _assignmentWghtId = activityType.Id;
        //        }
        //        else if (activityType.Name.StartsWith("Q"))
        //        {
        //            _quizWghtId = activityType.Id;
        //        }
        //        else if (activityType.Name.StartsWith("M"))
        //        {
        //            _midtermWghtId = activityType.Id;
        //        }
        //        else if (activityType.Name.StartsWith("F"))
        //        {
        //            _finalWghtId = activityType.Id;
        //        }
        //    }

        //    //Getting and filling total weightages
        //    //var totalWeight = new ActivityWeightBLL().GetWeightsByCourseSecIdBLL(_courseSecId);
        //    //foreach (var activityWeight in totalWeight)
        //    //{
        //    //    if (activityWeight.ActivityId == _assignmentWghtId)
        //    //    {
        //    //        assignmentWeight_Lbl.Text = activityWeight.Weight.ToString() + "%";
        //    //        decimal halfOfAssignment= activityWeight.Weight / 2;
        //    //        assignment01_Lbl.Text = halfOfAssignment.ToString() + "%";
        //    //        assignment02_Lbl.Text = halfOfAssignment.ToString() + "%";
        //    //    }
        //    //    else if (activityWeight.ActivityId == _quizWghtId)
        //    //    {
        //    //        quizWeight_Lbl.Text = activityWeight.Weight.ToString() + "%";
        //    //        decimal halfOfQuiz = (activityWeight.Weight / 2);
        //    //        quiz01_Lbl.Text = halfOfQuiz.ToString() + "%";
        //    //        quiz02_Lbl.Text = halfOfQuiz.ToString() + "%";
        //    //    }
        //    //    else if (activityWeight.ActivityId == _midtermWghtId)
        //    //    {
        //    //        midtermWeight_Lbl.Text = activityWeight.Weight.ToString() + "%";

        //    //    }
        //    //    else if (activityWeight.ActivityId == _finalWghtId)
        //    //    {
        //    //        finalEamWeight_Lbl.Text = activityWeight.Weight.ToString() + "%";
        //    //    }
        //    //}


        //}

    }
}

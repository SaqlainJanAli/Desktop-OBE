using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.OBE_Section.PLO_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.OBE_Section.PLO_UI
{
    public partial class UpdatePLO : Form
    {
        //Fields
        private Institute _instituteForm = new Institute();
        private PLO_BLL _ploBll = new PLO_BLL();
        private PEO_BLL _peoBll = new PEO_BLL();
        private ProgramBatch_BLL _programBatch = new ProgramBatch_BLL();
        private Course_BLL _courseBll = new Course_BLL();
        private OBE_BEL.OBE_Section.PLO_BEL.PLO _ploBEL = new OBE_BEL.OBE_Section.PLO_BEL.PLO();
        private ResultModel _resultModel = new ResultModel();
        private int countProfiles = 1;
        private int iD;

        //Constructors
        public UpdatePLO()
        {
            InitializeComponent();
        }

        public UpdatePLO(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        //On Load
        private void UpdatePLO_Load(object sender, EventArgs e)
        {
            HideFewControls();
            HideErrorLbls();
            FillDropDowns();
            FillPrevData();
        }
        private void FillPrevData()
        {
            var _ploBel = _ploBll.GetPLOByIdBLL(iD);
            ID_TB.Text = _ploBel.Id.ToString();
            Code_TB.Text = _ploBel.Code;
            Name_TB.Text = _ploBel.Name;
            Description_RTB.Text = _ploBel.Description;
            Strategies_RTB.Text = _ploBel.Strategies;
            Active_CB.Checked = _ploBel.isActive;
            WA_Code_TB.Text = _ploBel.WACode;


            var _ploProfileBEL = _ploBll.GetPloProfByPloIdBLL(iD);
            countProfiles = _ploProfileBEL.Count;
            for (int i = 0; i < countProfiles; i++)
            {
                switch (i)
                {
                    case 0:
                        ID_01_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_01_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_01_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_01_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 1:
                        Batch_02_CB.Visible = true;
                        PEO_02_CB.Visible = true;
                        KProfile_02_CB.Visible = true;

                        ID_02_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_02_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_02_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_02_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 2:
                        Batch_03_CB.Visible = true;
                        PEO_03_CB.Visible = true;
                        KProfile_03_CB.Visible = true;

                        ID_03_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_03_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_03_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_03_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 3:
                        Batch_04_CB.Visible = true;
                        PEO_04_CB.Visible = true;
                        KProfile_04_CB.Visible = true;

                        ID_04_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_04_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_04_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_04_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 4:
                        Batch_05_CB.Visible = true;
                        PEO_05_CB.Visible = true;
                        KProfile_05_CB.Visible = true;

                        ID_05_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_05_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_05_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_05_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 5:
                        Batch_06_CB.Visible = true;
                        PEO_06_CB.Visible = true;
                        KProfile_06_CB.Visible = true;

                        ID_06_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_06_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_06_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_06_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 6:
                        Batch_07_CB.Visible = true;
                        PEO_07_CB.Visible = true;
                        KProfile_07_CB.Visible = true;

                        ID_07_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_07_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_07_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_07_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 7:
                        Batch_08_CB.Visible = true;
                        PEO_08_CB.Visible = true;
                        KProfile_08_CB.Visible = true;

                        ID_08_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_08_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_08_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_08_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 8:
                        Batch_09_CB.Visible = true;
                        PEO_09_CB.Visible = true;
                        KProfile_09_CB.Visible = true;

                        ID_09_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_09_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_09_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_09_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                    case 9:
                        Batch_10_CB.Visible = true;
                        PEO_10_CB.Visible = true;
                        KProfile_10_CB.Visible = true;

                        ID_10_TB.Text = _ploProfileBEL[i].Id.ToString();
                        Batch_10_CB.SelectedValue = _ploProfileBEL[i].BatchId;
                        PEO_10_CB.SelectedValue = _ploProfileBEL[i].PEOId;
                        KProfile_10_CB.SelectedValue = _ploProfileBEL[i].KnowledgeProfileId;
                        break;
                }
            }
        }
        private void HideFewControls()
        {
            Batch_02_CB.Visible = false;
            Batch_03_CB.Visible = false;
            Batch_04_CB.Visible = false;
            Batch_05_CB.Visible = false;
            Batch_06_CB.Visible = false;
            Batch_07_CB.Visible = false;
            Batch_08_CB.Visible = false;
            Batch_09_CB.Visible = false;
            Batch_10_CB.Visible = false;


            PEO_02_CB.Visible = false;
            PEO_03_CB.Visible = false;
            PEO_04_CB.Visible = false;
            PEO_05_CB.Visible = false;
            PEO_06_CB.Visible = false;
            PEO_07_CB.Visible = false;
            PEO_08_CB.Visible = false;
            PEO_09_CB.Visible = false;
            PEO_10_CB.Visible = false;


            KProfile_02_CB.Visible = false;
            KProfile_03_CB.Visible = false;
            KProfile_04_CB.Visible = false;
            KProfile_05_CB.Visible = false;
            KProfile_06_CB.Visible = false;
            KProfile_07_CB.Visible = false;
            KProfile_08_CB.Visible = false;
            KProfile_09_CB.Visible = false;
            KProfile_10_CB.Visible = false;
        }
        private void FillDropDowns()
        {
            GetBatches();
            GetKnowledgeProfiles();
            GetPEOs();

        }
        private void GetPEOs()
        {
            PEO_01_CB.DisplayMember = "Code";
            PEO_01_CB.ValueMember = "Id";
            PEO_01_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_02_CB.DisplayMember = "Code";
            PEO_02_CB.ValueMember = "Id";
            PEO_02_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_03_CB.DisplayMember = "Code";
            PEO_03_CB.ValueMember = "Id";
            PEO_03_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_04_CB.DisplayMember = "Code";
            PEO_04_CB.ValueMember = "Id";
            PEO_04_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_05_CB.DisplayMember = "Code";
            PEO_05_CB.ValueMember = "Id";
            PEO_05_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_06_CB.DisplayMember = "Code";
            PEO_06_CB.ValueMember = "Id";
            PEO_06_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_07_CB.DisplayMember = "Code";
            PEO_07_CB.ValueMember = "Id";
            PEO_07_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_08_CB.DisplayMember = "Code";
            PEO_08_CB.ValueMember = "Id";
            PEO_08_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_09_CB.DisplayMember = "Code";
            PEO_09_CB.ValueMember = "Id";
            PEO_09_CB.DataSource = _peoBll.GetPEOsBLL();

            PEO_10_CB.DisplayMember = "Code";
            PEO_10_CB.ValueMember = "Id";
            PEO_10_CB.DataSource = _peoBll.GetPEOsBLL();

        }
        private void GetBatches()
        {
            Batch_01_CB.DisplayMember = "ProgramBatch";
            Batch_01_CB.ValueMember = "SerialNumber";
            Batch_01_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_02_CB.DisplayMember = "ProgramBatch";
            Batch_02_CB.ValueMember = "SerialNumber";
            Batch_02_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_03_CB.DisplayMember = "ProgramBatch";
            Batch_03_CB.ValueMember = "SerialNumber";
            Batch_03_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_04_CB.DisplayMember = "ProgramBatch";
            Batch_04_CB.ValueMember = "SerialNumber";
            Batch_04_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_05_CB.DisplayMember = "ProgramBatch";
            Batch_05_CB.ValueMember = "SerialNumber";
            Batch_05_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_06_CB.DisplayMember = "ProgramBatch";
            Batch_06_CB.ValueMember = "SerialNumber";
            Batch_06_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_07_CB.DisplayMember = "ProgramBatch";
            Batch_07_CB.ValueMember = "SerialNumber";
            Batch_07_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_08_CB.DisplayMember = "ProgramBatch";
            Batch_08_CB.ValueMember = "SerialNumber";
            Batch_08_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_09_CB.DisplayMember = "ProgramBatch";
            Batch_09_CB.ValueMember = "SerialNumber";
            Batch_09_CB.DataSource = _programBatch.GetProgramBatchesBLL();

            Batch_10_CB.DisplayMember = "ProgramBatch";
            Batch_10_CB.ValueMember = "SerialNumber";
            Batch_10_CB.DataSource = _programBatch.GetProgramBatchesBLL();
        }
        private void GetKnowledgeProfiles()
        {
            KProfile_01_CB.DisplayMember = "Name";
            KProfile_01_CB.ValueMember = "Id";
            KProfile_01_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_02_CB.DisplayMember = "Name";
            KProfile_02_CB.ValueMember = "Id";
            KProfile_02_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_03_CB.DisplayMember = "Name";
            KProfile_03_CB.ValueMember = "Id";
            KProfile_03_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_04_CB.DisplayMember = "Name";
            KProfile_04_CB.ValueMember = "Id";
            KProfile_04_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_05_CB.DisplayMember = "Name";
            KProfile_05_CB.ValueMember = "Id";
            KProfile_05_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_06_CB.DisplayMember = "Name";
            KProfile_06_CB.ValueMember = "Id";
            KProfile_06_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_07_CB.DisplayMember = "Name";
            KProfile_07_CB.ValueMember = "Id";
            KProfile_07_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_08_CB.DisplayMember = "Name";
            KProfile_08_CB.ValueMember = "Id";
            KProfile_08_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_09_CB.DisplayMember = "Name";
            KProfile_09_CB.ValueMember = "Id";
            KProfile_09_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();

            KProfile_10_CB.DisplayMember = "Name";
            KProfile_10_CB.ValueMember = "Id";
            KProfile_10_CB.DataSource = _courseBll.GetKnowledgeProfilesBLL();
        }
        private void HideErrorLbls()
        {
            Code_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
        }



        //Text Changed Events
        private void Name_TB_TextChanged(object sender, System.EventArgs e)
        {
            Name_errorFlag.Visible = Name_TB.Text == string.Empty;
        }
        private void Code_TB_TextChanged(object sender, System.EventArgs e)
        {
            Code_errorFlag.Visible = (Code_TB.Text == string.Empty) ? true : false;
        }

        //Button Clicks
        private void AddProgram_Btn_Click(object sender, System.EventArgs e)
        {
            if (countProfiles < 10)
            {
                switch (countProfiles)
                {
                    case 1:
                        Batch_02_CB.Visible = true;
                        PEO_02_CB.Visible = true;
                        KProfile_02_CB.Visible = true;
                        break;
                    case 2:
                        Batch_03_CB.Visible = true;
                        PEO_03_CB.Visible = true;
                        KProfile_03_CB.Visible = true;
                        break;
                    case 3:
                        Batch_04_CB.Visible = true;
                        PEO_04_CB.Visible = true;
                        KProfile_04_CB.Visible = true;
                        break;
                    case 4:
                        Batch_05_CB.Visible = true;
                        PEO_05_CB.Visible = true;
                        KProfile_05_CB.Visible = true;
                        break;
                    case 5:
                        Batch_06_CB.Visible = true;
                        PEO_06_CB.Visible = true;
                        KProfile_06_CB.Visible = true;
                        break;
                    case 6:
                        Batch_07_CB.Visible = true;
                        PEO_07_CB.Visible = true;
                        KProfile_07_CB.Visible = true;
                        break;
                    case 7:
                        Batch_08_CB.Visible = true;
                        PEO_08_CB.Visible = true;
                        KProfile_08_CB.Visible = true;
                        break;
                    case 8:
                        Batch_09_CB.Visible = true;
                        PEO_09_CB.Visible = true;
                        KProfile_09_CB.Visible = true;
                        break;
                    case 9:
                        Batch_10_CB.Visible = true;
                        PEO_10_CB.Visible = true;
                        KProfile_10_CB.Visible = true;
                        break;
                }

                countProfiles++;
            }

        }
        private void DeleteProgram_Btn_Click(object sender, System.EventArgs e)
        {
            if (countProfiles > 1)
            {
                switch (countProfiles)
                {
                    case 2:
                        Batch_02_CB.Visible = false;
                        PEO_02_CB.Visible = false;
                        KProfile_02_CB.Visible = false;
                        break;
                    case 3:
                        Batch_03_CB.Visible = false;
                        PEO_03_CB.Visible = false;
                        KProfile_03_CB.Visible = false;
                        break;
                    case 4:
                        Batch_04_CB.Visible = false;
                        PEO_04_CB.Visible = false;
                        KProfile_04_CB.Visible = false;
                        break;
                    case 5:
                        Batch_05_CB.Visible = false;
                        PEO_05_CB.Visible = false;
                        KProfile_05_CB.Visible = false;
                        break;
                    case 6:
                        Batch_06_CB.Visible = false;
                        PEO_06_CB.Visible = false;
                        KProfile_06_CB.Visible = false;
                        break;
                    case 7:
                        Batch_07_CB.Visible = false;
                        PEO_07_CB.Visible = false;
                        KProfile_07_CB.Visible = false;
                        break;
                    case 8:
                        Batch_08_CB.Visible = false;
                        PEO_08_CB.Visible = false;
                        KProfile_08_CB.Visible = false;
                        break;
                    case 9:
                        Batch_09_CB.Visible = false;
                        PEO_09_CB.Visible = false;
                        KProfile_09_CB.Visible = false;
                        break;
                    case 10:
                        Batch_10_CB.Visible = false;
                        PEO_10_CB.Visible = false;
                        KProfile_10_CB.Visible = false;
                        break;
                }
                countProfiles--;
            }

        }

        private void UpdatePLO_Btn_Click(object sender, System.EventArgs e)
        {
            if (Name_errorFlag.Visible || Code_errorFlag.Visible)
            {
                if (Name_errorFlag.Visible)
                {
                    Name_errorLbl.Visible = true;
                }
                else
                {
                    Code_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are Mandatory", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateAPLO();
            }
        }

        private void UpdateAPLO()
        {
            _ploBEL.Id = Convert.ToInt32(ID_TB.Text);
            _ploBEL.Code = Code_TB.Text;
            _ploBEL.Description = Description_RTB.Text;
            _ploBEL.Name = Name_TB.Text;
            _ploBEL.Strategies = Strategies_RTB.Text;
            _ploBEL.WACode = WA_Code_TB.Text;
            _ploBEL.isActive = Active_CB.Checked;

            _resultModel = _ploBll.UpdatePLOBLL(_ploBEL);
            if (_resultModel.Status)
            {
                int PLOId = Convert.ToInt32(_resultModel.Data);
                List<PLOProfile> _ploProfiles = new List<PLOProfile>();
                for (int i = 0; i < countProfiles; i++)
                {
                    if (i == 0)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_01_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_01_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_01_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_01_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_01_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;
                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 1)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_02_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_02_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_02_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_02_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_02_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 2)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_03_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_03_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_03_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_03_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_03_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 3)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_04_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_04_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_04_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_04_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_04_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 4)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_05_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_05_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_05_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_05_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_05_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 5)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_06_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_06_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_06_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_06_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_06_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 6)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_07_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_07_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_07_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_07_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_07_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 7)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_08_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_08_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_08_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_08_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_08_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 8)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_09_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_09_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_09_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_09_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_09_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }
                    if (i == 9)
                    {
                        PLOProfile _ploProfileBEL = new PLOProfile();
                        if (ID_10_TB.Text != string.Empty)
                        {
                            _ploProfileBEL.Id = Convert.ToInt32(ID_10_TB.Text);
                        }
                        _ploProfileBEL.BatchId = Convert.ToInt32(Batch_10_CB.SelectedValue);
                        _ploProfileBEL.KnowledgeProfileId = Convert.ToInt32(KProfile_10_CB.SelectedValue);
                        _ploProfileBEL.PEOId = Convert.ToInt32(PEO_10_CB.SelectedValue);
                        _ploProfileBEL.PLOId = PLOId;

                        _ploProfiles.Add(_ploProfileBEL);
                    }

                }


                _resultModel = _ploBll.UpdatePloProfilesBLL(_ploProfiles);
                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);

                    Close();
                }
                else
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                }
                _ploProfiles.Clear();

            }

        }


    }
}

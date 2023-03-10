using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.OBE_Section.PEO_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.OBE_Section.PEO_UI
{
    public partial class UpdatePEO : Form
    {//Variables
        private int countPrograms = 1;
        private Institute _instituteForm = new Institute();
        private Program_BLL _programBll = new Program_BLL();
        private OBE_BEL.OBE_Section.PEO_BEL.PEO _PeoBEL = new OBE_BEL.OBE_Section.PEO_BEL.PEO();
        private PEO_BLL _peoBll = new PEO_BLL();
        private ResultModel _resultModel = new ResultModel();
        private int id;

        public UpdatePEO()
        {
            InitializeComponent();
        }

        public UpdatePEO(int id)
        {
            this.id = id;
            InitializeComponent();
            ID_TB.Text = this.id.ToString();
        }

    
        //On form load
       
        private void UpdatePEO_Load(object sender, EventArgs e)
        {
            HideFewControls();
            FillDropDowns();
            FillPrevData();
            HideErrorLbls();
        }

        private void FillPrevData()
        {
            var _PEO = _peoBll.getPeoByIdBLL(id);
            Code_TB.Text = _PEO.Code;
            Description_RTB.Text = _PEO.Description;
            Elements_RTB.Text = _PEO.Elements;
            Strategies_RTB.Text = _PEO.Strategies;
            Active_CB.Checked = _PEO.isActive;
            MapMission_CB.Checked = _PEO.MapInstituteMission;
            MapVision_CB.Checked = _PEO.MapInstituteVision;

            var _peoPrograms = _peoBll.GetPeoProgramByPEOIdBLL(id);
            countPrograms = _peoPrograms.Count;
            for (int i = 0; i < _peoPrograms.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        PId01_TB.Text = _peoPrograms[i].Id.ToString();
                        Program01_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName01_TB.Text = _peoPrograms[i].ShortName;

                        break;

                    case 1:
                        Program02_CB.Visible = true;
                        ShortName02_TB.Visible = true;

                        PId02_TB.Text = _peoPrograms[i].Id.ToString();
                        Program02_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName02_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 2:

                        Program03_CB.Visible = true;
                        ShortName03_TB.Visible = true;

                        PId03_TB.Text = _peoPrograms[i].Id.ToString();
                        Program03_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName03_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 3:
                        Program04_CB.Visible = true;
                        ShortName04_TB.Visible = true;

                        PId04_TB.Text = _peoPrograms[i].Id.ToString();
                        Program04_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName04_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 4:
                        Program05_CB.Visible = true;
                        ShortName05_TB.Visible = true;

                        PId05_TB.Text = _peoPrograms[i].Id.ToString();
                        Program05_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName05_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 5:
                        Program06_CB.Visible = true;
                        ShortName06_TB.Visible = true;

                        PId06_TB.Text = _peoPrograms[i].Id.ToString();
                        Program06_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName06_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 6:
                        Program07_CB.Visible = true;
                        ShortName07_TB.Visible = true;

                        PId07_TB.Text = _peoPrograms[i].Id.ToString();
                        Program07_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName07_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 7:
                        Program08_CB.Visible = true;
                        ShortName08_TB.Visible = true;

                        PId08_TB.Text = _peoPrograms[i].Id.ToString();
                        Program08_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName08_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 8:
                        Program09_CB.Visible = true;
                        ShortName09_TB.Visible = true;

                        PId09_TB.Text = _peoPrograms[i].Id.ToString();
                        Program09_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName09_TB.Text = _peoPrograms[i].ShortName;
                        break;

                    case 9:
                        Program10_CB.Visible = true;
                        ShortName10_TB.Visible = true;

                        PId10_TB.Text = _peoPrograms[i].Id.ToString();
                        Program10_CB.SelectedValue = _peoPrograms[i].ProgramId;
                        ShortName10_TB.Text = _peoPrograms[i].ShortName;
                        break;
                }
            }
            



        }
        private void HideFewControls()
        {
            Program02_CB.Visible = false;
            Program03_CB.Visible = false;
            Program04_CB.Visible = false;
            Program05_CB.Visible = false;
            Program06_CB.Visible = false;
            Program07_CB.Visible = false;
            Program08_CB.Visible = false;
            Program09_CB.Visible = false;
            Program10_CB.Visible = false;

            ShortName02_TB.Visible = false;
            ShortName03_TB.Visible = false;
            ShortName04_TB.Visible = false;
            ShortName05_TB.Visible = false;
            ShortName06_TB.Visible = false;
            ShortName07_TB.Visible = false;
            ShortName08_TB.Visible = false;
            ShortName09_TB.Visible = false;
            ShortName10_TB.Visible = false;

        }
        private void FillDropDowns()
        {
            GetPrograms();
        }
        private void GetPrograms()
        {
            Program01_CB.DisplayMember = "Name";
            Program01_CB.ValueMember = "SerialNumber";
            Program01_CB.DataSource = _programBll.GetProgramsBLL();

            Program02_CB.DisplayMember = "Name";
            Program02_CB.ValueMember = "SerialNumber";
            Program02_CB.DataSource = _programBll.GetProgramsBLL();

            Program03_CB.DisplayMember = "Name";
            Program03_CB.ValueMember = "SerialNumber";
            Program03_CB.DataSource = _programBll.GetProgramsBLL();

            Program04_CB.DisplayMember = "Name";
            Program04_CB.ValueMember = "SerialNumber";
            Program04_CB.DataSource = _programBll.GetProgramsBLL();

            Program05_CB.DisplayMember = "Name";
            Program05_CB.ValueMember = "SerialNumber";
            Program05_CB.DataSource = _programBll.GetProgramsBLL();

            Program06_CB.DisplayMember = "Name";
            Program06_CB.ValueMember = "SerialNumber";
            Program06_CB.DataSource = _programBll.GetProgramsBLL();

            Program07_CB.DisplayMember = "Name";
            Program07_CB.ValueMember = "SerialNumber";
            Program07_CB.DataSource = _programBll.GetProgramsBLL();

            Program08_CB.DisplayMember = "Name";
            Program08_CB.ValueMember = "SerialNumber";
            Program08_CB.DataSource = _programBll.GetProgramsBLL();

            Program09_CB.DisplayMember = "Name";
            Program09_CB.ValueMember = "SerialNumber";
            Program09_CB.DataSource = _programBll.GetProgramsBLL();

            Program10_CB.DisplayMember = "Name";
            Program10_CB.ValueMember = "SerialNumber";
            Program10_CB.DataSource = _programBll.GetProgramsBLL();

        }
        private void HideErrorLbls()
        {
            Code_errorLbl.Visible = false;
            Description_errorLbl.Visible = false;
            ShortName01_errorLbl.Visible = false;
            ShortName02_errorLbl.Visible = false;
            ShortName03_errorLbl.Visible = false;
            ShortName04_errorLbl.Visible = false;
            ShortName05_errorLbl.Visible = false;
            ShortName06_errorLbl.Visible = false;
            ShortName07_errorLbl.Visible = false;
            ShortName08_errorLbl.Visible = false;
            ShortName09_errorLbl.Visible = false;
            ShortName10_errorLbl.Visible = false;
        }


        //Text Change Events
        private void Code_TB_TextChanged(object sender, EventArgs e)
        {

            if (Code_TB.Text == string.Empty)
            {
                Code_errorFlag.Visible = true;
            }
            else
            {
                Code_errorFlag.Visible = false;

            }

        }
        private void Description_RTB_TextChanged(object sender, EventArgs e)
        {
            if (Description_RTB.Text == string.Empty)
            {
                Description_errorFlag.Visible = true;
            }
            else
            {
                Description_errorFlag.Visible = false;

            }
        }
        private void ShortName01_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName01_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName01_errorLbl.Visible = true;
            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName01_errorLbl.Visible = false;
            }
        }
        private void ShortName02_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName02_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName02_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName02_errorLbl.Visible = false;
            }
        }
        private void ShortName03_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName03_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName03_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName03_errorLbl.Visible = false;
            }
        }
        private void ShortName04_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName04_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName04_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName04_errorLbl.Visible = false;
            }
        }
        private void ShortName05_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName05_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName05_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName05_errorLbl.Visible = false;
            }
        }
        private void ShortName06_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName06_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName06_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName06_errorLbl.Visible = false;
            }

        }
        private void ShortName07_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName07_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName07_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName07_errorLbl.Visible = false;
            }
        }
        private void ShortName08_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName08_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName08_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName08_errorLbl.Visible = false;
            }

        }
        private void ShortName09_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName09_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName09_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName09_errorLbl.Visible = false;
            }

        }
        private void ShortName10_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName10_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
                ShortName10_errorLbl.Visible = true;

            }
            else
            {
                ShortName_errorFlag.Visible = false;
                ShortName10_errorLbl.Visible = false;
            }
        }


        //Button Clicks

        private void AddProgram_Btn_Click(object sender, EventArgs e)
        {
            if (countPrograms < 10)
            {
                switch (countPrograms)
                {

                    case 1:
                        Program02_CB.Visible = true;
                        ShortName02_TB.Visible = true;
                        break;
                    case 2:
                        Program03_CB.Visible = true;
                        ShortName03_TB.Visible = true;
                        break;
                    case 3:
                        Program04_CB.Visible = true;
                        ShortName04_TB.Visible = true;
                        break;
                    case 4:
                        Program05_CB.Visible = true;
                        ShortName05_TB.Visible = true;
                        break;
                    case 5:
                        Program06_CB.Visible = true;
                        ShortName06_TB.Visible = true;
                        break;
                    case 6:
                        Program07_CB.Visible = true;
                        ShortName07_TB.Visible = true;
                        break;
                    case 7:
                        Program08_CB.Visible = true;
                        ShortName08_TB.Visible = true;
                        break;
                    case 8:
                        Program09_CB.Visible = true;
                        ShortName09_TB.Visible = true;
                        break;
                    case 9:
                        Program10_CB.Visible = true;
                        ShortName10_TB.Visible = true;
                        break;

                }
                countPrograms++;
            }
            

        }
        private void DeleteProgram_Btn_Click(object sender, EventArgs e)
        {
            if (countPrograms > 1)
            {
                switch (countPrograms)
                {
                    case 2:
                        Program02_CB.Visible = false;
                        ShortName02_TB.Visible = false;
                        ShortName02_errorLbl.Visible = false;
                        break;
                    case 3:
                        Program03_CB.Visible = false;
                        ShortName03_TB.Visible = false;
                        ShortName03_errorLbl.Visible = false;
                        break;
                    case 4:
                        Program04_CB.Visible = false;
                        ShortName04_TB.Visible = false;
                        ShortName04_errorLbl.Visible = false;
                        break;
                    case 5:
                        Program05_CB.Visible = false;
                        ShortName05_TB.Visible = false;
                        ShortName05_errorLbl.Visible = false;
                        break;
                    case 6:
                        Program06_CB.Visible = false;
                        ShortName06_TB.Visible = false;
                        ShortName06_errorLbl.Visible = false;
                        break;
                    case 7:
                        Program07_CB.Visible = false;
                        ShortName07_TB.Visible = false;
                        ShortName07_errorLbl.Visible = false;
                        break;
                    case 8:
                        Program08_CB.Visible = false;
                        ShortName08_TB.Visible = false;
                        ShortName08_errorLbl.Visible = false;
                        break;
                    case 9:
                        Program09_CB.Visible = false;
                        ShortName09_TB.Visible = false;
                        ShortName09_errorLbl.Visible = false;
                        break;
                    case 10:
                        Program10_CB.Visible = false;
                        ShortName10_TB.Visible = false;
                        ShortName10_errorLbl.Visible = false;
                        break;
                }
                countPrograms--;
            }
        }

                //Update Button Click
        private void UpdatePEO_Btn_Click(object sender, EventArgs e)
        {
            if (Code_errorFlag.Visible || Description_errorFlag.Visible || ShortName_errorFlag.Visible)
            {
                if (Code_errorFlag.Visible)
                {
                    Code_errorLbl.Visible = true;
                }
                else if (Description_errorFlag.Visible)
                {
                    Description_errorLbl.Visible = true;
                }
                else
                {
                    ShortName01_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);

            }
            else
            {
                UpdateAPEO();
            }
        }
        private void UpdateAPEO()
        {
            _PeoBEL.Id = Convert.ToInt32(ID_TB.Text);
            _PeoBEL.Code = Code_TB.Text;
            _PeoBEL.isActive = Active_CB.Checked;
            _PeoBEL.MapInstituteMission = MapMission_CB.Checked;
            _PeoBEL.MapInstituteVision = MapVision_CB.Checked;
            _PeoBEL.Description = Description_RTB.Text;
            _PeoBEL.Elements = Elements_RTB.Text;
            _PeoBEL.Strategies = Strategies_RTB.Text;

            _resultModel = _peoBll.UpdatePEOBLL(_PeoBEL);
            if (_resultModel.Status)
            {
                int PEO_Id = Convert.ToInt32(_resultModel.Data);

                List<PEOProgram> _newList = new List<PEOProgram>();
                for (int j = 0; j < countPrograms; j++)
                {
                    if (j == 0)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId01_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId01_TB.Text);
                        }
                        
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program01_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName01_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 1)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId02_TB.Text != String.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId02_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program02_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName02_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 2)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId03_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId03_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program03_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName03_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 3)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId04_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId04_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program04_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName04_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 4)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId05_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId05_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program05_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName05_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 5)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId06_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId06_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program06_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName06_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 6)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId07_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId07_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program07_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName07_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 7)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId08_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId08_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program08_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName08_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 8)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if (PId09_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId09_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program09_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName09_TB.Text;
                        _newList.Add(_peoProgram);
                    }
                    if (j == 9)
                    {
                        PEOProgram _peoProgram = new PEOProgram();
                        if(PId10_TB.Text != string.Empty)
                        {
                            _peoProgram.Id = Convert.ToInt32(PId10_TB.Text);
                        }
                        _peoProgram.PEOId = PEO_Id;
                        _peoProgram.ProgramId = Convert.ToInt32(Program10_CB.SelectedValue);
                        _peoProgram.ShortName = ShortName10_TB.Text;
                        _newList.Add(_peoProgram);
                    }

                }

                _resultModel = _peoBll.UpdatePeoProgramBLL(_newList);
                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);

                }
                else
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                }

                _newList.Clear();
            }
        }
    }
}

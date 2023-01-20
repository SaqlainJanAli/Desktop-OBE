using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.AdminSection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.Admin_Section.RolesUI
{
    public partial class UpdateRole : Form
    {
        Role_BLL _roleBLL = new Role_BLL();
        Institute _instituteForm = new Institute();
        ResultModel _resultModel = new ResultModel();
        OBE_BEL.Admin_Section.RolesBEL.RoleBEL.Role _roleBEL = new OBE_BEL.Admin_Section.RolesBEL.RoleBEL.Role();
        private int ID;

        public UpdateRole()
        {
            InitializeComponent();
        }
        public UpdateRole(int Id)
        {
            this.ID = Id;
            InitializeComponent();
        }
        private void UpdateRole_Btn_Click(object sender, EventArgs e)
        {
            if (Name_errorFlag.Visible == true || Type_errorFlag.Visible == true)
            {
                if (Name_errorFlag.Visible == true)
                {
                    Name_errorLbl.Visible = true;
                }
                else
                {
                    Type_errorLbl.Visible = true;
                }

                _instituteForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);

            }
            else
            {
                UpdateARole();
            }
        }

        private void UpdateARole()
        {
            _roleBEL.Id = Convert.ToInt32(RoleID_TB.Text);
            _roleBEL.Name = Name_TB.Text;
            _roleBEL.RoleTypeId = Convert.ToInt32(Type_CB.SelectedValue);


            _resultModel = _roleBLL.UpdateRoleBLL(_roleBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                this.Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (Name_TB.Text == string.Empty)
            {
                Name_errorFlag.Visible = true;
            }
            else
            {
                Name_errorFlag.Visible = false;
            }
        }

        private void Type_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_CB.Text == string.Empty)
            {
                Type_errorFlag.Visible = true;

            }
            else
            {
                Type_errorFlag.Visible = false;
            }
        }


        private void UpdateRole_Load(object sender, EventArgs e)
        {
            RoleID_TB.Text = ID.ToString();
            Name_errorLbl.Visible = false;
            Type_errorLbl.Visible = false;
            GetRoleTypes();
            FillData();
        }

        private void FillData()
        {
            var Ent = _roleBLL.GetRoleByIdBLL(ID);
            RoleID_TB.Text = Ent.Id.ToString();
            Name_TB.Text = Ent.Name;
            Type_CB.SelectedValue = Ent.RoleTypeId;

        }

        private void GetRoleTypes()
        {
            Type_CB.DisplayMember = "Name";
            Type_CB.ValueMember = "Id";
            Type_CB.DataSource = _roleBLL.GetRoleTypes();
        }

    }
}

using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.Admin_Section.RolesUI
{
    public partial class Role : Form
    {
        private Role_BLL _roleBLL = new Role_BLL();
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        private OBE_BEL.Admin_Section.RolesBEL.RoleBEL.Role _roleBEL = new OBE_BEL.Admin_Section.RolesBEL.RoleBEL.Role();
        private RolePrivacy _rolePrivacyBEL = new RolePrivacy();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        public Role()
        {
            InitializeComponent();

        }

        public Role(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }


        private void onRoleFormLoad(object sender, EventArgs e)
        {
            Name_errorLbl.Visible = false;
            Type_errorLbl.Visible = false;
            GetRoleTypes();
            GetRoles();
            HandleRolePrivacies();
        }

    
        private void HandleRolePrivacies()
        {
            var _roleLoggedIn = _roleBLL.GetRoleByIdBLL(loggedInUser.RoleId);
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
           
            if (!_rolePrivacy.RoleCreate)
            {
                Role_TabControl.TabPages.RemoveAt(0);
            }

            if (_roleLoggedIn.Name != "App Admin" || _roleLoggedIn.RoleTypeId != 2) 
            {
                Role_TabControl.TabPages.RemoveAt(1);
            }
            

            if (_rolePrivacy.RoleRead)
            {
                RoleDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                RoleDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.RoleUpdate)
            {
                RoleDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                RoleDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.RoleDelete)
            {
                RoleDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                RoleDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }
        private void GetRoles()
        {
            RoleDataGrid.AutoGenerateColumns = false;
            RoleDataGrid.DataSource = _roleBLL.GetRolesBLL();

            Role_CB.DisplayMember = "Name";
            Role_CB.ValueMember = "Id";
            Role_CB.DataSource = _roleBLL.GetRolesBLL();

            foreach (DataGridViewRow dataGridViewRow in RoleDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void GetRoleTypes()
        {
            Type_CB.DisplayMember = "Name";
            Type_CB.ValueMember = "Id";
            Type_CB.DataSource = _roleBLL.GetRoleTypes();
        }

        private void CreateRole_Btn_Click(object sender, EventArgs e)
        {
            if (Name_errorFlag.Visible || Type_errorFlag.Visible)
            {
                if (Name_errorFlag.Visible)
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
                CreateRole();
            }
        }

        private void CreateRole()
        {
            _roleBEL.Name = Name_TB.Text;
            _roleBEL.RoleTypeId = Convert.ToInt32(Type_CB.SelectedValue);


            _resultModel = _roleBLL.CreateRoleBLL(_roleBEL);

            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetRoles();
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

        private void OnRoleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RoleDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(RoleDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                ViewRole _viewRole = new ViewRole(Id);
                _viewRole.Show();
            }
            if (RoleDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(RoleDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                UpdateRole _updateRole = new UpdateRole(Id);
                _updateRole.Show();
                RoleDataGrid.Update();
            }
            if (RoleDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Role?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {

                    int Id = Convert.ToInt32(RoleDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                    DeleteRole(Id);

                }
            }
        }

        private void DeleteRole(int id)
        {
            _resultModel = _roleBLL.DeleteRoleBLL(id);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetRoles();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void Role_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Ent = _roleBLL.GetRolePrivaciesBLL();
            if (Ent.Count > 0)
            {
                foreach (var item in Ent)
                {
                    if (Convert.ToInt32(Role_CB.SelectedValue) == item.RoleId)
                    {
                        InstituteCreate_CB.Checked = item.InstituteCreate;
                        InstituteDelete_CB.Checked = item.InstituteDelete;
                        InstituteRead_CB.Checked = item.InstituteRead;
                        InstituteUpdate_CB.Checked = item.InstituteUpdate;

                        CampusCreate_CB.Checked = item.CampusCreate;
                        CampusDelete_CB.Checked = item.InstituteDelete;
                        CampusRead_CB.Checked = item.CampusRead;
                        CampusUpdate_CB.Checked = item.CampusUpdate;

                        SchoolCreate_CB.Checked = item.SchoolCreate;
                        SchoolDelete_CB.Checked = item.SchoolDelete;
                        SchoolRead_CB.Checked = item.SchoolRead;
                        SchoolUpdate_CB.Checked = item.SchoolUpdate;

                        DepartmentCreate_CB.Checked = item.DepartmentCreate;
                        DepartmentDelete_CB.Checked = item.DepartmentDelete;
                        DepartmentRead_CB.Checked = item.DepartmentRead;
                        DepartmentUpdate_CB.Checked = item.DepartmentUpdate;

                        SemesterCreate_CB.Checked = item.SemesterCreate;
                        SemesterDelete_CB.Checked = item.SemesterDelete;
                        SemesterRead_CB.Checked = item.SemesterRead;
                        SemesterUpdate_CB.Checked = item.SemesterUpdate;

                        ProgramCreate_CB.Checked = item.ProgramCreate;
                        ProgramDelete_CB.Checked = item.ProgramDelete;
                        ProgramRead_CB.Checked = item.ProgramRead;
                        ProgramUpdate_CB.Checked = item.ProgramUpdate;

                        BatchCreate_CB.Checked = item.BatchCreate;
                        BatchDelete_CB.Checked = item.BatchDelete;
                        BatchRead_CB.Checked = item.BatchRead;
                        BatchUpdate_CB.Checked = item.BatchUpdate;

                        CourseCreate_CB.Checked = item.CourseCreate;
                        CourseDelete_CB.Checked = item.CourseDelete;
                        CourseRead_CB.Checked = item.CourseRead;
                        CourseUpdate_CB.Checked = item.CourseUpdate;

                        StudentCreate_CB.Checked = item.StudentCreate;
                        StudentDelete_CB.Checked = item.StudentDelete;
                        StudentRead_CB.Checked = item.StudentRead;
                        StudentUpdate_CB.Checked = item.StudentUpdate;

                        SectionCreate_CB.Checked = item.SectionCreate;
                        SectionDelete_CB.Checked = item.SectionDelete;
                        SectionRead_CB.Checked = item.SectionRead;
                        SectionUpdate_CB.Checked = item.SectionUpdate;

                        UserCreate_CB.Checked = item.UserCreate;
                        UserDelete_CB.Checked = item.UserDelete;
                        UserRead_CB.Checked = item.UserRead;
                        UserUpdate_CB.Checked = item.UserUpdate;

                        StudentUserCreate_CB.Checked = item.StudentUserCreate;
                        StudentUserDelete_CB.Checked = item.StudentUserDelete;
                        StudentUserRead_CB.Checked = item.StudentUserRead;
                        StudentUserUpdate_CB.Checked = item.StudentUserUpdate;

                        RoleCreate_CB.Checked = item.RoleCreate;
                        RoleDelete_CB.Checked = item.RoleDelete;
                        RoleRead_CB.Checked = item.RoleRead;
                        RoleUpdate_CB.Checked = item.RoleUpdate;
                    }

                }
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            var Ent = _roleBLL.GetRolePrivaciesBLL();
            if (Ent.Count > 0)
            {
                var rolePrivacyBEL = getData();

                if (Ent.Find(r => r.RoleId == Convert.ToInt32(Role_CB.SelectedValue)) != null)
                {

                    _resultModel = _roleBLL.UpdatePrivacyBLL(rolePrivacyBEL);

                    if (_resultModel.Status)
                    {
                        _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    }
                    else
                    {
                        _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                    }
                }
                else
                {
                    _resultModel = _roleBLL.SavePrivacyBLL(rolePrivacyBEL);

                    if (_resultModel.Status)
                    {
                        _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    }
                    else
                    {
                        _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                    }
                }




            }




        }



        private RolePrivacy getData()
        {
            _rolePrivacyBEL.RoleId = Convert.ToInt32(Role_CB.SelectedValue);

            _rolePrivacyBEL.InstituteCreate = InstituteCreate_CB.Checked;
            _rolePrivacyBEL.InstituteDelete = InstituteDelete_CB.Checked;
            _rolePrivacyBEL.InstituteRead = InstituteRead_CB.Checked;
            _rolePrivacyBEL.InstituteUpdate = InstituteUpdate_CB.Checked;

            _rolePrivacyBEL.CampusCreate = CampusCreate_CB.Checked;
            _rolePrivacyBEL.CampusDelete = CampusDelete_CB.Checked;
            _rolePrivacyBEL.CampusRead = CampusRead_CB.Checked;
            _rolePrivacyBEL.CampusUpdate = CampusUpdate_CB.Checked;

            _rolePrivacyBEL.SchoolCreate = SchoolCreate_CB.Checked;
            _rolePrivacyBEL.SchoolDelete = SchoolDelete_CB.Checked;
            _rolePrivacyBEL.SchoolRead = SchoolRead_CB.Checked;
            _rolePrivacyBEL.SchoolUpdate = SchoolUpdate_CB.Checked;

            _rolePrivacyBEL.DepartmentCreate = DepartmentCreate_CB.Checked;
            _rolePrivacyBEL.DepartmentDelete = DepartmentDelete_CB.Checked;
            _rolePrivacyBEL.DepartmentRead = DepartmentRead_CB.Checked;
            _rolePrivacyBEL.DepartmentUpdate = DepartmentUpdate_CB.Checked;

            _rolePrivacyBEL.SemesterCreate = SemesterCreate_CB.Checked;
            _rolePrivacyBEL.SemesterDelete = SemesterDelete_CB.Checked;
            _rolePrivacyBEL.SemesterRead = SemesterRead_CB.Checked;
            _rolePrivacyBEL.SemesterUpdate = SemesterUpdate_CB.Checked;

            _rolePrivacyBEL.ProgramCreate = ProgramCreate_CB.Checked;
            _rolePrivacyBEL.ProgramDelete = ProgramDelete_CB.Checked;
            _rolePrivacyBEL.ProgramRead = ProgramRead_CB.Checked;
            _rolePrivacyBEL.ProgramUpdate = ProgramUpdate_CB.Checked;

            _rolePrivacyBEL.BatchCreate = BatchCreate_CB.Checked;
            _rolePrivacyBEL.BatchDelete = BatchDelete_CB.Checked;
            _rolePrivacyBEL.BatchRead = BatchRead_CB.Checked;
            _rolePrivacyBEL.BatchUpdate = BatchUpdate_CB.Checked;

            _rolePrivacyBEL.CourseCreate = CourseCreate_CB.Checked;
            _rolePrivacyBEL.CourseDelete = CourseDelete_CB.Checked;
            _rolePrivacyBEL.CourseRead = CourseRead_CB.Checked;
            _rolePrivacyBEL.CourseUpdate = CourseUpdate_CB.Checked;

            _rolePrivacyBEL.StudentCreate = StudentCreate_CB.Checked;
            _rolePrivacyBEL.StudentDelete = StudentDelete_CB.Checked;
            _rolePrivacyBEL.StudentRead = StudentRead_CB.Checked;
            _rolePrivacyBEL.StudentUpdate = StudentUpdate_CB.Checked;

            _rolePrivacyBEL.SectionCreate = SectionCreate_CB.Checked;
            _rolePrivacyBEL.SectionDelete = SectionDelete_CB.Checked;
            _rolePrivacyBEL.SectionRead = SectionRead_CB.Checked;
            _rolePrivacyBEL.SectionUpdate = SectionUpdate_CB.Checked;

            _rolePrivacyBEL.UserCreate = UserCreate_CB.Checked;
            _rolePrivacyBEL.UserDelete = UserDelete_CB.Checked;
            _rolePrivacyBEL.UserRead = UserRead_CB.Checked;
            _rolePrivacyBEL.UserUpdate = UserUpdate_CB.Checked;

            _rolePrivacyBEL.StudentUserCreate = StudentUserCreate_CB.Checked;
            _rolePrivacyBEL.StudentUserDelete = StudentUserDelete_CB.Checked;
            _rolePrivacyBEL.StudentUserRead = StudentUserRead_CB.Checked;
            _rolePrivacyBEL.StudentUserUpdate = StudentUserUpdate_CB.Checked;

            _rolePrivacyBEL.RoleCreate = RoleCreate_CB.Checked;
            _rolePrivacyBEL.RoleDelete = RoleDelete_CB.Checked;
            _rolePrivacyBEL.RoleRead = RoleRead_CB.Checked;
            _rolePrivacyBEL.RoleUpdate = RoleUpdate_CB.Checked;


            return _rolePrivacyBEL;
        }
    }
}

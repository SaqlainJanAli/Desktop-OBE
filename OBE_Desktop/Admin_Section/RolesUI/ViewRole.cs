using System;
using System.Windows.Forms;
using OBE_BLL.AdminSection_BLL;

namespace OBE_Desktop.Admin_Section.RolesUI
{
    public partial class ViewRole : Form
    {
        private int ID;
        Role_BLL _roleBLL = new Role_BLL();

        public ViewRole()
        {
            InitializeComponent();
        }
        public ViewRole(int id)
        {
            this.ID = id;
            InitializeComponent();
        }
        private void ViewRole_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            var Ent = _roleBLL.GetRoleByIdBLL(ID);
            RoleID_TB.Text = Ent.Id.ToString();
            Name_TB.Text = Ent.Name;
            Type_TB.Text = Ent.RoleTypeId.ToString();

        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

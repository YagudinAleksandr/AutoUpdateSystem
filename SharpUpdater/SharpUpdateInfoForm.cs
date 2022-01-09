using System;
using System.Windows.Forms;

namespace SharpUpdater
{
    public partial class SharpUpdateInfoForm : Form
    {
        public SharpUpdateInfoForm(ISharpUpdatable applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;

            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersions.Text = String.Format("Cerrent version: {0}\nUpdate Version: {1}", applicationInfo.ApplicationAssembly.GetName().Version,
                updateInfo.Version.ToString());
            this.txtDescription.Text = updateInfo.Description;
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.C))
                e.SuppressKeyPress = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

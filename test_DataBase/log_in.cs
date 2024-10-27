
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class log_in : Form
    {
        DataBase DataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox3.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.ClientSize = new System.Drawing.Size(315, 261);
            this.Name = "log_in";
            this.ResumeLayout(false);

        }
    }
}

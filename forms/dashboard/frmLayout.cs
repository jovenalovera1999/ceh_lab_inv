using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.dashboard
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Supply supply = new functions.Supply();

        private void frmLayout_Load(object sender, EventArgs e)
        {
            
        }
    }
}

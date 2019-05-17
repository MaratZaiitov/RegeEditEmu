using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegeditEmu.UserControls
{
    public partial class EmptyControl : UserControl
    {
         
        private static EmptyControl _instance;
        public static EmptyControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmptyControl();
                return _instance;
            }

        }

        public EmptyControl()
        {
            InitializeComponent();
        }

        private void EmptyControl_Load(object sender, EventArgs e)
        {

        }
    }
}

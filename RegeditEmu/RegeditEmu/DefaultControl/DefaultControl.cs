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
    public partial class DefaultControl : UserControl
    {

        private static DefaultControl _instance;
        public static DefaultControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DefaultControl();
                return _instance;
            }

        }
        public DefaultControl()
        {
            InitializeComponent();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegeditEmu.UserControls;

namespace RegeditEmu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }
            private void NodeMouseClick(object sender, TreeViewEventArgs e)
        {
            
        }

        private void Tree_MouseClick(object sender, MouseEventArgs e)
        {
            string nm = Tree.SelectedNode.Name;
            StripStatus_Label.Text = " ";
            StripStatus_Label.Text = nm;
            switch (nm)
            {
                case "*":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case ".386":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case ".3FR":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case ".3g2":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case ".3gp2":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case ".3gpp":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case ".3mf":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case ".a":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "ComputerNode":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Root":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "AppEvents":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Console":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case "ControlPanel":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case "Environment":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "EUDC":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                    case "KeyboardLayout":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Priters":
                    if (!Panel.Controls.Contains(EmptyControl.Instance))
                    {
                        Panel.Controls.Add(EmptyControl.Instance);
                        EmptyControl.Instance.Dock = DockStyle.Fill;
                        EmptyControl.Instance.BringToFront();
                    }
                    else
                        EmptyControl.Instance.BringToFront();
                    break;
                case "Sofware":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Sysem":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "VolatileEnvironment":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "User":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "BCD00000000":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "COMPONENTS":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "HARDWARE":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "SAM":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Schema":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "SECURITY":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "SOFTWARE":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "SYSTEM":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Machine":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Users":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case ".DEFAULT":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-18":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-19":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-20":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-21-1058341133-2092417715-4019509128-1000":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-21-1058341133-2092417715-4019509128-1000_Classes":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-21-1058341133-2092417715-4019509128-1003":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "S-1-5-21-1058341133-2092417715-4019509128-1003_Classes":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Config":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Software":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "System":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "ControlSet":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Control":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Print":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Printers":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "Services":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
                case "tsddd":
                    if (!Panel.Controls.Contains(DefaultControl.Instance))
                    {
                        Panel.Controls.Add(DefaultControl.Instance);
                        DefaultControl.Instance.Dock = DockStyle.Fill;
                        DefaultControl.Instance.BringToFront();
                    }
                    else
                        DefaultControl.Instance.BringToFront();
                    break;
            }
        }
    }
}

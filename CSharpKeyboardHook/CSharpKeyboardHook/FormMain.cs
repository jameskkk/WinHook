using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Utilities;

namespace CSharpKeyboardHook {
	public partial class FormMain : Form {
		globalKeyboardHook gkh = new globalKeyboardHook();

		public FormMain() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
            gkh.HookAllKeys = cbxHookAllKeys.Checked;
            gkh.HookKeyUp = cbxUp.Checked;
            gkh.HookKeyDown = cbxDown.Checked;
            gkh.HookHandle = cbxHandle.Checked;
            gkh.HookedKeys.Add(Keys.A);
			gkh.HookedKeys.Add(Keys.B);
			gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
			gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            gkh.unhook();
		}

		void gkh_KeyUp(object sender, KeyEventArgs e) {
			lstLog.Items.Add("Up\t" + e.KeyCode.ToString());
			e.Handled = true;
		}

		void gkh_KeyDown(object sender, KeyEventArgs e) {
			lstLog.Items.Add("Down\t" + e.KeyCode.ToString());
			e.Handled = true;
		}

        private void btnHook_Click(object sender, EventArgs e)
        {
            if (gkh != null)
            {
                // Set the hook again
                gkh.hook();
            }
        }

        private void btnUnhook_Click(object sender, EventArgs e)
        {
            if (gkh != null)
            {
                // Unhook
                gkh.unhook();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        private void cbxHookAllKeys_CheckedChanged(object sender, EventArgs e)
        {
            gkh.HookAllKeys = cbxHookAllKeys.Checked;
        }

        private void cbxUp_CheckedChanged(object sender, EventArgs e)
        {
            gkh.HookKeyUp = cbxUp.Checked;
        }

        private void cbxDown_CheckedChanged(object sender, EventArgs e)
        {
            gkh.HookKeyDown = cbxDown.Checked;
        }

        private void cbxHandle_CheckedChanged(object sender, EventArgs e)
        {
            gkh.HookHandle = cbxHandle.Checked;
        }
    }
}
namespace CSharpKeyboardHook
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnHook = new System.Windows.Forms.Button();
            this.btnUnhook = new System.Windows.Forms.Button();
            this.cbxHookAllKeys = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxDown = new System.Windows.Forms.CheckBox();
            this.cbxUp = new System.Windows.Forms.CheckBox();
            this.cbxHandle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(0, 1);
            this.lstLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(666, 319);
            this.lstLog.TabIndex = 0;
            // 
            // btnHook
            // 
            this.btnHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHook.Location = new System.Drawing.Point(462, 325);
            this.btnHook.Name = "btnHook";
            this.btnHook.Size = new System.Drawing.Size(89, 32);
            this.btnHook.TabIndex = 1;
            this.btnHook.Text = "Hook";
            this.btnHook.UseVisualStyleBackColor = true;
            this.btnHook.Click += new System.EventHandler(this.btnHook_Click);
            // 
            // btnUnhook
            // 
            this.btnUnhook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnhook.Location = new System.Drawing.Point(567, 325);
            this.btnUnhook.Name = "btnUnhook";
            this.btnUnhook.Size = new System.Drawing.Size(89, 32);
            this.btnUnhook.TabIndex = 2;
            this.btnUnhook.Text = "Unhook";
            this.btnUnhook.UseVisualStyleBackColor = true;
            this.btnUnhook.Click += new System.EventHandler(this.btnUnhook_Click);
            // 
            // cbxHookAllKeys
            // 
            this.cbxHookAllKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHookAllKeys.AutoSize = true;
            this.cbxHookAllKeys.Checked = true;
            this.cbxHookAllKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHookAllKeys.Location = new System.Drawing.Point(232, 333);
            this.cbxHookAllKeys.Name = "cbxHookAllKeys";
            this.cbxHookAllKeys.Size = new System.Drawing.Size(114, 19);
            this.cbxHookAllKeys.TabIndex = 3;
            this.cbxHookAllKeys.Text = "Hook All Keys";
            this.cbxHookAllKeys.UseVisualStyleBackColor = true;
            this.cbxHookAllKeys.CheckedChanged += new System.EventHandler(this.cbxHookAllKeys_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(361, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxDown
            // 
            this.cbxDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxDown.AutoSize = true;
            this.cbxDown.Checked = true;
            this.cbxDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDown.Location = new System.Drawing.Point(12, 333);
            this.cbxDown.Name = "cbxDown";
            this.cbxDown.Size = new System.Drawing.Size(63, 19);
            this.cbxDown.TabIndex = 5;
            this.cbxDown.Text = "Down";
            this.cbxDown.UseVisualStyleBackColor = true;
            this.cbxDown.CheckedChanged += new System.EventHandler(this.cbxDown_CheckedChanged);
            // 
            // cbxUp
            // 
            this.cbxUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUp.AutoSize = true;
            this.cbxUp.Checked = true;
            this.cbxUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUp.Location = new System.Drawing.Point(77, 333);
            this.cbxUp.Name = "cbxUp";
            this.cbxUp.Size = new System.Drawing.Size(46, 19);
            this.cbxUp.TabIndex = 6;
            this.cbxUp.Text = "Up";
            this.cbxUp.UseVisualStyleBackColor = true;
            this.cbxUp.CheckedChanged += new System.EventHandler(this.cbxUp_CheckedChanged);
            // 
            // cbxHandle
            // 
            this.cbxHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxHandle.AutoSize = true;
            this.cbxHandle.Location = new System.Drawing.Point(129, 333);
            this.cbxHandle.Name = "cbxHandle";
            this.cbxHandle.Size = new System.Drawing.Size(69, 19);
            this.cbxHandle.TabIndex = 7;
            this.cbxHandle.Text = "Handle";
            this.cbxHandle.UseVisualStyleBackColor = true;
            this.cbxHandle.CheckedChanged += new System.EventHandler(this.cbxHandle_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 369);
            this.Controls.Add(this.cbxHandle);
            this.Controls.Add(this.cbxUp);
            this.Controls.Add(this.cbxDown);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxHookAllKeys);
            this.Controls.Add(this.btnUnhook);
            this.Controls.Add(this.btnHook);
            this.Controls.Add(this.lstLog);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "CSharpKeyboardHook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnHook;
        private System.Windows.Forms.Button btnUnhook;
        private System.Windows.Forms.CheckBox cbxHookAllKeys;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbxDown;
        private System.Windows.Forms.CheckBox cbxUp;
        private System.Windows.Forms.CheckBox cbxHandle;
    }
}


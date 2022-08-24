
namespace CustomDeveloperAttributeDisplayer
{
    partial class Form1
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.TextBox();
            this.cmbbxSelect = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(35, 49);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(241, 26);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select which class you want to display developer \r\nattributes for from the classe" +
    "s below:";
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(38, 157);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(238, 98);
            this.txtView.TabIndex = 1;
            // 
            // cmbbxSelect
            // 
            this.cmbbxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSelect.FormattingEnabled = true;
            this.cmbbxSelect.Location = new System.Drawing.Point(38, 88);
            this.cmbbxSelect.Name = "cmbbxSelect";
            this.cmbbxSelect.Size = new System.Drawing.Size(238, 21);
            this.cmbbxSelect.TabIndex = 2;
            this.cmbbxSelect.SelectedIndexChanged += new System.EventHandler(this.cmbbxSelect_SelectedIndexChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(35, 141);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(215, 13);
            this.lblView.TabIndex = 3;
            this.lblView.Text = "Here is the developer attribute for that class:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(373, 336);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cmbbxSelect);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.lblSelect);
            this.Name = "Form1";
            this.Text = "Developer Attribute Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.ComboBox cmbbxSelect;
        private System.Windows.Forms.Label lblView;
    }
}


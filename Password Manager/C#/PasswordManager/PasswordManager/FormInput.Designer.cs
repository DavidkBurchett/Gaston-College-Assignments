
namespace PasswordManager
{
    partial class FormInput
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
            this.labelFormInput = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFormInput
            // 
            this.labelFormInput.AutoSize = true;
            this.labelFormInput.Location = new System.Drawing.Point(13, 13);
            this.labelFormInput.Name = "labelFormInput";
            this.labelFormInput.Size = new System.Drawing.Size(35, 13);
            this.labelFormInput.TabIndex = 0;
            this.labelFormInput.Text = "label1";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 38);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(258, 20);
            this.textBox.TabIndex = 1;
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(114, 77);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(195, 77);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 112);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelFormInput);
            this.MaximizeBox = false;
            this.Name = "FormInput";
            this.Text = "formInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelFormInput;
        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.Button buttonCancel;
    }
}
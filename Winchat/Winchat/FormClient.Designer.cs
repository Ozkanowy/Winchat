
namespace Winchat
{
    partial class FormClient
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
            this.ChatWindow = new System.Windows.Forms.RichTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.listClients = new System.Windows.Forms.ListBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatWindow
            // 
            this.ChatWindow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ChatWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatWindow.Location = new System.Drawing.Point(23, 63);
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.Size = new System.Drawing.Size(626, 311);
            this.ChatWindow.TabIndex = 0;
            this.ChatWindow.Text = "";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 412);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(152, 61);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Send ";
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBox.Location = new System.Drawing.Point(191, 412);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(586, 60);
            this.MessageBox.TabIndex = 2;
            this.MessageBox.Text = "Type Message Here!";
            // 
            // listClients
            // 
            this.listClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClients.FormattingEnabled = true;
            this.listClients.Location = new System.Drawing.Point(678, 63);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(110, 312);
            this.listClients.TabIndex = 3;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close.Location = new System.Drawing.Point(739, 21);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(38, 36);
            this.Close.TabIndex = 4;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ChatWindow);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "FormClient";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatWindow;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button Close;
    }
}


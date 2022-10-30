namespace ProjectRabbitMQConsumer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messagePanel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messagePanelConsumer = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.FormattingEnabled = true;
            this.messagePanel.ItemHeight = 15;
            this.messagePanel.Location = new System.Drawing.Point(56, 71);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(346, 304);
            this.messagePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сообщения";
            // 
            // messagePanelConsumer
            // 
            this.messagePanelConsumer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messagePanelConsumer.FormattingEnabled = true;
            this.messagePanelConsumer.ItemHeight = 17;
            this.messagePanelConsumer.Location = new System.Drawing.Point(12, 85);
            this.messagePanelConsumer.Name = "messagePanelConsumer";
            this.messagePanelConsumer.Size = new System.Drawing.Size(458, 242);
            this.messagePanelConsumer.TabIndex = 1;
            this.messagePanelConsumer.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(172, 370);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 60);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(482, 489);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.messagePanelConsumer);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(498, 528);
            this.MinimumSize = new System.Drawing.Size(498, 528);
            this.Name = "Form1";
            this.Text = "Consumer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox messagePanelConsumer;
    }
}

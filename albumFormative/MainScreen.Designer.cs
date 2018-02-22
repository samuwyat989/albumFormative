namespace albumFormative
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sortListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // originalListBox
            // 
            this.originalListBox.FormattingEnabled = true;
            this.originalListBox.ItemHeight = 20;
            this.originalListBox.Location = new System.Drawing.Point(63, 158);
            this.originalListBox.Name = "originalListBox";
            this.originalListBox.Size = new System.Drawing.Size(400, 384);
            this.originalListBox.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(351, 86);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(274, 35);
            this.inputTextBox.TabIndex = 2;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(58, 86);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(287, 29);
            this.enterLabel.TabIndex = 3;
            this.enterLabel.Text = "Enter Album Information : ";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(652, 86);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.ForestGreen;
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.Location = new System.Drawing.Point(776, 86);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(118, 35);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sortListBox
            // 
            this.sortListBox.FormattingEnabled = true;
            this.sortListBox.ItemHeight = 20;
            this.sortListBox.Location = new System.Drawing.Point(469, 158);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(400, 384);
            this.sortListBox.TabIndex = 6;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.sortListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.originalListBox);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(928, 644);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox originalListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox sortListBox;
    }
}

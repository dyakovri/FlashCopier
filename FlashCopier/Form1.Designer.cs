namespace FlashCopier
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
            this.startStopButton = new System.Windows.Forms.Button();
            this.autofindCheckbox = new System.Windows.Forms.CheckBox();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.findPath = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eraseallCheckbox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startStopButton.Location = new System.Drawing.Point(12, 254);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(374, 36);
            this.startStopButton.TabIndex = 6;
            this.startStopButton.Text = "Start!";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // autofindCheckbox
            // 
            this.autofindCheckbox.AccessibleDescription = "При включении данной опции, копирование будет происходить на любой подключенный к" +
    " данному компьютеру носителю";
            this.autofindCheckbox.AutoSize = true;
            this.autofindCheckbox.Checked = true;
            this.autofindCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autofindCheckbox.Enabled = false;
            this.autofindCheckbox.Location = new System.Drawing.Point(12, 184);
            this.autofindCheckbox.Name = "autofindCheckbox";
            this.autofindCheckbox.Size = new System.Drawing.Size(229, 17);
            this.autofindCheckbox.TabIndex = 5;
            this.autofindCheckbox.Text = "Автоматическое отслеживание флешек";
            this.autofindCheckbox.UseVisualStyleBackColor = true;
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(12, 112);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(298, 20);
            this.pathTextbox.TabIndex = 2;
            this.pathTextbox.Text = "C:\\";
            // 
            // findPath
            // 
            this.findPath.Location = new System.Drawing.Point(316, 112);
            this.findPath.Name = "findPath";
            this.findPath.Size = new System.Drawing.Size(70, 20);
            this.findPath.TabIndex = 3;
            this.findPath.Text = "Найти";
            this.findPath.UseVisualStyleBackColor = true;
            this.findPath.Click += new System.EventHandler(this.FindPath_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 63);
            this.nameTextbox.MaxLength = 10;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(374, 20);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.Text = "Mass Storage Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название накопителя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Путь к копируемой папке";
            // 
            // eraseallCheckbox
            // 
            this.eraseallCheckbox.AutoSize = true;
            this.eraseallCheckbox.Location = new System.Drawing.Point(12, 151);
            this.eraseallCheckbox.Name = "eraseallCheckbox";
            this.eraseallCheckbox.Size = new System.Drawing.Size(291, 17);
            this.eraseallCheckbox.TabIndex = 4;
            this.eraseallCheckbox.Text = "Стирать все данные с флешки перед копированием";
            this.eraseallCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.startStopButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 302);
            this.Controls.Add(this.eraseallCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.findPath);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.autofindCheckbox);
            this.Controls.Add(this.startStopButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 341);
            this.MinimumSize = new System.Drawing.Size(414, 341);
            this.Name = "Form1";
            this.Text = "Flash Copier by Dyakov Roman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.CheckBox autofindCheckbox;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Button findPath;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox eraseallCheckbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


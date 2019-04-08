namespace MathHammer.src
{
    partial class DocumentSelectionForm
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
            this._armyPanel = new System.Windows.Forms.Panel();
            this._otherPlayerArmyRadio = new System.Windows.Forms.RadioButton();
            this._yourArmyRadio = new System.Windows.Forms.RadioButton();
            this._loadButton = new System.Windows.Forms.Button();
            this._armyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _armyPanel
            // 
            this._armyPanel.Controls.Add(this._otherPlayerArmyRadio);
            this._armyPanel.Controls.Add(this._yourArmyRadio);
            this._armyPanel.Location = new System.Drawing.Point(12, 14);
            this._armyPanel.Name = "_armyPanel";
            this._armyPanel.Size = new System.Drawing.Size(114, 49);
            this._armyPanel.TabIndex = 0;
            // 
            // _otherPlayerArmyRadio
            // 
            this._otherPlayerArmyRadio.AutoSize = true;
            this._otherPlayerArmyRadio.Location = new System.Drawing.Point(3, 26);
            this._otherPlayerArmyRadio.Name = "_otherPlayerArmyRadio";
            this._otherPlayerArmyRadio.Size = new System.Drawing.Size(105, 17);
            this._otherPlayerArmyRadio.TabIndex = 1;
            this._otherPlayerArmyRadio.TabStop = true;
            this._otherPlayerArmyRadio.Text = "Opponent\'s Army";
            this._otherPlayerArmyRadio.UseVisualStyleBackColor = true;
            this._otherPlayerArmyRadio.CheckedChanged += new System.EventHandler(this.OppArmyCheckChanged);
            // 
            // _yourArmyRadio
            // 
            this._yourArmyRadio.AutoSize = true;
            this._yourArmyRadio.Location = new System.Drawing.Point(3, 3);
            this._yourArmyRadio.Name = "_yourArmyRadio";
            this._yourArmyRadio.Size = new System.Drawing.Size(73, 17);
            this._yourArmyRadio.TabIndex = 0;
            this._yourArmyRadio.TabStop = true;
            this._yourArmyRadio.Text = "Your Army";
            this._yourArmyRadio.UseVisualStyleBackColor = true;
            this._yourArmyRadio.CheckedChanged += new System.EventHandler(this.YourArmyCheckChanged);
            // 
            // _loadButton
            // 
            this._loadButton.Location = new System.Drawing.Point(175, 34);
            this._loadButton.Name = "_loadButton";
            this._loadButton.Size = new System.Drawing.Size(75, 23);
            this._loadButton.TabIndex = 1;
            this._loadButton.Text = "Load";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DocumentSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 75);
            this.Controls.Add(this._loadButton);
            this.Controls.Add(this._armyPanel);
            this.Name = "DocumentSelectionForm";
            this.Text = "DocumentSelectionForm";
            this.Load += new System.EventHandler(this.DocumentSelectionForm_Load);
            this._armyPanel.ResumeLayout(false);
            this._armyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _armyPanel;
        private System.Windows.Forms.RadioButton _otherPlayerArmyRadio;
        private System.Windows.Forms.RadioButton _yourArmyRadio;
        private System.Windows.Forms.Button _loadButton;
    }
}
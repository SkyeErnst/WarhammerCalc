namespace MathHammer
{
    partial class RollLine
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
            this._hitLabel = new System.Windows.Forms.Label();
            this._hitValue = new System.Windows.Forms.Label();
            this._hitRerollValue = new System.Windows.Forms.Label();
            this._hitRerollLabel = new System.Windows.Forms.Label();
            this._woundValue = new System.Windows.Forms.Label();
            this._woundLabel = new System.Windows.Forms.Label();
            this._armorRoll = new System.Windows.Forms.Label();
            this._armorLabel = new System.Windows.Forms.Label();
            this._damageValue = new System.Windows.Forms.Label();
            this._damageLabel = new System.Windows.Forms.Label();
            this._woundRerollLabel = new System.Windows.Forms.Label();
            this._woundRerollValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _hitLabel
            // 
            this._hitLabel.AutoSize = true;
            this._hitLabel.Location = new System.Drawing.Point(3, 11);
            this._hitLabel.Name = "_hitLabel";
            this._hitLabel.Size = new System.Drawing.Size(41, 13);
            this._hitLabel.TabIndex = 0;
            this._hitLabel.Text = "Hit Roll";
            // 
            // _hitValue
            // 
            this._hitValue.AutoSize = true;
            this._hitValue.Location = new System.Drawing.Point(3, 24);
            this._hitValue.Name = "_hitValue";
            this._hitValue.Size = new System.Drawing.Size(27, 13);
            this._hitValue.TabIndex = 1;
            this._hitValue.Text = "N/A";
            // 
            // _hitRerollValue
            // 
            this._hitRerollValue.AutoSize = true;
            this._hitRerollValue.Location = new System.Drawing.Point(78, 24);
            this._hitRerollValue.Name = "_hitRerollValue";
            this._hitRerollValue.Size = new System.Drawing.Size(27, 13);
            this._hitRerollValue.TabIndex = 3;
            this._hitRerollValue.Text = "N/A";
            // 
            // _hitRerollLabel
            // 
            this._hitRerollLabel.AutoSize = true;
            this._hitRerollLabel.Location = new System.Drawing.Point(64, 11);
            this._hitRerollLabel.Name = "_hitRerollLabel";
            this._hitRerollLabel.Size = new System.Drawing.Size(64, 13);
            this._hitRerollLabel.TabIndex = 2;
            this._hitRerollLabel.Text = "Reroll Value";
            // 
            // _woundValue
            // 
            this._woundValue.AutoSize = true;
            this._woundValue.Location = new System.Drawing.Point(148, 24);
            this._woundValue.Name = "_woundValue";
            this._woundValue.Size = new System.Drawing.Size(27, 13);
            this._woundValue.TabIndex = 5;
            this._woundValue.Text = "N/A";
            // 
            // _woundLabel
            // 
            this._woundLabel.AutoSize = true;
            this._woundLabel.Location = new System.Drawing.Point(134, 11);
            this._woundLabel.Name = "_woundLabel";
            this._woundLabel.Size = new System.Drawing.Size(63, 13);
            this._woundLabel.TabIndex = 4;
            this._woundLabel.Text = "Wound Roll";
            // 
            // _armorRoll
            // 
            this._armorRoll.AutoSize = true;
            this._armorRoll.Location = new System.Drawing.Point(293, 24);
            this._armorRoll.Name = "_armorRoll";
            this._armorRoll.Size = new System.Drawing.Size(27, 13);
            this._armorRoll.TabIndex = 7;
            this._armorRoll.Text = "N/A";
            // 
            // _armorLabel
            // 
            this._armorLabel.AutoSize = true;
            this._armorLabel.Location = new System.Drawing.Point(281, 11);
            this._armorLabel.Name = "_armorLabel";
            this._armorLabel.Size = new System.Drawing.Size(62, 13);
            this._armorLabel.TabIndex = 6;
            this._armorLabel.Text = "Armor Save";
            // 
            // _damageValue
            // 
            this._damageValue.AutoSize = true;
            this._damageValue.Location = new System.Drawing.Point(361, 24);
            this._damageValue.Name = "_damageValue";
            this._damageValue.Size = new System.Drawing.Size(27, 13);
            this._damageValue.TabIndex = 9;
            this._damageValue.Text = "N/A";
            // 
            // _damageLabel
            // 
            this._damageLabel.AutoSize = true;
            this._damageLabel.Location = new System.Drawing.Point(351, 11);
            this._damageLabel.Name = "_damageLabel";
            this._damageLabel.Size = new System.Drawing.Size(47, 13);
            this._damageLabel.TabIndex = 8;
            this._damageLabel.Text = "Damage";
            // 
            // _woundRerollLabel
            // 
            this._woundRerollLabel.AutoSize = true;
            this._woundRerollLabel.Location = new System.Drawing.Point(203, 11);
            this._woundRerollLabel.Name = "_woundRerollLabel";
            this._woundRerollLabel.Size = new System.Drawing.Size(72, 13);
            this._woundRerollLabel.TabIndex = 10;
            this._woundRerollLabel.Text = "Wound Reroll";
            // 
            // _woundRerollValue
            // 
            this._woundRerollValue.AutoSize = true;
            this._woundRerollValue.Location = new System.Drawing.Point(224, 24);
            this._woundRerollValue.Name = "_woundRerollValue";
            this._woundRerollValue.Size = new System.Drawing.Size(27, 13);
            this._woundRerollValue.TabIndex = 11;
            this._woundRerollValue.Text = "N/A";
            this._woundRerollValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RollLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._woundRerollValue);
            this.Controls.Add(this._woundRerollLabel);
            this.Controls.Add(this._damageValue);
            this.Controls.Add(this._damageLabel);
            this.Controls.Add(this._armorRoll);
            this.Controls.Add(this._armorLabel);
            this.Controls.Add(this._woundValue);
            this.Controls.Add(this._woundLabel);
            this.Controls.Add(this._hitRerollValue);
            this.Controls.Add(this._hitRerollLabel);
            this.Controls.Add(this._hitValue);
            this.Controls.Add(this._hitLabel);
            this.Name = "RollLine";
            this.Size = new System.Drawing.Size(403, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _hitRerollLabel;
        private System.Windows.Forms.Label _woundLabel;
        private System.Windows.Forms.Label _armorLabel;
        private System.Windows.Forms.Label _damageLabel;
        private System.Windows.Forms.Label _hitLabel;
        internal System.Windows.Forms.Label _hitValue;
        internal System.Windows.Forms.Label _hitRerollValue;
        internal System.Windows.Forms.Label _woundValue;
        internal System.Windows.Forms.Label _armorRoll;
        internal System.Windows.Forms.Label _damageValue;
        private System.Windows.Forms.Label _woundRerollLabel;
        internal System.Windows.Forms.Label _woundRerollValue;
    }
}

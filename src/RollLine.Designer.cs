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
            this._rerollValue = new System.Windows.Forms.Label();
            this._rerollLabel = new System.Windows.Forms.Label();
            this._woundValue = new System.Windows.Forms.Label();
            this._woundLabel = new System.Windows.Forms.Label();
            this._armorRoll = new System.Windows.Forms.Label();
            this._armorLabel = new System.Windows.Forms.Label();
            this._damageValue = new System.Windows.Forms.Label();
            this._damageLabel = new System.Windows.Forms.Label();
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
            this._hitValue.Location = new System.Drawing.Point(14, 24);
            this._hitValue.Name = "_hitValue";
            this._hitValue.Size = new System.Drawing.Size(15, 13);
            this._hitValue.TabIndex = 1;
            this._hitValue.Text = "0";
            // 
            // _rerollValue
            // 
            this._rerollValue.AutoSize = true;
            this._rerollValue.Location = new System.Drawing.Point(87, 24);
            this._rerollValue.Name = "_rerollValue";
            this._rerollValue.Size = new System.Drawing.Size(13, 13);
            this._rerollValue.TabIndex = 3;
            this._rerollValue.Text = "0";
            // 
            // _rerollLabel
            // 
            this._rerollLabel.AutoSize = true;
            this._rerollLabel.Location = new System.Drawing.Point(64, 11);
            this._rerollLabel.Name = "_rerollLabel";
            this._rerollLabel.Size = new System.Drawing.Size(64, 13);
            this._rerollLabel.TabIndex = 2;
            this._rerollLabel.Text = "Reroll Value";
            // 
            // _woundValue
            // 
            this._woundValue.AutoSize = true;
            this._woundValue.Location = new System.Drawing.Point(157, 24);
            this._woundValue.Name = "_woundValue";
            this._woundValue.Size = new System.Drawing.Size(13, 13);
            this._woundValue.TabIndex = 5;
            this._woundValue.Text = "0";
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
            this._armorRoll.Location = new System.Drawing.Point(226, 24);
            this._armorRoll.Name = "_armorRoll";
            this._armorRoll.Size = new System.Drawing.Size(13, 13);
            this._armorRoll.TabIndex = 7;
            this._armorRoll.Text = "0";
            // 
            // _armorLabel
            // 
            this._armorLabel.AutoSize = true;
            this._armorLabel.Location = new System.Drawing.Point(208, 11);
            this._armorLabel.Name = "_armorLabel";
            this._armorLabel.Size = new System.Drawing.Size(62, 13);
            this._armorLabel.TabIndex = 6;
            this._armorLabel.Text = "Armor Save";
            // 
            // _damageValue
            // 
            this._damageValue.AutoSize = true;
            this._damageValue.Location = new System.Drawing.Point(294, 24);
            this._damageValue.Name = "_damageValue";
            this._damageValue.Size = new System.Drawing.Size(13, 13);
            this._damageValue.TabIndex = 9;
            this._damageValue.Text = "0";
            // 
            // _damageLabel
            // 
            this._damageLabel.AutoSize = true;
            this._damageLabel.Location = new System.Drawing.Point(278, 11);
            this._damageLabel.Name = "_damageLabel";
            this._damageLabel.Size = new System.Drawing.Size(47, 13);
            this._damageLabel.TabIndex = 8;
            this._damageLabel.Text = "Damage";
            // 
            // RollLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._damageValue);
            this.Controls.Add(this._damageLabel);
            this.Controls.Add(this._armorRoll);
            this.Controls.Add(this._armorLabel);
            this.Controls.Add(this._woundValue);
            this.Controls.Add(this._woundLabel);
            this.Controls.Add(this._rerollValue);
            this.Controls.Add(this._rerollLabel);
            this.Controls.Add(this._hitValue);
            this.Controls.Add(this._hitLabel);
            this.Name = "RollLine";
            this.Size = new System.Drawing.Size(328, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _rerollLabel;
        private System.Windows.Forms.Label _woundLabel;
        private System.Windows.Forms.Label _armorLabel;
        private System.Windows.Forms.Label _damageLabel;
        private System.Windows.Forms.Label _hitLabel;
        internal System.Windows.Forms.Label _hitValue;
        internal System.Windows.Forms.Label _rerollValue;
        internal System.Windows.Forms.Label _woundValue;
        internal System.Windows.Forms.Label _armorRoll;
        internal System.Windows.Forms.Label _damageValue;
    }
}

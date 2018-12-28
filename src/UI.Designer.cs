namespace MathHammer
{
    partial class MathHammer
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
            this._AtkLabel = new System.Windows.Forms.Label();
            this._atkStrLabel = new System.Windows.Forms.Label();
            this._atkAPLable = new System.Windows.Forms.Label();
            this._atkStrBox = new System.Windows.Forms.MaskedTextBox();
            this.m_atkAPBox = new System.Windows.Forms.MaskedTextBox();
            this._atkDamgeLabel = new System.Windows.Forms.Label();
            this._atkDiceAmount = new System.Windows.Forms.MaskedTextBox();
            this._atkDiceD = new System.Windows.Forms.MaskedTextBox();
            this._defSave = new System.Windows.Forms.MaskedTextBox();
            this._defToughness = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_defLabel = new System.Windows.Forms.Label();
            this.m_rollButton = new System.Windows.Forms.Button();
            this._hitResults = new System.Windows.Forms.Label();
            this._woundResults = new System.Windows.Forms.Label();
            this._totalHitsLabel = new System.Windows.Forms.Label();
            this._totalHitsNum = new System.Windows.Forms.Label();
            this._woundTotalLabel = new System.Windows.Forms.Label();
            this._woundsTotalNum = new System.Windows.Forms.Label();
            this._damageResultsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._damageTotalNum = new System.Windows.Forms.Label();
            this._atkWsBsLabel = new System.Windows.Forms.Label();
            this._atkWsBsBox = new System.Windows.Forms.MaskedTextBox();
            this._atkShotsLabel = new System.Windows.Forms.Label();
            this._atkShotsBox = new System.Windows.Forms.MaskedTextBox();
            this._saveResultsLabel = new System.Windows.Forms.Label();
            this._failedSavesLabel = new System.Windows.Forms.Label();
            this._failedSavesNum = new System.Windows.Forms.Label();
            this._invulSaveLabel = new System.Windows.Forms.Label();
            this._invulSaveBox = new System.Windows.Forms.MaskedTextBox();
            this._geqButton = new System.Windows.Forms.Button();
            this._fillsLabel = new System.Windows.Forms.Label();
            this._meqButton = new System.Windows.Forms.Button();
            this._teqButton = new System.Windows.Forms.Button();
            this._keqButton = new System.Windows.Forms.Button();
            this._veqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _AtkLabel
            // 
            this._AtkLabel.AutoSize = true;
            this._AtkLabel.Location = new System.Drawing.Point(70, 9);
            this._AtkLabel.Name = "_AtkLabel";
            this._AtkLabel.Size = new System.Drawing.Size(47, 13);
            this._AtkLabel.TabIndex = 0;
            this._AtkLabel.Text = "Attacker";
            // 
            // _atkStrLabel
            // 
            this._atkStrLabel.AutoSize = true;
            this._atkStrLabel.Location = new System.Drawing.Point(12, 80);
            this._atkStrLabel.Name = "_atkStrLabel";
            this._atkStrLabel.Size = new System.Drawing.Size(47, 13);
            this._atkStrLabel.TabIndex = 1;
            this._atkStrLabel.Text = "Strength";
            // 
            // _atkAPLable
            // 
            this._atkAPLable.AutoSize = true;
            this._atkAPLable.Location = new System.Drawing.Point(12, 106);
            this._atkAPLable.Name = "_atkAPLable";
            this._atkAPLable.Size = new System.Drawing.Size(21, 13);
            this._atkAPLable.TabIndex = 2;
            this._atkAPLable.Text = "AP";
            // 
            // _atkStrBox
            // 
            this._atkStrBox.Location = new System.Drawing.Point(65, 77);
            this._atkStrBox.Mask = "00";
            this._atkStrBox.Name = "_atkStrBox";
            this._atkStrBox.Size = new System.Drawing.Size(52, 20);
            this._atkStrBox.TabIndex = 3;
            // 
            // m_atkAPBox
            // 
            this.m_atkAPBox.Location = new System.Drawing.Point(65, 103);
            this.m_atkAPBox.Mask = "0";
            this.m_atkAPBox.Name = "m_atkAPBox";
            this.m_atkAPBox.Size = new System.Drawing.Size(52, 20);
            this.m_atkAPBox.TabIndex = 4;
            // 
            // _atkDamgeLabel
            // 
            this._atkDamgeLabel.AutoSize = true;
            this._atkDamgeLabel.Location = new System.Drawing.Point(12, 132);
            this._atkDamgeLabel.Name = "_atkDamgeLabel";
            this._atkDamgeLabel.Size = new System.Drawing.Size(47, 13);
            this._atkDamgeLabel.TabIndex = 5;
            this._atkDamgeLabel.Text = "Damage";
            // 
            // _atkDiceAmount
            // 
            this._atkDiceAmount.Location = new System.Drawing.Point(65, 129);
            this._atkDiceAmount.Mask = "00";
            this._atkDiceAmount.Name = "_atkDiceAmount";
            this._atkDiceAmount.Size = new System.Drawing.Size(52, 20);
            this._atkDiceAmount.TabIndex = 6;
            // 
            // _atkDiceD
            // 
            this._atkDiceD.Location = new System.Drawing.Point(123, 129);
            this._atkDiceD.Mask = "00";
            this._atkDiceD.Name = "_atkDiceD";
            this._atkDiceD.Size = new System.Drawing.Size(52, 20);
            this._atkDiceD.TabIndex = 7;
            // 
            // _defSave
            // 
            this._defSave.Location = new System.Drawing.Point(301, 54);
            this._defSave.Mask = "0";
            this._defSave.Name = "_defSave";
            this._defSave.Size = new System.Drawing.Size(52, 20);
            this._defSave.TabIndex = 12;
            // 
            // _defToughness
            // 
            this._defToughness.Location = new System.Drawing.Point(301, 28);
            this._defToughness.Mask = "00";
            this._defToughness.Name = "_defToughness";
            this._defToughness.Size = new System.Drawing.Size(52, 20);
            this._defToughness.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toughness";
            // 
            // m_defLabel
            // 
            this.m_defLabel.AutoSize = true;
            this.m_defLabel.Location = new System.Drawing.Point(302, 9);
            this.m_defLabel.Name = "m_defLabel";
            this.m_defLabel.Size = new System.Drawing.Size(51, 13);
            this.m_defLabel.TabIndex = 8;
            this.m_defLabel.Text = "Defender";
            // 
            // m_rollButton
            // 
            this.m_rollButton.Location = new System.Drawing.Point(380, 78);
            this.m_rollButton.Name = "m_rollButton";
            this.m_rollButton.Size = new System.Drawing.Size(75, 23);
            this.m_rollButton.TabIndex = 15;
            this.m_rollButton.Text = "Roll!";
            this.m_rollButton.UseVisualStyleBackColor = true;
            this.m_rollButton.Click += new System.EventHandler(this.m_rollButton_Click);
            // 
            // _hitResults
            // 
            this._hitResults.AutoSize = true;
            this._hitResults.Location = new System.Drawing.Point(12, 199);
            this._hitResults.Name = "_hitResults";
            this._hitResults.Size = new System.Drawing.Size(58, 13);
            this._hitResults.TabIndex = 16;
            this._hitResults.Text = "Hit Results";
            // 
            // _woundResults
            // 
            this._woundResults.AutoSize = true;
            this._woundResults.Location = new System.Drawing.Point(190, 199);
            this._woundResults.Name = "_woundResults";
            this._woundResults.Size = new System.Drawing.Size(80, 13);
            this._woundResults.TabIndex = 17;
            this._woundResults.Text = "Wound Results";
            // 
            // _totalHitsLabel
            // 
            this._totalHitsLabel.AutoSize = true;
            this._totalHitsLabel.Location = new System.Drawing.Point(95, 199);
            this._totalHitsLabel.Name = "_totalHitsLabel";
            this._totalHitsLabel.Size = new System.Drawing.Size(52, 13);
            this._totalHitsLabel.TabIndex = 18;
            this._totalHitsLabel.Text = "Total Hits";
            // 
            // _totalHitsNum
            // 
            this._totalHitsNum.AutoSize = true;
            this._totalHitsNum.Location = new System.Drawing.Point(95, 221);
            this._totalHitsNum.Name = "_totalHitsNum";
            this._totalHitsNum.Size = new System.Drawing.Size(13, 13);
            this._totalHitsNum.TabIndex = 19;
            this._totalHitsNum.Text = "0";
            // 
            // _woundTotalLabel
            // 
            this._woundTotalLabel.AutoSize = true;
            this._woundTotalLabel.Location = new System.Drawing.Point(297, 199);
            this._woundTotalLabel.Name = "_woundTotalLabel";
            this._woundTotalLabel.Size = new System.Drawing.Size(74, 13);
            this._woundTotalLabel.TabIndex = 20;
            this._woundTotalLabel.Text = "Total Wounds";
            // 
            // _woundsTotalNum
            // 
            this._woundsTotalNum.AutoSize = true;
            this._woundsTotalNum.Location = new System.Drawing.Point(297, 221);
            this._woundsTotalNum.Name = "_woundsTotalNum";
            this._woundsTotalNum.Size = new System.Drawing.Size(13, 13);
            this._woundsTotalNum.TabIndex = 21;
            this._woundsTotalNum.Text = "0";
            // 
            // _damageResultsLabel
            // 
            this._damageResultsLabel.AutoSize = true;
            this._damageResultsLabel.Location = new System.Drawing.Point(533, 199);
            this._damageResultsLabel.Name = "_damageResultsLabel";
            this._damageResultsLabel.Size = new System.Drawing.Size(85, 13);
            this._damageResultsLabel.TabIndex = 22;
            this._damageResultsLabel.Text = "Damage Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Damge";
            // 
            // _damageTotalNum
            // 
            this._damageTotalNum.AutoSize = true;
            this._damageTotalNum.Location = new System.Drawing.Point(624, 221);
            this._damageTotalNum.Name = "_damageTotalNum";
            this._damageTotalNum.Size = new System.Drawing.Size(13, 13);
            this._damageTotalNum.TabIndex = 24;
            this._damageTotalNum.Text = "0";
            // 
            // _atkWsBsLabel
            // 
            this._atkWsBsLabel.AutoSize = true;
            this._atkWsBsLabel.Location = new System.Drawing.Point(12, 28);
            this._atkWsBsLabel.Name = "_atkWsBsLabel";
            this._atkWsBsLabel.Size = new System.Drawing.Size(44, 13);
            this._atkWsBsLabel.TabIndex = 25;
            this._atkWsBsLabel.Text = "WS/BS";
            // 
            // _atkWsBsBox
            // 
            this._atkWsBsBox.Location = new System.Drawing.Point(65, 24);
            this._atkWsBsBox.Mask = "0";
            this._atkWsBsBox.Name = "_atkWsBsBox";
            this._atkWsBsBox.Size = new System.Drawing.Size(52, 20);
            this._atkWsBsBox.TabIndex = 26;
            // 
            // _atkShotsLabel
            // 
            this._atkShotsLabel.AutoSize = true;
            this._atkShotsLabel.Location = new System.Drawing.Point(12, 54);
            this._atkShotsLabel.Name = "_atkShotsLabel";
            this._atkShotsLabel.Size = new System.Drawing.Size(34, 13);
            this._atkShotsLabel.TabIndex = 27;
            this._atkShotsLabel.Text = "Shots";
            // 
            // _atkShotsBox
            // 
            this._atkShotsBox.Location = new System.Drawing.Point(64, 51);
            this._atkShotsBox.Mask = "000";
            this._atkShotsBox.Name = "_atkShotsBox";
            this._atkShotsBox.Size = new System.Drawing.Size(52, 20);
            this._atkShotsBox.TabIndex = 28;
            // 
            // _saveResultsLabel
            // 
            this._saveResultsLabel.AutoSize = true;
            this._saveResultsLabel.Location = new System.Drawing.Point(377, 199);
            this._saveResultsLabel.Name = "_saveResultsLabel";
            this._saveResultsLabel.Size = new System.Drawing.Size(70, 13);
            this._saveResultsLabel.TabIndex = 29;
            this._saveResultsLabel.Text = "Save Results";
            // 
            // _failedSavesLabel
            // 
            this._failedSavesLabel.AutoSize = true;
            this._failedSavesLabel.Location = new System.Drawing.Point(457, 199);
            this._failedSavesLabel.Name = "_failedSavesLabel";
            this._failedSavesLabel.Size = new System.Drawing.Size(68, 13);
            this._failedSavesLabel.TabIndex = 30;
            this._failedSavesLabel.Text = "Failed Saves";
            // 
            // _failedSavesNum
            // 
            this._failedSavesNum.AutoSize = true;
            this._failedSavesNum.Location = new System.Drawing.Point(457, 221);
            this._failedSavesNum.Name = "_failedSavesNum";
            this._failedSavesNum.Size = new System.Drawing.Size(13, 13);
            this._failedSavesNum.TabIndex = 31;
            this._failedSavesNum.Text = "0";
            // 
            // _invulSaveLabel
            // 
            this._invulSaveLabel.AutoSize = true;
            this._invulSaveLabel.Location = new System.Drawing.Point(211, 80);
            this._invulSaveLabel.Name = "_invulSaveLabel";
            this._invulSaveLabel.Size = new System.Drawing.Size(58, 13);
            this._invulSaveLabel.TabIndex = 32;
            this._invulSaveLabel.Text = "Invul Save";
            // 
            // _invulSaveBox
            // 
            this._invulSaveBox.Location = new System.Drawing.Point(300, 80);
            this._invulSaveBox.Mask = "0";
            this._invulSaveBox.Name = "_invulSaveBox";
            this._invulSaveBox.Size = new System.Drawing.Size(52, 20);
            this._invulSaveBox.TabIndex = 33;
            // 
            // _geqButton
            // 
            this._geqButton.Location = new System.Drawing.Point(481, 30);
            this._geqButton.Name = "_geqButton";
            this._geqButton.Size = new System.Drawing.Size(75, 23);
            this._geqButton.TabIndex = 34;
            this._geqButton.Text = "GEQ";
            this._geqButton.UseVisualStyleBackColor = true;
            // 
            // _fillsLabel
            // 
            this._fillsLabel.AutoSize = true;
            this._fillsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._fillsLabel.Location = new System.Drawing.Point(623, 7);
            this._fillsLabel.Name = "_fillsLabel";
            this._fillsLabel.Size = new System.Drawing.Size(36, 20);
            this._fillsLabel.TabIndex = 35;
            this._fillsLabel.Text = "Fills";
            // 
            // _meqButton
            // 
            this._meqButton.Location = new System.Drawing.Point(562, 30);
            this._meqButton.Name = "_meqButton";
            this._meqButton.Size = new System.Drawing.Size(75, 23);
            this._meqButton.TabIndex = 36;
            this._meqButton.Text = "MEQ";
            this._meqButton.UseVisualStyleBackColor = true;
            // 
            // _teqButton
            // 
            this._teqButton.Location = new System.Drawing.Point(643, 30);
            this._teqButton.Name = "_teqButton";
            this._teqButton.Size = new System.Drawing.Size(75, 23);
            this._teqButton.TabIndex = 37;
            this._teqButton.Text = "TEQ";
            this._teqButton.UseVisualStyleBackColor = true;
            // 
            // _keqButton
            // 
            this._keqButton.Location = new System.Drawing.Point(805, 30);
            this._keqButton.Name = "_keqButton";
            this._keqButton.Size = new System.Drawing.Size(75, 23);
            this._keqButton.TabIndex = 38;
            this._keqButton.Text = "KEQ";
            this._keqButton.UseVisualStyleBackColor = true;
            // 
            // _veqButton
            // 
            this._veqButton.Location = new System.Drawing.Point(724, 30);
            this._veqButton.Name = "_veqButton";
            this._veqButton.Size = new System.Drawing.Size(75, 23);
            this._veqButton.TabIndex = 39;
            this._veqButton.Text = "VEQ";
            this._veqButton.UseVisualStyleBackColor = true;
            // 
            // MathHammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this._veqButton);
            this.Controls.Add(this._keqButton);
            this.Controls.Add(this._teqButton);
            this.Controls.Add(this._meqButton);
            this.Controls.Add(this._fillsLabel);
            this.Controls.Add(this._geqButton);
            this.Controls.Add(this._invulSaveBox);
            this.Controls.Add(this._invulSaveLabel);
            this.Controls.Add(this._failedSavesNum);
            this.Controls.Add(this._failedSavesLabel);
            this.Controls.Add(this._saveResultsLabel);
            this.Controls.Add(this._atkShotsBox);
            this.Controls.Add(this._atkShotsLabel);
            this.Controls.Add(this._atkWsBsBox);
            this.Controls.Add(this._atkWsBsLabel);
            this.Controls.Add(this._damageTotalNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._damageResultsLabel);
            this.Controls.Add(this._woundsTotalNum);
            this.Controls.Add(this._woundTotalLabel);
            this.Controls.Add(this._totalHitsNum);
            this.Controls.Add(this._totalHitsLabel);
            this.Controls.Add(this._woundResults);
            this.Controls.Add(this._hitResults);
            this.Controls.Add(this.m_rollButton);
            this.Controls.Add(this._defSave);
            this.Controls.Add(this._defToughness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_defLabel);
            this.Controls.Add(this._atkDiceD);
            this.Controls.Add(this._atkDiceAmount);
            this.Controls.Add(this._atkDamgeLabel);
            this.Controls.Add(this.m_atkAPBox);
            this.Controls.Add(this._atkStrBox);
            this.Controls.Add(this._atkAPLable);
            this.Controls.Add(this._atkStrLabel);
            this.Controls.Add(this._AtkLabel);
            this.Name = "MathHammer";
            this.Text = "Math Hammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _AtkLabel;
        private System.Windows.Forms.Label _atkStrLabel;
        private System.Windows.Forms.Label _atkAPLable;
        private System.Windows.Forms.MaskedTextBox _atkStrBox;
        private System.Windows.Forms.MaskedTextBox m_atkAPBox;
        private System.Windows.Forms.Label _atkDamgeLabel;
        private System.Windows.Forms.MaskedTextBox _atkDiceAmount;
        private System.Windows.Forms.MaskedTextBox _atkDiceD;
        private System.Windows.Forms.MaskedTextBox _defSave;
        private System.Windows.Forms.MaskedTextBox _defToughness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_defLabel;
        private System.Windows.Forms.Button m_rollButton;
        private System.Windows.Forms.Label _hitResults;
        private System.Windows.Forms.Label _woundResults;
        private System.Windows.Forms.Label _totalHitsLabel;
        private System.Windows.Forms.Label _totalHitsNum;
        private System.Windows.Forms.Label _woundTotalLabel;
        private System.Windows.Forms.Label _woundsTotalNum;
        private System.Windows.Forms.Label _damageResultsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _damageTotalNum;
        private System.Windows.Forms.Label _atkWsBsLabel;
        private System.Windows.Forms.MaskedTextBox _atkWsBsBox;
        private System.Windows.Forms.Label _atkShotsLabel;
        private System.Windows.Forms.MaskedTextBox _atkShotsBox;
        private System.Windows.Forms.Label _saveResultsLabel;
        private System.Windows.Forms.Label _failedSavesLabel;
        private System.Windows.Forms.Label _failedSavesNum;
        private System.Windows.Forms.Label _invulSaveLabel;
        private System.Windows.Forms.MaskedTextBox _invulSaveBox;
        private System.Windows.Forms.Button _geqButton;
        private System.Windows.Forms.Label _fillsLabel;
        private System.Windows.Forms.Button _meqButton;
        private System.Windows.Forms.Button _teqButton;
        private System.Windows.Forms.Button _keqButton;
        private System.Windows.Forms.Button _veqButton;
    }
}


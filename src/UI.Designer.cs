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
            this._InitialhitResults = new System.Windows.Forms.Label();
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
            this._woundPerModelLabel = new System.Windows.Forms.Label();
            this._woundsPerModelBox = new System.Windows.Forms.MaskedTextBox();
            this._noRerollRadio = new System.Windows.Forms.RadioButton();
            this._modifersPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._rerollWoundsRadio = new System.Windows.Forms.RadioButton();
            this._normalWoundingRadio = new System.Windows.Forms.RadioButton();
            this._rerollMisses = new System.Windows.Forms.RadioButton();
            this._rerollOnesRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this._hitRerollsLabel = new System.Windows.Forms.Label();
            this._finalHitsLabel = new System.Windows.Forms.Label();
            this._modifersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _AtkLabel
            // 
            this._AtkLabel.AutoSize = true;
            this._AtkLabel.Location = new System.Drawing.Point(63, 24);
            this._AtkLabel.Name = "_AtkLabel";
            this._AtkLabel.Size = new System.Drawing.Size(47, 13);
            this._AtkLabel.TabIndex = 0;
            this._AtkLabel.Text = "Attacker";
            // 
            // _atkStrLabel
            // 
            this._atkStrLabel.AutoSize = true;
            this._atkStrLabel.Location = new System.Drawing.Point(5, 95);
            this._atkStrLabel.Name = "_atkStrLabel";
            this._atkStrLabel.Size = new System.Drawing.Size(47, 13);
            this._atkStrLabel.TabIndex = 1;
            this._atkStrLabel.Text = "Strength";
            // 
            // _atkAPLable
            // 
            this._atkAPLable.AutoSize = true;
            this._atkAPLable.Location = new System.Drawing.Point(5, 121);
            this._atkAPLable.Name = "_atkAPLable";
            this._atkAPLable.Size = new System.Drawing.Size(21, 13);
            this._atkAPLable.TabIndex = 2;
            this._atkAPLable.Text = "AP";
            // 
            // _atkStrBox
            // 
            this._atkStrBox.Location = new System.Drawing.Point(58, 92);
            this._atkStrBox.Mask = "00";
            this._atkStrBox.Name = "_atkStrBox";
            this._atkStrBox.Size = new System.Drawing.Size(52, 20);
            this._atkStrBox.TabIndex = 3;
            // 
            // m_atkAPBox
            // 
            this.m_atkAPBox.Location = new System.Drawing.Point(58, 118);
            this.m_atkAPBox.Mask = "0";
            this.m_atkAPBox.Name = "m_atkAPBox";
            this.m_atkAPBox.Size = new System.Drawing.Size(52, 20);
            this.m_atkAPBox.TabIndex = 4;
            // 
            // _atkDamgeLabel
            // 
            this._atkDamgeLabel.AutoSize = true;
            this._atkDamgeLabel.Location = new System.Drawing.Point(5, 147);
            this._atkDamgeLabel.Name = "_atkDamgeLabel";
            this._atkDamgeLabel.Size = new System.Drawing.Size(47, 13);
            this._atkDamgeLabel.TabIndex = 5;
            this._atkDamgeLabel.Text = "Damage";
            // 
            // _atkDiceAmount
            // 
            this._atkDiceAmount.Location = new System.Drawing.Point(58, 144);
            this._atkDiceAmount.Mask = "00";
            this._atkDiceAmount.Name = "_atkDiceAmount";
            this._atkDiceAmount.Size = new System.Drawing.Size(52, 20);
            this._atkDiceAmount.TabIndex = 6;
            // 
            // _atkDiceD
            // 
            this._atkDiceD.Location = new System.Drawing.Point(116, 144);
            this._atkDiceD.Mask = "00";
            this._atkDiceD.Name = "_atkDiceD";
            this._atkDiceD.Size = new System.Drawing.Size(52, 20);
            this._atkDiceD.TabIndex = 7;
            // 
            // _defSave
            // 
            this._defSave.Location = new System.Drawing.Point(294, 69);
            this._defSave.Mask = "0";
            this._defSave.Name = "_defSave";
            this._defSave.Size = new System.Drawing.Size(52, 20);
            this._defSave.TabIndex = 12;
            // 
            // _defToughness
            // 
            this._defToughness.Location = new System.Drawing.Point(294, 43);
            this._defToughness.Mask = "00";
            this._defToughness.Name = "_defToughness";
            this._defToughness.Size = new System.Drawing.Size(52, 20);
            this._defToughness.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toughness";
            // 
            // m_defLabel
            // 
            this.m_defLabel.AutoSize = true;
            this.m_defLabel.Location = new System.Drawing.Point(295, 24);
            this.m_defLabel.Name = "m_defLabel";
            this.m_defLabel.Size = new System.Drawing.Size(51, 13);
            this.m_defLabel.TabIndex = 8;
            this.m_defLabel.Text = "Defender";
            // 
            // m_rollButton
            // 
            this.m_rollButton.Location = new System.Drawing.Point(373, 123);
            this.m_rollButton.Name = "m_rollButton";
            this.m_rollButton.Size = new System.Drawing.Size(75, 23);
            this.m_rollButton.TabIndex = 15;
            this.m_rollButton.Text = "Roll!";
            this.m_rollButton.UseVisualStyleBackColor = true;
            this.m_rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // _InitialhitResults
            // 
            this._InitialhitResults.AutoSize = true;
            this._InitialhitResults.Location = new System.Drawing.Point(5, 214);
            this._InitialhitResults.Name = "_InitialhitResults";
            this._InitialhitResults.Size = new System.Drawing.Size(83, 13);
            this._InitialhitResults.TabIndex = 16;
            this._InitialhitResults.Text = "Inital Hit Results";
            // 
            // _woundResults
            // 
            this._woundResults.AutoSize = true;
            this._woundResults.Location = new System.Drawing.Point(327, 214);
            this._woundResults.Name = "_woundResults";
            this._woundResults.Size = new System.Drawing.Size(80, 13);
            this._woundResults.TabIndex = 17;
            this._woundResults.Text = "Wound Results";
            // 
            // _totalHitsLabel
            // 
            this._totalHitsLabel.AutoSize = true;
            this._totalHitsLabel.Location = new System.Drawing.Point(232, 214);
            this._totalHitsLabel.Name = "_totalHitsLabel";
            this._totalHitsLabel.Size = new System.Drawing.Size(52, 13);
            this._totalHitsLabel.TabIndex = 18;
            this._totalHitsLabel.Text = "Total Hits";
            // 
            // _totalHitsNum
            // 
            this._totalHitsNum.AutoSize = true;
            this._totalHitsNum.Location = new System.Drawing.Point(232, 236);
            this._totalHitsNum.Name = "_totalHitsNum";
            this._totalHitsNum.Size = new System.Drawing.Size(13, 13);
            this._totalHitsNum.TabIndex = 19;
            this._totalHitsNum.Text = "0";
            // 
            // _woundTotalLabel
            // 
            this._woundTotalLabel.AutoSize = true;
            this._woundTotalLabel.Location = new System.Drawing.Point(434, 214);
            this._woundTotalLabel.Name = "_woundTotalLabel";
            this._woundTotalLabel.Size = new System.Drawing.Size(74, 13);
            this._woundTotalLabel.TabIndex = 20;
            this._woundTotalLabel.Text = "Total Wounds";
            // 
            // _woundsTotalNum
            // 
            this._woundsTotalNum.AutoSize = true;
            this._woundsTotalNum.Location = new System.Drawing.Point(434, 236);
            this._woundsTotalNum.Name = "_woundsTotalNum";
            this._woundsTotalNum.Size = new System.Drawing.Size(13, 13);
            this._woundsTotalNum.TabIndex = 21;
            this._woundsTotalNum.Text = "0";
            // 
            // _damageResultsLabel
            // 
            this._damageResultsLabel.AutoSize = true;
            this._damageResultsLabel.Location = new System.Drawing.Point(670, 214);
            this._damageResultsLabel.Name = "_damageResultsLabel";
            this._damageResultsLabel.Size = new System.Drawing.Size(85, 13);
            this._damageResultsLabel.TabIndex = 22;
            this._damageResultsLabel.Text = "Damage Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Damge";
            // 
            // _damageTotalNum
            // 
            this._damageTotalNum.AutoSize = true;
            this._damageTotalNum.Location = new System.Drawing.Point(761, 236);
            this._damageTotalNum.Name = "_damageTotalNum";
            this._damageTotalNum.Size = new System.Drawing.Size(13, 13);
            this._damageTotalNum.TabIndex = 24;
            this._damageTotalNum.Text = "0";
            // 
            // _atkWsBsLabel
            // 
            this._atkWsBsLabel.AutoSize = true;
            this._atkWsBsLabel.Location = new System.Drawing.Point(5, 43);
            this._atkWsBsLabel.Name = "_atkWsBsLabel";
            this._atkWsBsLabel.Size = new System.Drawing.Size(44, 13);
            this._atkWsBsLabel.TabIndex = 25;
            this._atkWsBsLabel.Text = "WS/BS";
            // 
            // _atkWsBsBox
            // 
            this._atkWsBsBox.Location = new System.Drawing.Point(58, 39);
            this._atkWsBsBox.Mask = "0";
            this._atkWsBsBox.Name = "_atkWsBsBox";
            this._atkWsBsBox.Size = new System.Drawing.Size(52, 20);
            this._atkWsBsBox.TabIndex = 26;
            // 
            // _atkShotsLabel
            // 
            this._atkShotsLabel.AutoSize = true;
            this._atkShotsLabel.Location = new System.Drawing.Point(5, 69);
            this._atkShotsLabel.Name = "_atkShotsLabel";
            this._atkShotsLabel.Size = new System.Drawing.Size(34, 13);
            this._atkShotsLabel.TabIndex = 27;
            this._atkShotsLabel.Text = "Shots";
            // 
            // _atkShotsBox
            // 
            this._atkShotsBox.Location = new System.Drawing.Point(57, 66);
            this._atkShotsBox.Mask = "000";
            this._atkShotsBox.Name = "_atkShotsBox";
            this._atkShotsBox.Size = new System.Drawing.Size(52, 20);
            this._atkShotsBox.TabIndex = 28;
            // 
            // _saveResultsLabel
            // 
            this._saveResultsLabel.AutoSize = true;
            this._saveResultsLabel.Location = new System.Drawing.Point(514, 214);
            this._saveResultsLabel.Name = "_saveResultsLabel";
            this._saveResultsLabel.Size = new System.Drawing.Size(70, 13);
            this._saveResultsLabel.TabIndex = 29;
            this._saveResultsLabel.Text = "Save Results";
            // 
            // _failedSavesLabel
            // 
            this._failedSavesLabel.AutoSize = true;
            this._failedSavesLabel.Location = new System.Drawing.Point(594, 214);
            this._failedSavesLabel.Name = "_failedSavesLabel";
            this._failedSavesLabel.Size = new System.Drawing.Size(68, 13);
            this._failedSavesLabel.TabIndex = 30;
            this._failedSavesLabel.Text = "Failed Saves";
            // 
            // _failedSavesNum
            // 
            this._failedSavesNum.AutoSize = true;
            this._failedSavesNum.Location = new System.Drawing.Point(594, 236);
            this._failedSavesNum.Name = "_failedSavesNum";
            this._failedSavesNum.Size = new System.Drawing.Size(13, 13);
            this._failedSavesNum.TabIndex = 31;
            this._failedSavesNum.Text = "0";
            // 
            // _invulSaveLabel
            // 
            this._invulSaveLabel.AutoSize = true;
            this._invulSaveLabel.Location = new System.Drawing.Point(204, 99);
            this._invulSaveLabel.Name = "_invulSaveLabel";
            this._invulSaveLabel.Size = new System.Drawing.Size(58, 13);
            this._invulSaveLabel.TabIndex = 32;
            this._invulSaveLabel.Text = "Invul Save";
            // 
            // _invulSaveBox
            // 
            this._invulSaveBox.Location = new System.Drawing.Point(293, 95);
            this._invulSaveBox.Mask = "0";
            this._invulSaveBox.Name = "_invulSaveBox";
            this._invulSaveBox.Size = new System.Drawing.Size(52, 20);
            this._invulSaveBox.TabIndex = 33;
            // 
            // _geqButton
            // 
            this._geqButton.Location = new System.Drawing.Point(474, 45);
            this._geqButton.Name = "_geqButton";
            this._geqButton.Size = new System.Drawing.Size(75, 23);
            this._geqButton.TabIndex = 34;
            this._geqButton.Text = "GEQ";
            this._geqButton.UseVisualStyleBackColor = true;
            this._geqButton.Click += new System.EventHandler(this._geqButton_Click);
            // 
            // _fillsLabel
            // 
            this._fillsLabel.AutoSize = true;
            this._fillsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._fillsLabel.Location = new System.Drawing.Point(616, 22);
            this._fillsLabel.Name = "_fillsLabel";
            this._fillsLabel.Size = new System.Drawing.Size(36, 20);
            this._fillsLabel.TabIndex = 35;
            this._fillsLabel.Text = "Fills";
            // 
            // _meqButton
            // 
            this._meqButton.Location = new System.Drawing.Point(555, 45);
            this._meqButton.Name = "_meqButton";
            this._meqButton.Size = new System.Drawing.Size(75, 23);
            this._meqButton.TabIndex = 36;
            this._meqButton.Text = "MEQ";
            this._meqButton.UseVisualStyleBackColor = true;
            this._meqButton.Click += new System.EventHandler(this._meqButton_Click);
            // 
            // _teqButton
            // 
            this._teqButton.Location = new System.Drawing.Point(636, 45);
            this._teqButton.Name = "_teqButton";
            this._teqButton.Size = new System.Drawing.Size(75, 23);
            this._teqButton.TabIndex = 37;
            this._teqButton.Text = "TEQ";
            this._teqButton.UseVisualStyleBackColor = true;
            this._teqButton.Click += new System.EventHandler(this._teqButton_Click);
            // 
            // _keqButton
            // 
            this._keqButton.Location = new System.Drawing.Point(798, 45);
            this._keqButton.Name = "_keqButton";
            this._keqButton.Size = new System.Drawing.Size(75, 23);
            this._keqButton.TabIndex = 38;
            this._keqButton.Text = "KEQ";
            this._keqButton.UseVisualStyleBackColor = true;
            this._keqButton.Click += new System.EventHandler(this._keqButton_Click);
            // 
            // _veqButton
            // 
            this._veqButton.Location = new System.Drawing.Point(717, 45);
            this._veqButton.Name = "_veqButton";
            this._veqButton.Size = new System.Drawing.Size(75, 23);
            this._veqButton.TabIndex = 39;
            this._veqButton.Text = "VEQ";
            this._veqButton.UseVisualStyleBackColor = true;
            this._veqButton.Click += new System.EventHandler(this._veqButton_Click);
            // 
            // _woundPerModelLabel
            // 
            this._woundPerModelLabel.AutoSize = true;
            this._woundPerModelLabel.Location = new System.Drawing.Point(204, 128);
            this._woundPerModelLabel.Name = "_woundPerModelLabel";
            this._woundPerModelLabel.Size = new System.Drawing.Size(80, 13);
            this._woundPerModelLabel.TabIndex = 40;
            this._woundPerModelLabel.Text = "Wounds/model";
            // 
            // _woundsPerModelBox
            // 
            this._woundsPerModelBox.Location = new System.Drawing.Point(293, 125);
            this._woundsPerModelBox.Mask = "00";
            this._woundsPerModelBox.Name = "_woundsPerModelBox";
            this._woundsPerModelBox.Size = new System.Drawing.Size(52, 20);
            this._woundsPerModelBox.TabIndex = 41;
            // 
            // _noRerollRadio
            // 
            this._noRerollRadio.AutoSize = true;
            this._noRerollRadio.Location = new System.Drawing.Point(12, 41);
            this._noRerollRadio.Name = "_noRerollRadio";
            this._noRerollRadio.Size = new System.Drawing.Size(69, 17);
            this._noRerollRadio.TabIndex = 42;
            this._noRerollRadio.TabStop = true;
            this._noRerollRadio.Text = "No rerolls";
            this._noRerollRadio.UseVisualStyleBackColor = true;
            // 
            // _modifersPanel
            // 
            this._modifersPanel.Controls.Add(this.panel1);
            this._modifersPanel.Controls.Add(this._rerollMisses);
            this._modifersPanel.Controls.Add(this._rerollOnesRadio);
            this._modifersPanel.Controls.Add(this.label1);
            this._modifersPanel.Controls.Add(this._noRerollRadio);
            this._modifersPanel.Location = new System.Drawing.Point(909, 24);
            this._modifersPanel.Name = "_modifersPanel";
            this._modifersPanel.Size = new System.Drawing.Size(331, 176);
            this._modifersPanel.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._rerollWoundsRadio);
            this.panel1.Controls.Add(this._normalWoundingRadio);
            this.panel1.Location = new System.Drawing.Point(104, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 65);
            this.panel1.TabIndex = 44;
            // 
            // _rerollWoundsRadio
            // 
            this._rerollWoundsRadio.AutoSize = true;
            this._rerollWoundsRadio.Location = new System.Drawing.Point(3, 33);
            this._rerollWoundsRadio.Name = "_rerollWoundsRadio";
            this._rerollWoundsRadio.Size = new System.Drawing.Size(92, 17);
            this._rerollWoundsRadio.TabIndex = 48;
            this._rerollWoundsRadio.TabStop = true;
            this._rerollWoundsRadio.Text = "Reroll wounds";
            this._rerollWoundsRadio.UseVisualStyleBackColor = true;
            // 
            // _normalWoundingRadio
            // 
            this._normalWoundingRadio.AutoSize = true;
            this._normalWoundingRadio.Location = new System.Drawing.Point(3, 10);
            this._normalWoundingRadio.Name = "_normalWoundingRadio";
            this._normalWoundingRadio.Size = new System.Drawing.Size(107, 17);
            this._normalWoundingRadio.TabIndex = 47;
            this._normalWoundingRadio.TabStop = true;
            this._normalWoundingRadio.Text = "Normal wounding";
            this._normalWoundingRadio.UseVisualStyleBackColor = true;
            // 
            // _rerollMisses
            // 
            this._rerollMisses.AutoSize = true;
            this._rerollMisses.Location = new System.Drawing.Point(12, 90);
            this._rerollMisses.Name = "_rerollMisses";
            this._rerollMisses.Size = new System.Drawing.Size(86, 17);
            this._rerollMisses.TabIndex = 46;
            this._rerollMisses.TabStop = true;
            this._rerollMisses.Text = "Reroll misses";
            this._rerollMisses.UseVisualStyleBackColor = true;
            // 
            // _rerollOnesRadio
            // 
            this._rerollOnesRadio.AutoSize = true;
            this._rerollOnesRadio.Location = new System.Drawing.Point(12, 67);
            this._rerollOnesRadio.Name = "_rerollOnesRadio";
            this._rerollOnesRadio.Size = new System.Drawing.Size(66, 17);
            this._rerollOnesRadio.TabIndex = 45;
            this._rerollOnesRadio.TabStop = true;
            this._rerollOnesRadio.Text = "Reroll 1s";
            this._rerollOnesRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Modifiers";
            // 
            // _hitRerollsLabel
            // 
            this._hitRerollsLabel.AutoSize = true;
            this._hitRerollsLabel.Location = new System.Drawing.Point(94, 214);
            this._hitRerollsLabel.Name = "_hitRerollsLabel";
            this._hitRerollsLabel.Size = new System.Drawing.Size(50, 13);
            this._hitRerollsLabel.TabIndex = 44;
            this._hitRerollsLabel.Text = "Hit rerolls";
            // 
            // _finalHitsLabel
            // 
            this._finalHitsLabel.AutoSize = true;
            this._finalHitsLabel.Location = new System.Drawing.Point(161, 214);
            this._finalHitsLabel.Name = "_finalHitsLabel";
            this._finalHitsLabel.Size = new System.Drawing.Size(58, 13);
            this._finalHitsLabel.TabIndex = 45;
            this._finalHitsLabel.Text = "Final hit list";
            // 
            // MathHammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this._finalHitsLabel);
            this.Controls.Add(this._hitRerollsLabel);
            this.Controls.Add(this._modifersPanel);
            this.Controls.Add(this._woundsPerModelBox);
            this.Controls.Add(this._woundPerModelLabel);
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
            this.Controls.Add(this._InitialhitResults);
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
            this._modifersPanel.ResumeLayout(false);
            this._modifersPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label _InitialhitResults;
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
        private System.Windows.Forms.Label _woundPerModelLabel;
        private System.Windows.Forms.MaskedTextBox _woundsPerModelBox;
        private System.Windows.Forms.RadioButton _noRerollRadio;
        private System.Windows.Forms.Panel _modifersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton _rerollMisses;
        private System.Windows.Forms.RadioButton _rerollOnesRadio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton _rerollWoundsRadio;
        private System.Windows.Forms.RadioButton _normalWoundingRadio;
        private System.Windows.Forms.Label _hitRerollsLabel;
        private System.Windows.Forms.Label _finalHitsLabel;
    }
}


﻿namespace WarhammerCalcUI
{
    partial class Ui
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
            this._atkAPBox = new System.Windows.Forms.MaskedTextBox();
            this._atkDamgeLabel = new System.Windows.Forms.Label();
            this._atkDamageDiceAmount = new System.Windows.Forms.MaskedTextBox();
            this._atkDiceDType = new System.Windows.Forms.MaskedTextBox();
            this._defSave = new System.Windows.Forms.MaskedTextBox();
            this._defToughness = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_defLabel = new System.Windows.Forms.Label();
            this._rollButton = new System.Windows.Forms.Button();
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
            this._atkVariableShotsNumberBox = new System.Windows.Forms.MaskedTextBox();
            this._totalFailedSavesLabel = new System.Windows.Forms.Label();
            this._failedSavesNum = new System.Windows.Forms.Label();
            this._invulSaveLabel = new System.Windows.Forms.Label();
            this._invulSaveBox = new System.Windows.Forms.MaskedTextBox();
            this._noRerollHitRadio = new System.Windows.Forms.RadioButton();
            this._modifersPanel = new System.Windows.Forms.Panel();
            this.woundPanel = new System.Windows.Forms.Panel();
            this._woundMortalOnXBox = new System.Windows.Forms.MaskedTextBox();
            this._woundOnXRadio = new System.Windows.Forms.RadioButton();
            this._woundOnXBox = new System.Windows.Forms.MaskedTextBox();
            this._woundMortalOnXRadio = new System.Windows.Forms.RadioButton();
            this._woundingUseStandardRadio = new System.Windows.Forms.RadioButton();
            this._damagePanel = new System.Windows.Forms.Panel();
            this._xResolveNormallyRadio = new System.Windows.Forms.RadioButton();
            this._xResolveDamageDamageValue = new System.Windows.Forms.MaskedTextBox();
            this._xResolveDamageHitValue = new System.Windows.Forms.MaskedTextBox();
            this._xResolveApApValue = new System.Windows.Forms.MaskedTextBox();
            this._xResolveApWoundValue = new System.Windows.Forms.MaskedTextBox();
            this._xResolveDamageRadio = new System.Windows.Forms.RadioButton();
            this._xResolveApRadio = new System.Windows.Forms.RadioButton();
            this._teslaCheckbox = new System.Windows.Forms.CheckBox();
            this._teslaPanel = new System.Windows.Forms.Panel();
            this._autoHitCheckbox = new System.Windows.Forms.CheckBox();
            this._hitPanel = new System.Windows.Forms.Panel();
            this._rerollMissesRadio = new System.Windows.Forms.RadioButton();
            this._rerollOnesRadio = new System.Windows.Forms.RadioButton();
            this._woundRerollPanel = new System.Windows.Forms.Panel();
            this._rerollWoundsOfOneRadio = new System.Windows.Forms.RadioButton();
            this._rerollFailedWoundsRadio = new System.Windows.Forms.RadioButton();
            this._dontRerollWounds = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this._results = new System.Windows.Forms.Label();
            this._resultsLabel = new System.Windows.Forms.Label();
            this._varableDamageCheckbox = new System.Windows.Forms.CheckBox();
            this._flatDamageBox = new System.Windows.Forms.MaskedTextBox();
            this._variableShotsCheckbox = new System.Windows.Forms.CheckBox();
            this._atkShotsDBox = new System.Windows.Forms.MaskedTextBox();
            this._flatShotsBox = new System.Windows.Forms.MaskedTextBox();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gEQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kEQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._modifersPanel.SuspendLayout();
            this.woundPanel.SuspendLayout();
            this._damagePanel.SuspendLayout();
            this._teslaPanel.SuspendLayout();
            this._hitPanel.SuspendLayout();
            this._woundRerollPanel.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _AtkLabel
            // 
            this._AtkLabel.AutoSize = true;
            this._AtkLabel.Location = new System.Drawing.Point(54, 25);
            this._AtkLabel.Name = "_AtkLabel";
            this._AtkLabel.Size = new System.Drawing.Size(47, 13);
            this._AtkLabel.TabIndex = 0;
            this._AtkLabel.Text = "Attacker";
            // 
            // _atkStrLabel
            // 
            this._atkStrLabel.AutoSize = true;
            this._atkStrLabel.Location = new System.Drawing.Point(4, 129);
            this._atkStrLabel.Name = "_atkStrLabel";
            this._atkStrLabel.Size = new System.Drawing.Size(47, 13);
            this._atkStrLabel.TabIndex = 1;
            this._atkStrLabel.Text = "Strength";
            // 
            // _atkAPLable
            // 
            this._atkAPLable.AutoSize = true;
            this._atkAPLable.Location = new System.Drawing.Point(4, 155);
            this._atkAPLable.Name = "_atkAPLable";
            this._atkAPLable.Size = new System.Drawing.Size(21, 13);
            this._atkAPLable.TabIndex = 2;
            this._atkAPLable.Text = "AP";
            // 
            // _atkStrBox
            // 
            this._atkStrBox.Location = new System.Drawing.Point(57, 126);
            this._atkStrBox.Mask = "00";
            this._atkStrBox.Name = "_atkStrBox";
            this._atkStrBox.Size = new System.Drawing.Size(34, 20);
            this._atkStrBox.TabIndex = 4;
            this._atkStrBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _atkAPBox
            // 
            this._atkAPBox.Location = new System.Drawing.Point(57, 152);
            this._atkAPBox.Mask = "0";
            this._atkAPBox.Name = "_atkAPBox";
            this._atkAPBox.Size = new System.Drawing.Size(34, 20);
            this._atkAPBox.TabIndex = 5;
            this._atkAPBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _atkDamgeLabel
            // 
            this._atkDamgeLabel.AutoSize = true;
            this._atkDamgeLabel.Location = new System.Drawing.Point(4, 192);
            this._atkDamgeLabel.Name = "_atkDamgeLabel";
            this._atkDamgeLabel.Size = new System.Drawing.Size(47, 13);
            this._atkDamgeLabel.TabIndex = 5;
            this._atkDamgeLabel.Text = "Damage";
            // 
            // _atkDamageDiceAmount
            // 
            this._atkDamageDiceAmount.Location = new System.Drawing.Point(57, 215);
            this._atkDamageDiceAmount.Mask = "00";
            this._atkDamageDiceAmount.Name = "_atkDamageDiceAmount";
            this._atkDamageDiceAmount.Size = new System.Drawing.Size(34, 20);
            this._atkDamageDiceAmount.TabIndex = 7;
            this._atkDamageDiceAmount.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _atkDiceDType
            // 
            this._atkDiceDType.Location = new System.Drawing.Point(99, 215);
            this._atkDiceDType.Mask = "00";
            this._atkDiceDType.Name = "_atkDiceDType";
            this._atkDiceDType.Size = new System.Drawing.Size(34, 20);
            this._atkDiceDType.TabIndex = 8;
            this._atkDiceDType.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _defSave
            // 
            this._defSave.Location = new System.Drawing.Point(346, 77);
            this._defSave.Mask = "0";
            this._defSave.Name = "_defSave";
            this._defSave.Size = new System.Drawing.Size(52, 20);
            this._defSave.TabIndex = 10;
            this._defSave.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _defToughness
            // 
            this._defToughness.Location = new System.Drawing.Point(346, 51);
            this._defToughness.Mask = "00";
            this._defToughness.Name = "_defToughness";
            this._defToughness.Size = new System.Drawing.Size(52, 20);
            this._defToughness.TabIndex = 9;
            this._defToughness.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toughness";
            // 
            // m_defLabel
            // 
            this.m_defLabel.AutoSize = true;
            this.m_defLabel.Location = new System.Drawing.Point(347, 32);
            this.m_defLabel.Name = "m_defLabel";
            this.m_defLabel.Size = new System.Drawing.Size(51, 13);
            this.m_defLabel.TabIndex = 8;
            this.m_defLabel.Text = "Defender";
            // 
            // _rollButton
            // 
            this._rollButton.Location = new System.Drawing.Point(296, 193);
            this._rollButton.Name = "_rollButton";
            this._rollButton.Size = new System.Drawing.Size(179, 42);
            this._rollButton.TabIndex = 12;
            this._rollButton.Text = "Roll!";
            this._rollButton.UseVisualStyleBackColor = true;
            this._rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // _totalHitsLabel
            // 
            this._totalHitsLabel.AutoSize = true;
            this._totalHitsLabel.Location = new System.Drawing.Point(679, 213);
            this._totalHitsLabel.Name = "_totalHitsLabel";
            this._totalHitsLabel.Size = new System.Drawing.Size(52, 13);
            this._totalHitsLabel.TabIndex = 18;
            this._totalHitsLabel.Text = "Total Hits";
            // 
            // _totalHitsNum
            // 
            this._totalHitsNum.AutoSize = true;
            this._totalHitsNum.Location = new System.Drawing.Point(679, 235);
            this._totalHitsNum.Name = "_totalHitsNum";
            this._totalHitsNum.Size = new System.Drawing.Size(13, 13);
            this._totalHitsNum.TabIndex = 19;
            this._totalHitsNum.Text = "0";
            // 
            // _woundTotalLabel
            // 
            this._woundTotalLabel.AutoSize = true;
            this._woundTotalLabel.Location = new System.Drawing.Point(737, 213);
            this._woundTotalLabel.Name = "_woundTotalLabel";
            this._woundTotalLabel.Size = new System.Drawing.Size(74, 13);
            this._woundTotalLabel.TabIndex = 20;
            this._woundTotalLabel.Text = "Total Wounds";
            // 
            // _woundsTotalNum
            // 
            this._woundsTotalNum.AutoSize = true;
            this._woundsTotalNum.Location = new System.Drawing.Point(737, 235);
            this._woundsTotalNum.Name = "_woundsTotalNum";
            this._woundsTotalNum.Size = new System.Drawing.Size(13, 13);
            this._woundsTotalNum.TabIndex = 21;
            this._woundsTotalNum.Text = "0";
            // 
            // _damageResultsLabel
            // 
            this._damageResultsLabel.AutoSize = true;
            this._damageResultsLabel.Location = new System.Drawing.Point(918, 213);
            this._damageResultsLabel.Name = "_damageResultsLabel";
            this._damageResultsLabel.Size = new System.Drawing.Size(138, 13);
            this._damageResultsLabel.TabIndex = 22;
            this._damageResultsLabel.Text = "Damage By Wound Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1119, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Damge";
            // 
            // _damageTotalNum
            // 
            this._damageTotalNum.AutoSize = true;
            this._damageTotalNum.Location = new System.Drawing.Point(1119, 235);
            this._damageTotalNum.Name = "_damageTotalNum";
            this._damageTotalNum.Size = new System.Drawing.Size(13, 13);
            this._damageTotalNum.TabIndex = 24;
            this._damageTotalNum.Text = "0";
            // 
            // _atkWsBsLabel
            // 
            this._atkWsBsLabel.AutoSize = true;
            this._atkWsBsLabel.Location = new System.Drawing.Point(7, 51);
            this._atkWsBsLabel.Name = "_atkWsBsLabel";
            this._atkWsBsLabel.Size = new System.Drawing.Size(44, 13);
            this._atkWsBsLabel.TabIndex = 25;
            this._atkWsBsLabel.Text = "WS/BS";
            // 
            // _atkWsBsBox
            // 
            this._atkWsBsBox.Location = new System.Drawing.Point(57, 48);
            this._atkWsBsBox.Mask = "0";
            this._atkWsBsBox.Name = "_atkWsBsBox";
            this._atkWsBsBox.Size = new System.Drawing.Size(34, 20);
            this._atkWsBsBox.TabIndex = 0;
            this._atkWsBsBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _atkShotsLabel
            // 
            this._atkShotsLabel.AutoSize = true;
            this._atkShotsLabel.Location = new System.Drawing.Point(7, 81);
            this._atkShotsLabel.Name = "_atkShotsLabel";
            this._atkShotsLabel.Size = new System.Drawing.Size(34, 13);
            this._atkShotsLabel.TabIndex = 27;
            this._atkShotsLabel.Text = "Shots";
            // 
            // _atkVariableShotsNumberBox
            // 
            this._atkVariableShotsNumberBox.Location = new System.Drawing.Point(57, 100);
            this._atkVariableShotsNumberBox.Mask = "000";
            this._atkVariableShotsNumberBox.Name = "_atkVariableShotsNumberBox";
            this._atkVariableShotsNumberBox.Size = new System.Drawing.Size(35, 20);
            this._atkVariableShotsNumberBox.TabIndex = 2;
            this._atkVariableShotsNumberBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _totalFailedSavesLabel
            // 
            this._totalFailedSavesLabel.AutoSize = true;
            this._totalFailedSavesLabel.Location = new System.Drawing.Point(817, 213);
            this._totalFailedSavesLabel.Name = "_totalFailedSavesLabel";
            this._totalFailedSavesLabel.Size = new System.Drawing.Size(95, 13);
            this._totalFailedSavesLabel.TabIndex = 30;
            this._totalFailedSavesLabel.Text = "Total Failed Saves";
            // 
            // _failedSavesNum
            // 
            this._failedSavesNum.AutoSize = true;
            this._failedSavesNum.Location = new System.Drawing.Point(817, 235);
            this._failedSavesNum.Name = "_failedSavesNum";
            this._failedSavesNum.Size = new System.Drawing.Size(13, 13);
            this._failedSavesNum.TabIndex = 31;
            this._failedSavesNum.Text = "0";
            // 
            // _invulSaveLabel
            // 
            this._invulSaveLabel.AutoSize = true;
            this._invulSaveLabel.Location = new System.Drawing.Point(256, 107);
            this._invulSaveLabel.Name = "_invulSaveLabel";
            this._invulSaveLabel.Size = new System.Drawing.Size(58, 13);
            this._invulSaveLabel.TabIndex = 32;
            this._invulSaveLabel.Text = "Invul Save";
            // 
            // _invulSaveBox
            // 
            this._invulSaveBox.Location = new System.Drawing.Point(345, 103);
            this._invulSaveBox.Mask = "0";
            this._invulSaveBox.Name = "_invulSaveBox";
            this._invulSaveBox.Size = new System.Drawing.Size(52, 20);
            this._invulSaveBox.TabIndex = 11;
            this._invulSaveBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _noRerollHitRadio
            // 
            this._noRerollHitRadio.AutoSize = true;
            this._noRerollHitRadio.Location = new System.Drawing.Point(6, 3);
            this._noRerollHitRadio.Name = "_noRerollHitRadio";
            this._noRerollHitRadio.Size = new System.Drawing.Size(69, 17);
            this._noRerollHitRadio.TabIndex = 42;
            this._noRerollHitRadio.TabStop = true;
            this._noRerollHitRadio.Text = "No rerolls";
            this._noRerollHitRadio.UseVisualStyleBackColor = true;
            // 
            // _modifersPanel
            // 
            this._modifersPanel.Controls.Add(this.woundPanel);
            this._modifersPanel.Controls.Add(this._damagePanel);
            this._modifersPanel.Controls.Add(this._teslaCheckbox);
            this._modifersPanel.Controls.Add(this._teslaPanel);
            this._modifersPanel.Controls.Add(this._hitPanel);
            this._modifersPanel.Controls.Add(this._woundRerollPanel);
            this._modifersPanel.Controls.Add(this.label1);
            this._modifersPanel.Location = new System.Drawing.Point(405, 27);
            this._modifersPanel.Name = "_modifersPanel";
            this._modifersPanel.Size = new System.Drawing.Size(847, 152);
            this._modifersPanel.TabIndex = 43;
            // 
            // woundPanel
            // 
            this.woundPanel.Controls.Add(this._woundMortalOnXBox);
            this.woundPanel.Controls.Add(this._woundOnXRadio);
            this.woundPanel.Controls.Add(this._woundOnXBox);
            this.woundPanel.Controls.Add(this._woundMortalOnXRadio);
            this.woundPanel.Controls.Add(this._woundingUseStandardRadio);
            this.woundPanel.Location = new System.Drawing.Point(403, 37);
            this.woundPanel.Name = "woundPanel";
            this.woundPanel.Size = new System.Drawing.Size(161, 77);
            this.woundPanel.TabIndex = 48;
            // 
            // _woundMortalOnXBox
            // 
            this._woundMortalOnXBox.Location = new System.Drawing.Point(123, 48);
            this._woundMortalOnXBox.Mask = "0";
            this._woundMortalOnXBox.Name = "_woundMortalOnXBox";
            this._woundMortalOnXBox.Size = new System.Drawing.Size(20, 20);
            this._woundMortalOnXBox.TabIndex = 53;
            this._woundMortalOnXBox.Text = "0";
            this._woundMortalOnXBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _woundOnXRadio
            // 
            this._woundOnXRadio.AutoSize = true;
            this._woundOnXRadio.Location = new System.Drawing.Point(3, 29);
            this._woundOnXRadio.Name = "_woundOnXRadio";
            this._woundOnXRadio.Size = new System.Drawing.Size(101, 17);
            this._woundOnXRadio.TabIndex = 52;
            this._woundOnXRadio.TabStop = true;
            this._woundOnXRadio.Text = "Wound on X roll";
            this._woundOnXRadio.UseVisualStyleBackColor = true;
            this._woundOnXRadio.CheckedChanged += new System.EventHandler(this.WoundRollXRadioChanged);
            // 
            // _woundOnXBox
            // 
            this._woundOnXBox.Location = new System.Drawing.Point(123, 24);
            this._woundOnXBox.Mask = "0";
            this._woundOnXBox.Name = "_woundOnXBox";
            this._woundOnXBox.Size = new System.Drawing.Size(20, 20);
            this._woundOnXBox.TabIndex = 51;
            this._woundOnXBox.Text = "0";
            this._woundOnXBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _woundMortalOnXRadio
            // 
            this._woundMortalOnXRadio.AutoSize = true;
            this._woundMortalOnXRadio.Location = new System.Drawing.Point(3, 53);
            this._woundMortalOnXRadio.Name = "_woundMortalOnXRadio";
            this._woundMortalOnXRadio.Size = new System.Drawing.Size(114, 17);
            this._woundMortalOnXRadio.TabIndex = 49;
            this._woundMortalOnXRadio.TabStop = true;
            this._woundMortalOnXRadio.Text = "Mortal wound on X";
            this._woundMortalOnXRadio.UseVisualStyleBackColor = true;
            this._woundMortalOnXRadio.CheckedChanged += new System.EventHandler(this.MortalWoundOnXRadioChanged);
            // 
            // _woundingUseStandardRadio
            // 
            this._woundingUseStandardRadio.AutoSize = true;
            this._woundingUseStandardRadio.Location = new System.Drawing.Point(3, 5);
            this._woundingUseStandardRadio.Name = "_woundingUseStandardRadio";
            this._woundingUseStandardRadio.Size = new System.Drawing.Size(117, 17);
            this._woundingUseStandardRadio.TabIndex = 48;
            this._woundingUseStandardRadio.TabStop = true;
            this._woundingUseStandardRadio.Text = "Standard wounding";
            this._woundingUseStandardRadio.UseVisualStyleBackColor = true;
            // 
            // _damagePanel
            // 
            this._damagePanel.Controls.Add(this._xResolveNormallyRadio);
            this._damagePanel.Controls.Add(this._xResolveDamageDamageValue);
            this._damagePanel.Controls.Add(this._xResolveDamageHitValue);
            this._damagePanel.Controls.Add(this._xResolveApApValue);
            this._damagePanel.Controls.Add(this._xResolveApWoundValue);
            this._damagePanel.Controls.Add(this._xResolveDamageRadio);
            this._damagePanel.Controls.Add(this._xResolveApRadio);
            this._damagePanel.Location = new System.Drawing.Point(570, 37);
            this._damagePanel.Name = "_damagePanel";
            this._damagePanel.Size = new System.Drawing.Size(274, 77);
            this._damagePanel.TabIndex = 53;
            // 
            // _xResolveNormallyRadio
            // 
            this._xResolveNormallyRadio.AutoSize = true;
            this._xResolveNormallyRadio.Location = new System.Drawing.Point(4, 6);
            this._xResolveNormallyRadio.Name = "_xResolveNormallyRadio";
            this._xResolveNormallyRadio.Size = new System.Drawing.Size(107, 17);
            this._xResolveNormallyRadio.TabIndex = 59;
            this._xResolveNormallyRadio.TabStop = true;
            this._xResolveNormallyRadio.Text = "Resolve Normally";
            this._xResolveNormallyRadio.UseVisualStyleBackColor = true;
            // 
            // _xResolveDamageDamageValue
            // 
            this._xResolveDamageDamageValue.Location = new System.Drawing.Point(232, 54);
            this._xResolveDamageDamageValue.Mask = "0";
            this._xResolveDamageDamageValue.Name = "_xResolveDamageDamageValue";
            this._xResolveDamageDamageValue.Size = new System.Drawing.Size(28, 20);
            this._xResolveDamageDamageValue.TabIndex = 58;
            this._xResolveDamageDamageValue.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _xResolveDamageHitValue
            // 
            this._xResolveDamageHitValue.Location = new System.Drawing.Point(196, 53);
            this._xResolveDamageHitValue.Mask = "0";
            this._xResolveDamageHitValue.Name = "_xResolveDamageHitValue";
            this._xResolveDamageHitValue.Size = new System.Drawing.Size(30, 20);
            this._xResolveDamageHitValue.TabIndex = 57;
            this._xResolveDamageHitValue.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _xResolveApApValue
            // 
            this._xResolveApApValue.Location = new System.Drawing.Point(208, 29);
            this._xResolveApApValue.Mask = "0";
            this._xResolveApApValue.Name = "_xResolveApApValue";
            this._xResolveApApValue.Size = new System.Drawing.Size(30, 20);
            this._xResolveApApValue.TabIndex = 56;
            this._xResolveApApValue.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _xResolveApWoundValue
            // 
            this._xResolveApWoundValue.Location = new System.Drawing.Point(172, 29);
            this._xResolveApWoundValue.Mask = "0";
            this._xResolveApWoundValue.Name = "_xResolveApWoundValue";
            this._xResolveApWoundValue.Size = new System.Drawing.Size(30, 20);
            this._xResolveApWoundValue.TabIndex = 53;
            this._xResolveApWoundValue.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _xResolveDamageRadio
            // 
            this._xResolveDamageRadio.AutoSize = true;
            this._xResolveDamageRadio.Location = new System.Drawing.Point(3, 54);
            this._xResolveDamageRadio.Name = "_xResolveDamageRadio";
            this._xResolveDamageRadio.Size = new System.Drawing.Size(187, 17);
            this._xResolveDamageRadio.TabIndex = 55;
            this._xResolveDamageRadio.TabStop = true;
            this._xResolveDamageRadio.Text = "Wound of X resolves at damage Y";
            this._xResolveDamageRadio.UseVisualStyleBackColor = true;
            this._xResolveDamageRadio.CheckedChanged += new System.EventHandler(this._xResolveDamageRadio_CheckedChanged);
            // 
            // _xResolveApRadio
            // 
            this._xResolveApRadio.AutoSize = true;
            this._xResolveApRadio.Location = new System.Drawing.Point(3, 29);
            this._xResolveApRadio.Name = "_xResolveApRadio";
            this._xResolveApRadio.Size = new System.Drawing.Size(163, 17);
            this._xResolveApRadio.TabIndex = 54;
            this._xResolveApRadio.TabStop = true;
            this._xResolveApRadio.Text = "Wound of X resolves at AP Y";
            this._xResolveApRadio.UseVisualStyleBackColor = true;
            this._xResolveApRadio.CheckedChanged += new System.EventHandler(this._xResolveApRadio_CheckedChanged);
            // 
            // _teslaCheckbox
            // 
            this._teslaCheckbox.AutoSize = true;
            this._teslaCheckbox.Location = new System.Drawing.Point(20, 118);
            this._teslaCheckbox.Name = "_teslaCheckbox";
            this._teslaCheckbox.Size = new System.Drawing.Size(110, 17);
            this._teslaCheckbox.TabIndex = 48;
            this._teslaCheckbox.Text = "Is Tesla weapon?";
            this._teslaCheckbox.UseVisualStyleBackColor = true;
            // 
            // _teslaPanel
            // 
            this._teslaPanel.Controls.Add(this._autoHitCheckbox);
            this._teslaPanel.Location = new System.Drawing.Point(140, 35);
            this._teslaPanel.Name = "_teslaPanel";
            this._teslaPanel.Size = new System.Drawing.Size(112, 75);
            this._teslaPanel.TabIndex = 48;
            // 
            // _autoHitCheckbox
            // 
            this._autoHitCheckbox.AutoSize = true;
            this._autoHitCheckbox.Location = new System.Drawing.Point(3, 5);
            this._autoHitCheckbox.Name = "_autoHitCheckbox";
            this._autoHitCheckbox.Size = new System.Drawing.Size(59, 17);
            this._autoHitCheckbox.TabIndex = 49;
            this._autoHitCheckbox.Text = "Autohit";
            this._autoHitCheckbox.UseVisualStyleBackColor = true;
            // 
            // _hitPanel
            // 
            this._hitPanel.Controls.Add(this._noRerollHitRadio);
            this._hitPanel.Controls.Add(this._rerollMissesRadio);
            this._hitPanel.Controls.Add(this._rerollOnesRadio);
            this._hitPanel.Location = new System.Drawing.Point(14, 34);
            this._hitPanel.Name = "_hitPanel";
            this._hitPanel.Size = new System.Drawing.Size(119, 76);
            this._hitPanel.TabIndex = 48;
            // 
            // _rerollMissesRadio
            // 
            this._rerollMissesRadio.AutoSize = true;
            this._rerollMissesRadio.Location = new System.Drawing.Point(6, 49);
            this._rerollMissesRadio.Name = "_rerollMissesRadio";
            this._rerollMissesRadio.Size = new System.Drawing.Size(86, 17);
            this._rerollMissesRadio.TabIndex = 46;
            this._rerollMissesRadio.TabStop = true;
            this._rerollMissesRadio.Text = "Reroll misses";
            this._rerollMissesRadio.UseVisualStyleBackColor = true;
            // 
            // _rerollOnesRadio
            // 
            this._rerollOnesRadio.AutoSize = true;
            this._rerollOnesRadio.Location = new System.Drawing.Point(6, 26);
            this._rerollOnesRadio.Name = "_rerollOnesRadio";
            this._rerollOnesRadio.Size = new System.Drawing.Size(66, 17);
            this._rerollOnesRadio.TabIndex = 45;
            this._rerollOnesRadio.TabStop = true;
            this._rerollOnesRadio.Text = "Reroll 1s";
            this._rerollOnesRadio.UseVisualStyleBackColor = true;
            // 
            // _woundRerollPanel
            // 
            this._woundRerollPanel.Controls.Add(this._rerollWoundsOfOneRadio);
            this._woundRerollPanel.Controls.Add(this._rerollFailedWoundsRadio);
            this._woundRerollPanel.Controls.Add(this._dontRerollWounds);
            this._woundRerollPanel.Location = new System.Drawing.Point(258, 35);
            this._woundRerollPanel.Name = "_woundRerollPanel";
            this._woundRerollPanel.Size = new System.Drawing.Size(139, 75);
            this._woundRerollPanel.TabIndex = 44;
            // 
            // _rerollWoundsOfOneRadio
            // 
            this._rerollWoundsOfOneRadio.AutoSize = true;
            this._rerollWoundsOfOneRadio.Location = new System.Drawing.Point(3, 31);
            this._rerollWoundsOfOneRadio.Name = "_rerollWoundsOfOneRadio";
            this._rerollWoundsOfOneRadio.Size = new System.Drawing.Size(113, 17);
            this._rerollWoundsOfOneRadio.TabIndex = 49;
            this._rerollWoundsOfOneRadio.TabStop = true;
            this._rerollWoundsOfOneRadio.Text = "Reroll wounds of 1";
            this._rerollWoundsOfOneRadio.UseVisualStyleBackColor = true;
            // 
            // _rerollFailedWoundsRadio
            // 
            this._rerollFailedWoundsRadio.AutoSize = true;
            this._rerollFailedWoundsRadio.Location = new System.Drawing.Point(3, 51);
            this._rerollFailedWoundsRadio.Name = "_rerollFailedWoundsRadio";
            this._rerollFailedWoundsRadio.Size = new System.Drawing.Size(120, 17);
            this._rerollFailedWoundsRadio.TabIndex = 48;
            this._rerollFailedWoundsRadio.TabStop = true;
            this._rerollFailedWoundsRadio.Text = "Reroll failed wounds";
            this._rerollFailedWoundsRadio.UseVisualStyleBackColor = true;
            // 
            // _dontRerollWounds
            // 
            this._dontRerollWounds.AutoSize = true;
            this._dontRerollWounds.Location = new System.Drawing.Point(3, 9);
            this._dontRerollWounds.Name = "_dontRerollWounds";
            this._dontRerollWounds.Size = new System.Drawing.Size(115, 17);
            this._dontRerollWounds.TabIndex = 47;
            this._dontRerollWounds.TabStop = true;
            this._dontRerollWounds.Text = "Don\'t reroll wounds";
            this._dontRerollWounds.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Modifiers";
            // 
            // _results
            // 
            this._results.AutoSize = true;
            this._results.Location = new System.Drawing.Point(1, 252);
            this._results.Name = "_results";
            this._results.Size = new System.Drawing.Size(0, 13);
            this._results.TabIndex = 46;
            // 
            // _resultsLabel
            // 
            this._resultsLabel.AutoSize = true;
            this._resultsLabel.Location = new System.Drawing.Point(3, 246);
            this._resultsLabel.Name = "_resultsLabel";
            this._resultsLabel.Size = new System.Drawing.Size(45, 13);
            this._resultsLabel.TabIndex = 47;
            this._resultsLabel.Text = "Results:";
            // 
            // _varableDamageCheckbox
            // 
            this._varableDamageCheckbox.AutoSize = true;
            this._varableDamageCheckbox.Location = new System.Drawing.Point(148, 193);
            this._varableDamageCheckbox.Name = "_varableDamageCheckbox";
            this._varableDamageCheckbox.Size = new System.Drawing.Size(107, 17);
            this._varableDamageCheckbox.TabIndex = 48;
            this._varableDamageCheckbox.Text = "Variable Damage";
            this._varableDamageCheckbox.UseVisualStyleBackColor = true;
            this._varableDamageCheckbox.CheckedChanged += new System.EventHandler(this.VariableDamageCheckedChanged);
            // 
            // _flatDamageBox
            // 
            this._flatDamageBox.Location = new System.Drawing.Point(57, 190);
            this._flatDamageBox.Mask = "00";
            this._flatDamageBox.Name = "_flatDamageBox";
            this._flatDamageBox.Size = new System.Drawing.Size(34, 20);
            this._flatDamageBox.TabIndex = 6;
            this._flatDamageBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _variableShotsCheckbox
            // 
            this._variableShotsCheckbox.AutoSize = true;
            this._variableShotsCheckbox.Location = new System.Drawing.Point(148, 72);
            this._variableShotsCheckbox.Name = "_variableShotsCheckbox";
            this._variableShotsCheckbox.Size = new System.Drawing.Size(94, 17);
            this._variableShotsCheckbox.TabIndex = 50;
            this._variableShotsCheckbox.Text = "Variable Shots";
            this._variableShotsCheckbox.UseVisualStyleBackColor = true;
            this._variableShotsCheckbox.CheckedChanged += new System.EventHandler(this.VariableShotsCheckChanged);
            // 
            // _atkShotsDBox
            // 
            this._atkShotsDBox.Location = new System.Drawing.Point(99, 101);
            this._atkShotsDBox.Mask = "000";
            this._atkShotsDBox.Name = "_atkShotsDBox";
            this._atkShotsDBox.Size = new System.Drawing.Size(35, 20);
            this._atkShotsDBox.TabIndex = 3;
            this._atkShotsDBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _flatShotsBox
            // 
            this._flatShotsBox.Location = new System.Drawing.Point(57, 74);
            this._flatShotsBox.Mask = "000";
            this._flatShotsBox.Name = "_flatShotsBox";
            this._flatShotsBox.Size = new System.Drawing.Size(34, 20);
            this._flatShotsBox.TabIndex = 1;
            this._flatShotsBox.Click += new System.EventHandler(this.LeftAdjustCursor);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillsToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1264, 24);
            this._menuStrip.TabIndex = 52;
            this._menuStrip.Text = "Menu Strip";
            // 
            // fillsToolStripMenuItem
            // 
            this.fillsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gEQToolStripMenuItem,
            this.mEQToolStripMenuItem,
            this.tEQToolStripMenuItem,
            this.vEQToolStripMenuItem,
            this.kEQToolStripMenuItem});
            this.fillsToolStripMenuItem.Name = "fillsToolStripMenuItem";
            this.fillsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fillsToolStripMenuItem.Text = "Fills";
            // 
            // gEQToolStripMenuItem
            // 
            this.gEQToolStripMenuItem.Name = "gEQToolStripMenuItem";
            this.gEQToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.gEQToolStripMenuItem.Text = "GEQ";
            this.gEQToolStripMenuItem.Click += new System.EventHandler(this.gEQToolStripMenuItem_Click);
            // 
            // mEQToolStripMenuItem
            // 
            this.mEQToolStripMenuItem.Name = "mEQToolStripMenuItem";
            this.mEQToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.mEQToolStripMenuItem.Text = "MEQ";
            this.mEQToolStripMenuItem.Click += new System.EventHandler(this.mEQToolStripMenuItem_Click);
            // 
            // tEQToolStripMenuItem
            // 
            this.tEQToolStripMenuItem.Name = "tEQToolStripMenuItem";
            this.tEQToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.tEQToolStripMenuItem.Text = "TEQ";
            this.tEQToolStripMenuItem.Click += new System.EventHandler(this.tEQToolStripMenuItem_Click);
            // 
            // vEQToolStripMenuItem
            // 
            this.vEQToolStripMenuItem.Name = "vEQToolStripMenuItem";
            this.vEQToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.vEQToolStripMenuItem.Text = "VEQ";
            this.vEQToolStripMenuItem.Click += new System.EventHandler(this.vEQToolStripMenuItem_Click);
            // 
            // kEQToolStripMenuItem
            // 
            this.kEQToolStripMenuItem.Name = "kEQToolStripMenuItem";
            this.kEQToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.kEQToolStripMenuItem.Text = "KEQ";
            this.kEQToolStripMenuItem.Click += new System.EventHandler(this.kEQToolStripMenuItem_Click);
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this._flatShotsBox);
            this.Controls.Add(this._atkShotsDBox);
            this.Controls.Add(this._variableShotsCheckbox);
            this.Controls.Add(this._flatDamageBox);
            this.Controls.Add(this._varableDamageCheckbox);
            this.Controls.Add(this._resultsLabel);
            this.Controls.Add(this._results);
            this.Controls.Add(this._modifersPanel);
            this.Controls.Add(this._invulSaveBox);
            this.Controls.Add(this._invulSaveLabel);
            this.Controls.Add(this._failedSavesNum);
            this.Controls.Add(this._totalFailedSavesLabel);
            this.Controls.Add(this._atkVariableShotsNumberBox);
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
            this.Controls.Add(this._rollButton);
            this.Controls.Add(this._defSave);
            this.Controls.Add(this._defToughness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_defLabel);
            this.Controls.Add(this._atkDiceDType);
            this.Controls.Add(this._atkDamageDiceAmount);
            this.Controls.Add(this._atkDamgeLabel);
            this.Controls.Add(this._atkAPBox);
            this.Controls.Add(this._atkStrBox);
            this.Controls.Add(this._atkAPLable);
            this.Controls.Add(this._atkStrLabel);
            this.Controls.Add(this._AtkLabel);
            this.Controls.Add(this._menuStrip);
            this.Name = "Ui";
            this.Text = "Warhamer Calc";
            this.Load += new System.EventHandler(this.Ui_Load);
            this._modifersPanel.ResumeLayout(false);
            this._modifersPanel.PerformLayout();
            this.woundPanel.ResumeLayout(false);
            this.woundPanel.PerformLayout();
            this._damagePanel.ResumeLayout(false);
            this._damagePanel.PerformLayout();
            this._teslaPanel.ResumeLayout(false);
            this._teslaPanel.PerformLayout();
            this._hitPanel.ResumeLayout(false);
            this._hitPanel.PerformLayout();
            this._woundRerollPanel.ResumeLayout(false);
            this._woundRerollPanel.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _AtkLabel;
        private System.Windows.Forms.Label _atkStrLabel;
        private System.Windows.Forms.Label _atkAPLable;
        private System.Windows.Forms.MaskedTextBox _atkStrBox;
        private System.Windows.Forms.MaskedTextBox _atkAPBox;
        private System.Windows.Forms.Label _atkDamgeLabel;
        private System.Windows.Forms.MaskedTextBox _atkDamageDiceAmount;
        private System.Windows.Forms.MaskedTextBox _atkDiceDType;
        private System.Windows.Forms.MaskedTextBox _defSave;
        private System.Windows.Forms.MaskedTextBox _defToughness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_defLabel;
        private System.Windows.Forms.Button _rollButton;
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
        private System.Windows.Forms.MaskedTextBox _atkVariableShotsNumberBox;
        private System.Windows.Forms.Label _totalFailedSavesLabel;
        private System.Windows.Forms.Label _failedSavesNum;
        private System.Windows.Forms.Label _invulSaveLabel;
        private System.Windows.Forms.MaskedTextBox _invulSaveBox;
        private System.Windows.Forms.RadioButton _noRerollHitRadio;
        private System.Windows.Forms.Panel _modifersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton _rerollMissesRadio;
        private System.Windows.Forms.RadioButton _rerollOnesRadio;
        private System.Windows.Forms.Panel _woundRerollPanel;
        private System.Windows.Forms.RadioButton _rerollFailedWoundsRadio;
        private System.Windows.Forms.RadioButton _dontRerollWounds;
        private System.Windows.Forms.Label _results;
        private System.Windows.Forms.Label _resultsLabel;
        private System.Windows.Forms.RadioButton _rerollWoundsOfOneRadio;
        private System.Windows.Forms.Panel _hitPanel;
        private System.Windows.Forms.Panel _teslaPanel;
        private System.Windows.Forms.CheckBox _teslaCheckbox;
        private System.Windows.Forms.Panel woundPanel;
        private System.Windows.Forms.RadioButton _woundingUseStandardRadio;
        private System.Windows.Forms.MaskedTextBox _woundMortalOnXBox;
        private System.Windows.Forms.RadioButton _woundOnXRadio;
        private System.Windows.Forms.MaskedTextBox _woundOnXBox;
        private System.Windows.Forms.RadioButton _woundMortalOnXRadio;
        private System.Windows.Forms.CheckBox _varableDamageCheckbox;
        private System.Windows.Forms.MaskedTextBox _flatDamageBox;
        private System.Windows.Forms.CheckBox _variableShotsCheckbox;
        private System.Windows.Forms.MaskedTextBox _atkShotsDBox;
        private System.Windows.Forms.MaskedTextBox _flatShotsBox;
        private System.Windows.Forms.CheckBox _autoHitCheckbox;
        private System.Windows.Forms.RadioButton _xResolveApRadio;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gEQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kEQToolStripMenuItem;
        private System.Windows.Forms.Panel _damagePanel;
        private System.Windows.Forms.MaskedTextBox _xResolveApWoundValue;
        private System.Windows.Forms.RadioButton _xResolveDamageRadio;
        private System.Windows.Forms.MaskedTextBox _xResolveApApValue;
        private System.Windows.Forms.MaskedTextBox _xResolveDamageDamageValue;
        private System.Windows.Forms.MaskedTextBox _xResolveDamageHitValue;
        private System.Windows.Forms.RadioButton _xResolveNormallyRadio;
    }
}


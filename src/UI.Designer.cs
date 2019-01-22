namespace MathHammer
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
            this.m_atkAPBox = new System.Windows.Forms.MaskedTextBox();
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
            this._geqButton = new System.Windows.Forms.Button();
            this._fillsLabel = new System.Windows.Forms.Label();
            this._meqButton = new System.Windows.Forms.Button();
            this._teqButton = new System.Windows.Forms.Button();
            this._keqButton = new System.Windows.Forms.Button();
            this._veqButton = new System.Windows.Forms.Button();
            this._noRerollRadio = new System.Windows.Forms.RadioButton();
            this._modifersPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._woundMortalOnXBox = new System.Windows.Forms.MaskedTextBox();
            this._woundOnXRadio = new System.Windows.Forms.RadioButton();
            this._woundOnXBox = new System.Windows.Forms.MaskedTextBox();
            this._woundMortalOnXRadio = new System.Windows.Forms.RadioButton();
            this._woundingUseStandardRadio = new System.Windows.Forms.RadioButton();
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
            this._modifersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this._teslaPanel.SuspendLayout();
            this._hitPanel.SuspendLayout();
            this._woundRerollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _AtkLabel
            // 
            this._AtkLabel.AutoSize = true;
            this._AtkLabel.Location = new System.Drawing.Point(52, 17);
            this._AtkLabel.Name = "_AtkLabel";
            this._AtkLabel.Size = new System.Drawing.Size(47, 13);
            this._AtkLabel.TabIndex = 0;
            this._AtkLabel.Text = "Attacker";
            // 
            // _atkStrLabel
            // 
            this._atkStrLabel.AutoSize = true;
            this._atkStrLabel.Location = new System.Drawing.Point(2, 121);
            this._atkStrLabel.Name = "_atkStrLabel";
            this._atkStrLabel.Size = new System.Drawing.Size(47, 13);
            this._atkStrLabel.TabIndex = 1;
            this._atkStrLabel.Text = "Strength";
            // 
            // _atkAPLable
            // 
            this._atkAPLable.AutoSize = true;
            this._atkAPLable.Location = new System.Drawing.Point(2, 147);
            this._atkAPLable.Name = "_atkAPLable";
            this._atkAPLable.Size = new System.Drawing.Size(21, 13);
            this._atkAPLable.TabIndex = 2;
            this._atkAPLable.Text = "AP";
            // 
            // _atkStrBox
            // 
            this._atkStrBox.Location = new System.Drawing.Point(55, 118);
            this._atkStrBox.Mask = "00";
            this._atkStrBox.Name = "_atkStrBox";
            this._atkStrBox.Size = new System.Drawing.Size(34, 20);
            this._atkStrBox.TabIndex = 4;
            // 
            // m_atkAPBox
            // 
            this.m_atkAPBox.Location = new System.Drawing.Point(55, 144);
            this.m_atkAPBox.Mask = "0";
            this.m_atkAPBox.Name = "m_atkAPBox";
            this.m_atkAPBox.Size = new System.Drawing.Size(34, 20);
            this.m_atkAPBox.TabIndex = 5;
            // 
            // _atkDamgeLabel
            // 
            this._atkDamgeLabel.AutoSize = true;
            this._atkDamgeLabel.Location = new System.Drawing.Point(2, 173);
            this._atkDamgeLabel.Name = "_atkDamgeLabel";
            this._atkDamgeLabel.Size = new System.Drawing.Size(47, 13);
            this._atkDamgeLabel.TabIndex = 5;
            this._atkDamgeLabel.Text = "Damage";
            // 
            // _atkDamageDiceAmount
            // 
            this._atkDamageDiceAmount.Location = new System.Drawing.Point(55, 196);
            this._atkDamageDiceAmount.Mask = "00";
            this._atkDamageDiceAmount.Name = "_atkDamageDiceAmount";
            this._atkDamageDiceAmount.Size = new System.Drawing.Size(34, 20);
            this._atkDamageDiceAmount.TabIndex = 7;
            this._atkDamageDiceAmount.Text = "0";
            // 
            // _atkDiceDType
            // 
            this._atkDiceDType.Location = new System.Drawing.Point(97, 196);
            this._atkDiceDType.Mask = "00";
            this._atkDiceDType.Name = "_atkDiceDType";
            this._atkDiceDType.Size = new System.Drawing.Size(34, 20);
            this._atkDiceDType.TabIndex = 8;
            this._atkDiceDType.Text = "0";
            // 
            // _defSave
            // 
            this._defSave.Location = new System.Drawing.Point(344, 69);
            this._defSave.Mask = "0";
            this._defSave.Name = "_defSave";
            this._defSave.Size = new System.Drawing.Size(52, 20);
            this._defSave.TabIndex = 10;
            // 
            // _defToughness
            // 
            this._defToughness.Location = new System.Drawing.Point(344, 43);
            this._defToughness.Mask = "00";
            this._defToughness.Name = "_defToughness";
            this._defToughness.Size = new System.Drawing.Size(52, 20);
            this._defToughness.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toughness";
            // 
            // m_defLabel
            // 
            this.m_defLabel.AutoSize = true;
            this.m_defLabel.Location = new System.Drawing.Point(345, 24);
            this.m_defLabel.Name = "m_defLabel";
            this.m_defLabel.Size = new System.Drawing.Size(51, 13);
            this.m_defLabel.TabIndex = 8;
            this.m_defLabel.Text = "Defender";
            // 
            // _rollButton
            // 
            this._rollButton.Location = new System.Drawing.Point(294, 174);
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
            this._totalHitsLabel.Location = new System.Drawing.Point(677, 194);
            this._totalHitsLabel.Name = "_totalHitsLabel";
            this._totalHitsLabel.Size = new System.Drawing.Size(52, 13);
            this._totalHitsLabel.TabIndex = 18;
            this._totalHitsLabel.Text = "Total Hits";
            // 
            // _totalHitsNum
            // 
            this._totalHitsNum.AutoSize = true;
            this._totalHitsNum.Location = new System.Drawing.Point(677, 216);
            this._totalHitsNum.Name = "_totalHitsNum";
            this._totalHitsNum.Size = new System.Drawing.Size(13, 13);
            this._totalHitsNum.TabIndex = 19;
            this._totalHitsNum.Text = "0";
            // 
            // _woundTotalLabel
            // 
            this._woundTotalLabel.AutoSize = true;
            this._woundTotalLabel.Location = new System.Drawing.Point(735, 194);
            this._woundTotalLabel.Name = "_woundTotalLabel";
            this._woundTotalLabel.Size = new System.Drawing.Size(74, 13);
            this._woundTotalLabel.TabIndex = 20;
            this._woundTotalLabel.Text = "Total Wounds";
            // 
            // _woundsTotalNum
            // 
            this._woundsTotalNum.AutoSize = true;
            this._woundsTotalNum.Location = new System.Drawing.Point(735, 216);
            this._woundsTotalNum.Name = "_woundsTotalNum";
            this._woundsTotalNum.Size = new System.Drawing.Size(13, 13);
            this._woundsTotalNum.TabIndex = 21;
            this._woundsTotalNum.Text = "0";
            // 
            // _damageResultsLabel
            // 
            this._damageResultsLabel.AutoSize = true;
            this._damageResultsLabel.Location = new System.Drawing.Point(916, 194);
            this._damageResultsLabel.Name = "_damageResultsLabel";
            this._damageResultsLabel.Size = new System.Drawing.Size(138, 13);
            this._damageResultsLabel.TabIndex = 22;
            this._damageResultsLabel.Text = "Damage By Wound Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1117, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Damge";
            // 
            // _damageTotalNum
            // 
            this._damageTotalNum.AutoSize = true;
            this._damageTotalNum.Location = new System.Drawing.Point(1117, 216);
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
            this._atkWsBsBox.Location = new System.Drawing.Point(55, 40);
            this._atkWsBsBox.Mask = "0";
            this._atkWsBsBox.Name = "_atkWsBsBox";
            this._atkWsBsBox.Size = new System.Drawing.Size(34, 20);
            this._atkWsBsBox.TabIndex = 0;
            // 
            // _atkShotsLabel
            // 
            this._atkShotsLabel.AutoSize = true;
            this._atkShotsLabel.Location = new System.Drawing.Point(5, 73);
            this._atkShotsLabel.Name = "_atkShotsLabel";
            this._atkShotsLabel.Size = new System.Drawing.Size(34, 13);
            this._atkShotsLabel.TabIndex = 27;
            this._atkShotsLabel.Text = "Shots";
            // 
            // _atkVariableShotsNumberBox
            // 
            this._atkVariableShotsNumberBox.Location = new System.Drawing.Point(55, 92);
            this._atkVariableShotsNumberBox.Mask = "000";
            this._atkVariableShotsNumberBox.Name = "_atkVariableShotsNumberBox";
            this._atkVariableShotsNumberBox.Size = new System.Drawing.Size(35, 20);
            this._atkVariableShotsNumberBox.TabIndex = 2;
            this._atkVariableShotsNumberBox.Text = "0";
            // 
            // _totalFailedSavesLabel
            // 
            this._totalFailedSavesLabel.AutoSize = true;
            this._totalFailedSavesLabel.Location = new System.Drawing.Point(815, 194);
            this._totalFailedSavesLabel.Name = "_totalFailedSavesLabel";
            this._totalFailedSavesLabel.Size = new System.Drawing.Size(95, 13);
            this._totalFailedSavesLabel.TabIndex = 30;
            this._totalFailedSavesLabel.Text = "Total Failed Saves";
            // 
            // _failedSavesNum
            // 
            this._failedSavesNum.AutoSize = true;
            this._failedSavesNum.Location = new System.Drawing.Point(815, 216);
            this._failedSavesNum.Name = "_failedSavesNum";
            this._failedSavesNum.Size = new System.Drawing.Size(13, 13);
            this._failedSavesNum.TabIndex = 31;
            this._failedSavesNum.Text = "0";
            // 
            // _invulSaveLabel
            // 
            this._invulSaveLabel.AutoSize = true;
            this._invulSaveLabel.Location = new System.Drawing.Point(254, 99);
            this._invulSaveLabel.Name = "_invulSaveLabel";
            this._invulSaveLabel.Size = new System.Drawing.Size(58, 13);
            this._invulSaveLabel.TabIndex = 32;
            this._invulSaveLabel.Text = "Invul Save";
            // 
            // _invulSaveBox
            // 
            this._invulSaveBox.Location = new System.Drawing.Point(343, 95);
            this._invulSaveBox.Mask = "0";
            this._invulSaveBox.Name = "_invulSaveBox";
            this._invulSaveBox.Size = new System.Drawing.Size(52, 20);
            this._invulSaveBox.TabIndex = 11;
            // 
            // _geqButton
            // 
            this._geqButton.Location = new System.Drawing.Point(423, 40);
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
            this._fillsLabel.Location = new System.Drawing.Point(526, 17);
            this._fillsLabel.Name = "_fillsLabel";
            this._fillsLabel.Size = new System.Drawing.Size(36, 20);
            this._fillsLabel.TabIndex = 35;
            this._fillsLabel.Text = "Fills";
            // 
            // _meqButton
            // 
            this._meqButton.Location = new System.Drawing.Point(504, 40);
            this._meqButton.Name = "_meqButton";
            this._meqButton.Size = new System.Drawing.Size(75, 23);
            this._meqButton.TabIndex = 36;
            this._meqButton.Text = "MEQ";
            this._meqButton.UseVisualStyleBackColor = true;
            this._meqButton.Click += new System.EventHandler(this._meqButton_Click);
            // 
            // _teqButton
            // 
            this._teqButton.Location = new System.Drawing.Point(585, 40);
            this._teqButton.Name = "_teqButton";
            this._teqButton.Size = new System.Drawing.Size(75, 23);
            this._teqButton.TabIndex = 37;
            this._teqButton.Text = "TEQ";
            this._teqButton.UseVisualStyleBackColor = true;
            this._teqButton.Click += new System.EventHandler(this._teqButton_Click);
            // 
            // _keqButton
            // 
            this._keqButton.Location = new System.Drawing.Point(544, 71);
            this._keqButton.Name = "_keqButton";
            this._keqButton.Size = new System.Drawing.Size(75, 23);
            this._keqButton.TabIndex = 38;
            this._keqButton.Text = "KEQ";
            this._keqButton.UseVisualStyleBackColor = true;
            this._keqButton.Click += new System.EventHandler(this._keqButton_Click);
            // 
            // _veqButton
            // 
            this._veqButton.Location = new System.Drawing.Point(463, 71);
            this._veqButton.Name = "_veqButton";
            this._veqButton.Size = new System.Drawing.Size(75, 23);
            this._veqButton.TabIndex = 39;
            this._veqButton.Text = "VEQ";
            this._veqButton.UseVisualStyleBackColor = true;
            this._veqButton.Click += new System.EventHandler(this._veqButton_Click);
            // 
            // _noRerollRadio
            // 
            this._noRerollRadio.AutoSize = true;
            this._noRerollRadio.Location = new System.Drawing.Point(6, 3);
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
            this._modifersPanel.Controls.Add(this._teslaCheckbox);
            this._modifersPanel.Controls.Add(this._teslaPanel);
            this._modifersPanel.Controls.Add(this._hitPanel);
            this._modifersPanel.Controls.Add(this._woundRerollPanel);
            this._modifersPanel.Controls.Add(this.label1);
            this._modifersPanel.Location = new System.Drawing.Point(666, 24);
            this._modifersPanel.Name = "_modifersPanel";
            this._modifersPanel.Size = new System.Drawing.Size(586, 147);
            this._modifersPanel.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._woundMortalOnXBox);
            this.panel1.Controls.Add(this._woundOnXRadio);
            this.panel1.Controls.Add(this._woundOnXBox);
            this.panel1.Controls.Add(this._woundMortalOnXRadio);
            this.panel1.Controls.Add(this._woundingUseStandardRadio);
            this.panel1.Location = new System.Drawing.Point(403, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 72);
            this.panel1.TabIndex = 48;
            // 
            // _woundMortalOnXBox
            // 
            this._woundMortalOnXBox.Location = new System.Drawing.Point(123, 48);
            this._woundMortalOnXBox.Mask = "0";
            this._woundMortalOnXBox.Name = "_woundMortalOnXBox";
            this._woundMortalOnXBox.Size = new System.Drawing.Size(20, 20);
            this._woundMortalOnXBox.TabIndex = 53;
            this._woundMortalOnXBox.Text = "0";
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
            this._hitPanel.Controls.Add(this._noRerollRadio);
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
            this.label1.Location = new System.Drawing.Point(243, 7);
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
            this._resultsLabel.Location = new System.Drawing.Point(1, 227);
            this._resultsLabel.Name = "_resultsLabel";
            this._resultsLabel.Size = new System.Drawing.Size(45, 13);
            this._resultsLabel.TabIndex = 47;
            this._resultsLabel.Text = "Results:";
            // 
            // _varableDamageCheckbox
            // 
            this._varableDamageCheckbox.AutoSize = true;
            this._varableDamageCheckbox.Location = new System.Drawing.Point(146, 174);
            this._varableDamageCheckbox.Name = "_varableDamageCheckbox";
            this._varableDamageCheckbox.Size = new System.Drawing.Size(107, 17);
            this._varableDamageCheckbox.TabIndex = 48;
            this._varableDamageCheckbox.Text = "Variable Damage";
            this._varableDamageCheckbox.UseVisualStyleBackColor = true;
            this._varableDamageCheckbox.CheckedChanged += new System.EventHandler(this.VariableDamageCheckedChanged);
            // 
            // _flatDamageBox
            // 
            this._flatDamageBox.Location = new System.Drawing.Point(55, 171);
            this._flatDamageBox.Mask = "00";
            this._flatDamageBox.Name = "_flatDamageBox";
            this._flatDamageBox.Size = new System.Drawing.Size(34, 20);
            this._flatDamageBox.TabIndex = 6;
            this._flatDamageBox.Text = "0";
            // 
            // _variableShotsCheckbox
            // 
            this._variableShotsCheckbox.AutoSize = true;
            this._variableShotsCheckbox.Location = new System.Drawing.Point(146, 64);
            this._variableShotsCheckbox.Name = "_variableShotsCheckbox";
            this._variableShotsCheckbox.Size = new System.Drawing.Size(94, 17);
            this._variableShotsCheckbox.TabIndex = 50;
            this._variableShotsCheckbox.Text = "Variable Shots";
            this._variableShotsCheckbox.UseVisualStyleBackColor = true;
            this._variableShotsCheckbox.CheckedChanged += new System.EventHandler(this.VariableShotsCheckChanged);
            // 
            // _atkShotsDBox
            // 
            this._atkShotsDBox.Location = new System.Drawing.Point(97, 93);
            this._atkShotsDBox.Mask = "000";
            this._atkShotsDBox.Name = "_atkShotsDBox";
            this._atkShotsDBox.Size = new System.Drawing.Size(35, 20);
            this._atkShotsDBox.TabIndex = 3;
            this._atkShotsDBox.Text = "0";
            // 
            // _flatShotsBox
            // 
            this._flatShotsBox.Location = new System.Drawing.Point(55, 66);
            this._flatShotsBox.Mask = "000";
            this._flatShotsBox.Name = "_flatShotsBox";
            this._flatShotsBox.Size = new System.Drawing.Size(34, 20);
            this._flatShotsBox.TabIndex = 1;
            this._flatShotsBox.Text = "0";
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
            this.Controls.Add(this._veqButton);
            this.Controls.Add(this._keqButton);
            this.Controls.Add(this._teqButton);
            this.Controls.Add(this._meqButton);
            this.Controls.Add(this._fillsLabel);
            this.Controls.Add(this._geqButton);
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
            this.Controls.Add(this.m_atkAPBox);
            this.Controls.Add(this._atkStrBox);
            this.Controls.Add(this._atkAPLable);
            this.Controls.Add(this._atkStrLabel);
            this.Controls.Add(this._AtkLabel);
            this.Name = "Ui";
            this.Text = "Math Hammer";
            this.Load += new System.EventHandler(this.Ui_Load);
            this._modifersPanel.ResumeLayout(false);
            this._modifersPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._teslaPanel.ResumeLayout(false);
            this._teslaPanel.PerformLayout();
            this._hitPanel.ResumeLayout(false);
            this._hitPanel.PerformLayout();
            this._woundRerollPanel.ResumeLayout(false);
            this._woundRerollPanel.PerformLayout();
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
        private System.Windows.Forms.Button _geqButton;
        private System.Windows.Forms.Label _fillsLabel;
        private System.Windows.Forms.Button _meqButton;
        private System.Windows.Forms.Button _teqButton;
        private System.Windows.Forms.Button _keqButton;
        private System.Windows.Forms.Button _veqButton;
        private System.Windows.Forms.RadioButton _noRerollRadio;
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
        private System.Windows.Forms.Panel panel1;
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
    }
}


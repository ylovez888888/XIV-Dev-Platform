﻿namespace TowerEx_Assistant
{
    partial class TowerExMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowerExMain));
            this.TPBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.RADLabel = new System.Windows.Forms.Label();
            this.DeltaX = new System.Windows.Forms.Label();
            this.DeltaY = new System.Windows.Forms.Label();
            this.DeltaZ = new System.Windows.Forms.Label();
            this.MultipleX = new System.Windows.Forms.TrackBar();
            this.MultipleY = new System.Windows.Forms.TrackBar();
            this.MultipleZ = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Xvalue = new System.Windows.Forms.Label();
            this.Yvalue = new System.Windows.Forms.Label();
            this.Zvalue = new System.Windows.Forms.Label();
            this.ModeSelect = new System.Windows.Forms.GroupBox();
            this.CheckACS = new System.Windows.Forms.RadioButton();
            this.PCSMode = new System.Windows.Forms.RadioButton();
            this.CCSMode = new System.Windows.Forms.RadioButton();
            this.MultipleP = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Pvalue = new System.Windows.Forms.Label();
            this.RollBackBtn = new System.Windows.Forms.Button();
            this.MaxDistAlert = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DestX = new System.Windows.Forms.Label();
            this.DestY = new System.Windows.Forms.Label();
            this.DestZ = new System.Windows.Forms.Label();
            this.DirectX = new System.Windows.Forms.TextBox();
            this.DirectY = new System.Windows.Forms.TextBox();
            this.DirectZ = new System.Windows.Forms.TextBox();
            this.InputCoord = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CopyCoord = new System.Windows.Forms.Button();
            this.MapIDLabel = new System.Windows.Forms.Label();
            this.CoordLock = new System.Windows.Forms.CheckBox();
            this.checkCtrl = new System.Windows.Forms.CheckBox();
            this.checkShift = new System.Windows.Forms.CheckBox();
            this.HKcombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NewAreaBtn = new System.Windows.Forms.Button();
            this.AddCoordBtn = new System.Windows.Forms.Button();
            this.NetworkStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleZ)).BeginInit();
            this.ModeSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleP)).BeginInit();
            this.InputCoord.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPBtn
            // 
            this.TPBtn.BackColor = System.Drawing.SystemColors.Control;
            this.TPBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TPBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TPBtn.Location = new System.Drawing.Point(958, 687);
            this.TPBtn.Name = "TPBtn";
            this.TPBtn.Size = new System.Drawing.Size(100, 35);
            this.TPBtn.TabIndex = 1;
            this.TPBtn.Text = "传送";
            this.TPBtn.UseVisualStyleBackColor = false;
            this.TPBtn.Click += new System.EventHandler(this.TP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(371, 95);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(54, 27);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "X : 0";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(371, 125);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(53, 27);
            this.YLabel.TabIndex = 4;
            this.YLabel.Text = "Y : 0";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(371, 155);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(53, 27);
            this.ZLabel.TabIndex = 5;
            this.ZLabel.Text = "Z : 0";
            // 
            // RADLabel
            // 
            this.RADLabel.AutoSize = true;
            this.RADLabel.Location = new System.Drawing.Point(507, 201);
            this.RADLabel.Name = "RADLabel";
            this.RADLabel.Size = new System.Drawing.Size(83, 27);
            this.RADLabel.TabIndex = 6;
            this.RADLabel.Text = "RAD : 0";
            // 
            // DeltaX
            // 
            this.DeltaX.AutoSize = true;
            this.DeltaX.Location = new System.Drawing.Point(507, 95);
            this.DeltaX.Name = "DeltaX";
            this.DeltaX.Size = new System.Drawing.Size(66, 27);
            this.DeltaX.TabIndex = 3;
            this.DeltaX.Text = "△X : 0";
            // 
            // DeltaY
            // 
            this.DeltaY.AutoSize = true;
            this.DeltaY.Location = new System.Drawing.Point(507, 125);
            this.DeltaY.Name = "DeltaY";
            this.DeltaY.Size = new System.Drawing.Size(65, 27);
            this.DeltaY.TabIndex = 4;
            this.DeltaY.Text = "△Y : 0";
            // 
            // DeltaZ
            // 
            this.DeltaZ.AutoSize = true;
            this.DeltaZ.Location = new System.Drawing.Point(507, 155);
            this.DeltaZ.Name = "DeltaZ";
            this.DeltaZ.Size = new System.Drawing.Size(65, 27);
            this.DeltaZ.TabIndex = 5;
            this.DeltaZ.Text = "△Z : 0";
            // 
            // MultipleX
            // 
            this.MultipleX.Location = new System.Drawing.Point(420, 312);
            this.MultipleX.Maximum = 100;
            this.MultipleX.Minimum = -100;
            this.MultipleX.Name = "MultipleX";
            this.MultipleX.Size = new System.Drawing.Size(457, 56);
            this.MultipleX.TabIndex = 7;
            this.MultipleX.TickFrequency = 10;
            this.MultipleX.Scroll += new System.EventHandler(this.MultipleX_Scroll);
            // 
            // MultipleY
            // 
            this.MultipleY.Location = new System.Drawing.Point(420, 374);
            this.MultipleY.Maximum = 100;
            this.MultipleY.Minimum = -100;
            this.MultipleY.Name = "MultipleY";
            this.MultipleY.Size = new System.Drawing.Size(457, 56);
            this.MultipleY.TabIndex = 8;
            this.MultipleY.TickFrequency = 10;
            this.MultipleY.Scroll += new System.EventHandler(this.MultipleY_Scroll);
            // 
            // MultipleZ
            // 
            this.MultipleZ.Location = new System.Drawing.Point(982, 275);
            this.MultipleZ.Maximum = 100;
            this.MultipleZ.Minimum = -100;
            this.MultipleZ.Name = "MultipleZ";
            this.MultipleZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MultipleZ.Size = new System.Drawing.Size(56, 349);
            this.MultipleZ.TabIndex = 9;
            this.MultipleZ.TickFrequency = 10;
            this.MultipleZ.Scroll += new System.EventHandler(this.MultipleZ_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "X方向";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y方向";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(974, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Z方向";
            // 
            // Xvalue
            // 
            this.Xvalue.AutoSize = true;
            this.Xvalue.Location = new System.Drawing.Point(883, 312);
            this.Xvalue.Name = "Xvalue";
            this.Xvalue.Size = new System.Drawing.Size(24, 27);
            this.Xvalue.TabIndex = 13;
            this.Xvalue.Text = "0";
            // 
            // Yvalue
            // 
            this.Yvalue.AutoSize = true;
            this.Yvalue.Location = new System.Drawing.Point(883, 374);
            this.Yvalue.Name = "Yvalue";
            this.Yvalue.Size = new System.Drawing.Size(24, 27);
            this.Yvalue.TabIndex = 13;
            this.Yvalue.Text = "0";
            // 
            // Zvalue
            // 
            this.Zvalue.AutoSize = true;
            this.Zvalue.Location = new System.Drawing.Point(998, 245);
            this.Zvalue.Name = "Zvalue";
            this.Zvalue.Size = new System.Drawing.Size(24, 27);
            this.Zvalue.TabIndex = 13;
            this.Zvalue.Text = "0";
            // 
            // ModeSelect
            // 
            this.ModeSelect.Controls.Add(this.CheckACS);
            this.ModeSelect.Controls.Add(this.PCSMode);
            this.ModeSelect.Controls.Add(this.CCSMode);
            this.ModeSelect.Location = new System.Drawing.Point(366, 12);
            this.ModeSelect.Name = "ModeSelect";
            this.ModeSelect.Size = new System.Drawing.Size(368, 70);
            this.ModeSelect.TabIndex = 14;
            this.ModeSelect.TabStop = false;
            this.ModeSelect.Text = "模式选择";
            // 
            // CheckACS
            // 
            this.CheckACS.AutoSize = true;
            this.CheckACS.Location = new System.Drawing.Point(245, 33);
            this.CheckACS.Name = "CheckACS";
            this.CheckACS.Size = new System.Drawing.Size(113, 31);
            this.CheckACS.TabIndex = 1;
            this.CheckACS.Text = "绝对坐标";
            this.CheckACS.UseVisualStyleBackColor = true;
            this.CheckACS.CheckedChanged += new System.EventHandler(this.CheckACS_CheckedChanged);
            // 
            // PCSMode
            // 
            this.PCSMode.AutoSize = true;
            this.PCSMode.Location = new System.Drawing.Point(146, 33);
            this.PCSMode.Name = "PCSMode";
            this.PCSMode.Size = new System.Drawing.Size(93, 31);
            this.PCSMode.TabIndex = 1;
            this.PCSMode.Text = "极坐标";
            this.PCSMode.UseVisualStyleBackColor = true;
            this.PCSMode.CheckedChanged += new System.EventHandler(this.CheckPCS_CheckedChanged);
            // 
            // CCSMode
            // 
            this.CCSMode.AutoSize = true;
            this.CCSMode.Checked = true;
            this.CCSMode.Location = new System.Drawing.Point(27, 33);
            this.CCSMode.Name = "CCSMode";
            this.CCSMode.Size = new System.Drawing.Size(113, 31);
            this.CCSMode.TabIndex = 0;
            this.CCSMode.TabStop = true;
            this.CCSMode.Text = "直角坐标";
            this.CCSMode.UseVisualStyleBackColor = true;
            this.CCSMode.CheckedChanged += new System.EventHandler(this.CheckCCS_CheckedChanged);
            // 
            // MultipleP
            // 
            this.MultipleP.Enabled = false;
            this.MultipleP.Location = new System.Drawing.Point(420, 436);
            this.MultipleP.Maximum = 100;
            this.MultipleP.Minimum = -100;
            this.MultipleP.Name = "MultipleP";
            this.MultipleP.Size = new System.Drawing.Size(457, 56);
            this.MultipleP.TabIndex = 8;
            this.MultipleP.TickFrequency = 10;
            this.MultipleP.Scroll += new System.EventHandler(this.MultipleP_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "面向";
            // 
            // Pvalue
            // 
            this.Pvalue.AutoSize = true;
            this.Pvalue.Location = new System.Drawing.Point(883, 436);
            this.Pvalue.Name = "Pvalue";
            this.Pvalue.Size = new System.Drawing.Size(24, 27);
            this.Pvalue.TabIndex = 13;
            this.Pvalue.Text = "0";
            // 
            // RollBackBtn
            // 
            this.RollBackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RollBackBtn.Enabled = false;
            this.RollBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RollBackBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RollBackBtn.Location = new System.Drawing.Point(354, 682);
            this.RollBackBtn.Name = "RollBackBtn";
            this.RollBackBtn.Size = new System.Drawing.Size(100, 35);
            this.RollBackBtn.TabIndex = 1;
            this.RollBackBtn.Text = "撤销";
            this.RollBackBtn.UseVisualStyleBackColor = false;
            this.RollBackBtn.Click += new System.EventHandler(this.RollBackBtn_Click);
            // 
            // MaxDistAlert
            // 
            this.MaxDistAlert.AutoSize = true;
            this.MaxDistAlert.ForeColor = System.Drawing.Color.Crimson;
            this.MaxDistAlert.Location = new System.Drawing.Point(483, 495);
            this.MaxDistAlert.Name = "MaxDistAlert";
            this.MaxDistAlert.Size = new System.Drawing.Size(316, 27);
            this.MaxDistAlert.TabIndex = 15;
            this.MaxDistAlert.Text = "野外水平瞬移超过15米会触发掉线";
            this.MaxDistAlert.Visible = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetBtn.Location = new System.Drawing.Point(354, 245);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(114, 35);
            this.ResetBtn.TabIndex = 1;
            this.ResetBtn.Text = "重置滑竿";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DestX
            // 
            this.DestX.AutoSize = true;
            this.DestX.Location = new System.Drawing.Point(638, 95);
            this.DestX.Name = "DestX";
            this.DestX.Size = new System.Drawing.Size(96, 27);
            this.DestX.TabIndex = 3;
            this.DestX.Text = "DestX : 0";
            // 
            // DestY
            // 
            this.DestY.AutoSize = true;
            this.DestY.Location = new System.Drawing.Point(639, 125);
            this.DestY.Name = "DestY";
            this.DestY.Size = new System.Drawing.Size(95, 27);
            this.DestY.TabIndex = 4;
            this.DestY.Text = "DestY : 0";
            // 
            // DestZ
            // 
            this.DestZ.AutoSize = true;
            this.DestZ.Location = new System.Drawing.Point(639, 155);
            this.DestZ.Name = "DestZ";
            this.DestZ.Size = new System.Drawing.Size(95, 27);
            this.DestZ.TabIndex = 5;
            this.DestZ.Text = "DestZ : 0";
            // 
            // DirectX
            // 
            this.DirectX.Location = new System.Drawing.Point(37, 37);
            this.DirectX.Name = "DirectX";
            this.DirectX.Size = new System.Drawing.Size(255, 33);
            this.DirectX.TabIndex = 16;
            this.DirectX.Text = "0";
            this.DirectX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DirectY
            // 
            this.DirectY.Location = new System.Drawing.Point(37, 77);
            this.DirectY.Name = "DirectY";
            this.DirectY.Size = new System.Drawing.Size(255, 33);
            this.DirectY.TabIndex = 16;
            this.DirectY.Text = "0";
            this.DirectY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DirectZ
            // 
            this.DirectZ.Location = new System.Drawing.Point(37, 116);
            this.DirectZ.Name = "DirectZ";
            this.DirectZ.Size = new System.Drawing.Size(255, 33);
            this.DirectZ.TabIndex = 16;
            this.DirectZ.Text = "0";
            this.DirectZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputCoord
            // 
            this.InputCoord.Controls.Add(this.label8);
            this.InputCoord.Controls.Add(this.label7);
            this.InputCoord.Controls.Add(this.label6);
            this.InputCoord.Controls.Add(this.DirectX);
            this.InputCoord.Controls.Add(this.DirectZ);
            this.InputCoord.Controls.Add(this.DirectY);
            this.InputCoord.Location = new System.Drawing.Point(12, 12);
            this.InputCoord.Name = "InputCoord";
            this.InputCoord.Size = new System.Drawing.Size(312, 167);
            this.InputCoord.TabIndex = 17;
            this.InputCoord.TabStop = false;
            this.InputCoord.Text = "输入坐标";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "X";
            // 
            // CopyCoord
            // 
            this.CopyCoord.BackColor = System.Drawing.SystemColors.Control;
            this.CopyCoord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyCoord.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CopyCoord.Location = new System.Drawing.Point(757, 245);
            this.CopyCoord.Name = "CopyCoord";
            this.CopyCoord.Size = new System.Drawing.Size(150, 35);
            this.CopyCoord.TabIndex = 1;
            this.CopyCoord.Text = "复制当前坐标";
            this.CopyCoord.UseVisualStyleBackColor = false;
            this.CopyCoord.Click += new System.EventHandler(this.CopyCoord_Click);
            // 
            // MapIDLabel
            // 
            this.MapIDLabel.AutoSize = true;
            this.MapIDLabel.Location = new System.Drawing.Point(361, 201);
            this.MapIDLabel.Name = "MapIDLabel";
            this.MapIDLabel.Size = new System.Drawing.Size(78, 27);
            this.MapIDLabel.TabIndex = 20;
            this.MapIDLabel.Text = "地图ID:";
            // 
            // CoordLock
            // 
            this.CoordLock.AutoSize = true;
            this.CoordLock.Location = new System.Drawing.Point(354, 574);
            this.CoordLock.Name = "CoordLock";
            this.CoordLock.Size = new System.Drawing.Size(134, 31);
            this.CoordLock.TabIndex = 21;
            this.CoordLock.Text = "长按防击退";
            this.CoordLock.UseVisualStyleBackColor = true;
            this.CoordLock.CheckedChanged += new System.EventHandler(this.CoordLock_CheckedChanged);
            // 
            // checkCtrl
            // 
            this.checkCtrl.AutoSize = true;
            this.checkCtrl.Checked = true;
            this.checkCtrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCtrl.Location = new System.Drawing.Point(564, 574);
            this.checkCtrl.Name = "checkCtrl";
            this.checkCtrl.Size = new System.Drawing.Size(67, 31);
            this.checkCtrl.TabIndex = 22;
            this.checkCtrl.Text = "Ctrl";
            this.checkCtrl.UseVisualStyleBackColor = true;
            // 
            // checkShift
            // 
            this.checkShift.AutoSize = true;
            this.checkShift.Location = new System.Drawing.Point(670, 574);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(77, 31);
            this.checkShift.TabIndex = 24;
            this.checkShift.Text = "Shift";
            this.checkShift.UseVisualStyleBackColor = true;
            // 
            // HKcombo
            // 
            this.HKcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HKcombo.FormattingEnabled = true;
            this.HKcombo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "-",
            "=",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.HKcombo.Location = new System.Drawing.Point(786, 572);
            this.HKcombo.Name = "HKcombo";
            this.HKcombo.Size = new System.Drawing.Size(121, 35);
            this.HKcombo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 27);
            this.label9.TabIndex = 26;
            this.label9.Text = "+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(753, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 27);
            this.label10.TabIndex = 26;
            this.label10.Text = "+";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 257);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(312, 460);
            this.treeView1.TabIndex = 27;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 201);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 34);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NewAreaBtn
            // 
            this.NewAreaBtn.Location = new System.Drawing.Point(118, 201);
            this.NewAreaBtn.Name = "NewAreaBtn";
            this.NewAreaBtn.Size = new System.Drawing.Size(100, 34);
            this.NewAreaBtn.TabIndex = 28;
            this.NewAreaBtn.Text = "新区域";
            this.NewAreaBtn.UseVisualStyleBackColor = true;
            this.NewAreaBtn.Click += new System.EventHandler(this.NewAreaBtn_Click);
            // 
            // AddCoordBtn
            // 
            this.AddCoordBtn.Location = new System.Drawing.Point(224, 201);
            this.AddCoordBtn.Name = "AddCoordBtn";
            this.AddCoordBtn.Size = new System.Drawing.Size(100, 34);
            this.AddCoordBtn.TabIndex = 28;
            this.AddCoordBtn.Text = "新坐标";
            this.AddCoordBtn.UseVisualStyleBackColor = true;
            this.AddCoordBtn.Click += new System.EventHandler(this.AddNewCoord_Click);
            // 
            // NetworkStatus
            // 
            this.NetworkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkStatus.BackColor = System.Drawing.Color.White;
            this.NetworkStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetworkStatus.Location = new System.Drawing.Point(757, 12);
            this.NetworkStatus.Name = "NetworkStatus";
            this.NetworkStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NetworkStatus.Size = new System.Drawing.Size(313, 34);
            this.NetworkStatus.TabIndex = 30;
            this.NetworkStatus.Text = "未监听";
            this.NetworkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TowerExMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 739);
            this.Controls.Add(this.NetworkStatus);
            this.Controls.Add(this.AddCoordBtn);
            this.Controls.Add(this.NewAreaBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HKcombo);
            this.Controls.Add(this.checkShift);
            this.Controls.Add(this.checkCtrl);
            this.Controls.Add(this.CoordLock);
            this.Controls.Add(this.MapIDLabel);
            this.Controls.Add(this.InputCoord);
            this.Controls.Add(this.MaxDistAlert);
            this.Controls.Add(this.ModeSelect);
            this.Controls.Add(this.Zvalue);
            this.Controls.Add(this.Pvalue);
            this.Controls.Add(this.Yvalue);
            this.Controls.Add(this.Xvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MultipleZ);
            this.Controls.Add(this.MultipleP);
            this.Controls.Add(this.MultipleY);
            this.Controls.Add(this.MultipleX);
            this.Controls.Add(this.DestZ);
            this.Controls.Add(this.DeltaZ);
            this.Controls.Add(this.DestY);
            this.Controls.Add(this.RADLabel);
            this.Controls.Add(this.DeltaY);
            this.Controls.Add(this.DestX);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.DeltaX);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.RollBackBtn);
            this.Controls.Add(this.CopyCoord);
            this.Controls.Add(this.TPBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TowerExMain";
            this.Text = "一键极楼神 v5.2.2【ZNH Industry™】";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MultipleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleZ)).EndInit();
            this.ModeSelect.ResumeLayout(false);
            this.ModeSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleP)).EndInit();
            this.InputCoord.ResumeLayout(false);
            this.InputCoord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TPBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label RADLabel;
        private System.Windows.Forms.Label DeltaX;
        private System.Windows.Forms.Label DeltaY;
        private System.Windows.Forms.Label DeltaZ;
        private System.Windows.Forms.TrackBar MultipleX;
        private System.Windows.Forms.TrackBar MultipleY;
        private System.Windows.Forms.TrackBar MultipleZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Xvalue;
        private System.Windows.Forms.Label Yvalue;
        private System.Windows.Forms.Label Zvalue;
        private System.Windows.Forms.GroupBox ModeSelect;
        private System.Windows.Forms.RadioButton PCSMode;
        private System.Windows.Forms.RadioButton CCSMode;
        private System.Windows.Forms.TrackBar MultipleP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Pvalue;
        private System.Windows.Forms.Button RollBackBtn;
        private System.Windows.Forms.Label MaxDistAlert;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label DestX;
        private System.Windows.Forms.Label DestY;
        private System.Windows.Forms.Label DestZ;
        private System.Windows.Forms.RadioButton CheckACS;
        private System.Windows.Forms.TextBox DirectX;
        private System.Windows.Forms.TextBox DirectY;
        private System.Windows.Forms.TextBox DirectZ;
        private System.Windows.Forms.GroupBox InputCoord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CopyCoord;
        private System.Windows.Forms.Label MapIDLabel;
        private System.Windows.Forms.CheckBox CoordLock;
        private System.Windows.Forms.CheckBox checkCtrl;
        private System.Windows.Forms.CheckBox checkShift;
        private System.Windows.Forms.ComboBox HKcombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button NewAreaBtn;
        private System.Windows.Forms.Button AddCoordBtn;
        private System.Windows.Forms.Label NetworkStatus;
    }
}


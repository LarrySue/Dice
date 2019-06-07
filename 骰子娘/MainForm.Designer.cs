namespace DiceForCOC
{
    partial class MainForm
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
            this.d6Btn = new System.Windows.Forms.Button();
            this.d8Btn = new System.Windows.Forms.Button();
            this.d20Btn = new System.Windows.Forms.Button();
            this.d4Btn = new System.Windows.Forms.Button();
            this.d100Btn = new System.Windows.Forms.Button();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.dCustomBtn = new System.Windows.Forms.Button();
            this.d4CountNud = new System.Windows.Forms.NumericUpDown();
            this.d8CountNud = new System.Windows.Forms.NumericUpDown();
            this.d20CountNud = new System.Windows.Forms.NumericUpDown();
            this.d100CountNud = new System.Windows.Forms.NumericUpDown();
            this.d6CountNud = new System.Windows.Forms.NumericUpDown();
            this.dCustomCountNud = new System.Windows.Forms.NumericUpDown();
            this.d4AdjustNud = new System.Windows.Forms.NumericUpDown();
            this.d6AdjustNud = new System.Windows.Forms.NumericUpDown();
            this.d8AdjustNud = new System.Windows.Forms.NumericUpDown();
            this.d20AdjustNud = new System.Windows.Forms.NumericUpDown();
            this.d100AdjustNud = new System.Windows.Forms.NumericUpDown();
            this.dCustomAdjustNud = new System.Windows.Forms.NumericUpDown();
            this.dCustomCombo = new System.Windows.Forms.ComboBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.adjustLbl = new System.Windows.Forms.Label();
            this.diceLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.d4CountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8CountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20CountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100CountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6CountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCustomCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4AdjustNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6AdjustNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8AdjustNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20AdjustNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100AdjustNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCustomAdjustNud)).BeginInit();
            this.SuspendLayout();
            // 
            // d6Btn
            // 
            this.d6Btn.Location = new System.Drawing.Point(120, 68);
            this.d6Btn.Name = "d6Btn";
            this.d6Btn.Size = new System.Drawing.Size(100, 21);
            this.d6Btn.TabIndex = 0;
            this.d6Btn.Text = "D6";
            this.d6Btn.UseVisualStyleBackColor = true;
            this.d6Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D6Btn_MouseClick);
            // 
            // d8Btn
            // 
            this.d8Btn.Location = new System.Drawing.Point(120, 100);
            this.d8Btn.Name = "d8Btn";
            this.d8Btn.Size = new System.Drawing.Size(100, 21);
            this.d8Btn.TabIndex = 1;
            this.d8Btn.Text = "D8";
            this.d8Btn.UseVisualStyleBackColor = true;
            this.d8Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D8Btn_MouseClick);
            // 
            // d20Btn
            // 
            this.d20Btn.Location = new System.Drawing.Point(120, 132);
            this.d20Btn.Name = "d20Btn";
            this.d20Btn.Size = new System.Drawing.Size(100, 21);
            this.d20Btn.TabIndex = 2;
            this.d20Btn.Text = "D20";
            this.d20Btn.UseVisualStyleBackColor = true;
            this.d20Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D20Btn_MouseClick);
            // 
            // d4Btn
            // 
            this.d4Btn.Location = new System.Drawing.Point(120, 36);
            this.d4Btn.Name = "d4Btn";
            this.d4Btn.Size = new System.Drawing.Size(100, 21);
            this.d4Btn.TabIndex = 6;
            this.d4Btn.Text = "D4";
            this.d4Btn.UseVisualStyleBackColor = true;
            this.d4Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D4Btn_MouseClick);
            // 
            // d100Btn
            // 
            this.d100Btn.Location = new System.Drawing.Point(120, 164);
            this.d100Btn.Name = "d100Btn";
            this.d100Btn.Size = new System.Drawing.Size(100, 21);
            this.d100Btn.TabIndex = 7;
            this.d100Btn.Text = "D100";
            this.d100Btn.UseVisualStyleBackColor = true;
            this.d100Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D100Btn_MouseClick);
            // 
            // logTxt
            // 
            this.logTxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logTxt.Location = new System.Drawing.Point(12, 281);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ReadOnly = true;
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxt.Size = new System.Drawing.Size(320, 176);
            this.logTxt.TabIndex = 8;
            // 
            // dCustomBtn
            // 
            this.dCustomBtn.Location = new System.Drawing.Point(120, 196);
            this.dCustomBtn.Name = "dCustomBtn";
            this.dCustomBtn.Size = new System.Drawing.Size(100, 21);
            this.dCustomBtn.TabIndex = 9;
            this.dCustomBtn.Text = "自定义";
            this.dCustomBtn.UseVisualStyleBackColor = true;
            this.dCustomBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DCustomBtn_MouseClick);
            // 
            // d4CountNud
            // 
            this.d4CountNud.Location = new System.Drawing.Point(64, 36);
            this.d4CountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.d4CountNud.Name = "d4CountNud";
            this.d4CountNud.Size = new System.Drawing.Size(50, 21);
            this.d4CountNud.TabIndex = 10;
            this.d4CountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // d8CountNud
            // 
            this.d8CountNud.Location = new System.Drawing.Point(64, 100);
            this.d8CountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.d8CountNud.Name = "d8CountNud";
            this.d8CountNud.Size = new System.Drawing.Size(50, 21);
            this.d8CountNud.TabIndex = 11;
            this.d8CountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // d20CountNud
            // 
            this.d20CountNud.Location = new System.Drawing.Point(64, 132);
            this.d20CountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.d20CountNud.Name = "d20CountNud";
            this.d20CountNud.Size = new System.Drawing.Size(50, 21);
            this.d20CountNud.TabIndex = 12;
            this.d20CountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // d100CountNud
            // 
            this.d100CountNud.Location = new System.Drawing.Point(64, 164);
            this.d100CountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.d100CountNud.Name = "d100CountNud";
            this.d100CountNud.Size = new System.Drawing.Size(50, 21);
            this.d100CountNud.TabIndex = 13;
            this.d100CountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // d6CountNud
            // 
            this.d6CountNud.Location = new System.Drawing.Point(64, 68);
            this.d6CountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.d6CountNud.Name = "d6CountNud";
            this.d6CountNud.Size = new System.Drawing.Size(50, 21);
            this.d6CountNud.TabIndex = 14;
            this.d6CountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dCustomCountNud
            // 
            this.dCustomCountNud.Location = new System.Drawing.Point(64, 196);
            this.dCustomCountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dCustomCountNud.Name = "dCustomCountNud";
            this.dCustomCountNud.Size = new System.Drawing.Size(50, 21);
            this.dCustomCountNud.TabIndex = 15;
            this.dCustomCountNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // d4AdjustNud
            // 
            this.d4AdjustNud.Location = new System.Drawing.Point(226, 36);
            this.d4AdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.d4AdjustNud.Name = "d4AdjustNud";
            this.d4AdjustNud.Size = new System.Drawing.Size(50, 21);
            this.d4AdjustNud.TabIndex = 16;
            // 
            // d6AdjustNud
            // 
            this.d6AdjustNud.Location = new System.Drawing.Point(226, 68);
            this.d6AdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.d6AdjustNud.Name = "d6AdjustNud";
            this.d6AdjustNud.Size = new System.Drawing.Size(50, 21);
            this.d6AdjustNud.TabIndex = 17;
            // 
            // d8AdjustNud
            // 
            this.d8AdjustNud.Location = new System.Drawing.Point(226, 100);
            this.d8AdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.d8AdjustNud.Name = "d8AdjustNud";
            this.d8AdjustNud.Size = new System.Drawing.Size(50, 21);
            this.d8AdjustNud.TabIndex = 18;
            // 
            // d20AdjustNud
            // 
            this.d20AdjustNud.Location = new System.Drawing.Point(226, 132);
            this.d20AdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.d20AdjustNud.Name = "d20AdjustNud";
            this.d20AdjustNud.Size = new System.Drawing.Size(50, 21);
            this.d20AdjustNud.TabIndex = 19;
            // 
            // d100AdjustNud
            // 
            this.d100AdjustNud.Location = new System.Drawing.Point(226, 164);
            this.d100AdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.d100AdjustNud.Name = "d100AdjustNud";
            this.d100AdjustNud.Size = new System.Drawing.Size(50, 21);
            this.d100AdjustNud.TabIndex = 20;
            // 
            // dCustomAdjustNud
            // 
            this.dCustomAdjustNud.Location = new System.Drawing.Point(226, 196);
            this.dCustomAdjustNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.dCustomAdjustNud.Name = "dCustomAdjustNud";
            this.dCustomAdjustNud.Size = new System.Drawing.Size(50, 21);
            this.dCustomAdjustNud.TabIndex = 21;
            // 
            // dCustomCombo
            // 
            this.dCustomCombo.FormattingEnabled = true;
            this.dCustomCombo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.dCustomCombo.Location = new System.Drawing.Point(12, 195);
            this.dCustomCombo.Name = "dCustomCombo";
            this.dCustomCombo.Size = new System.Drawing.Size(46, 20);
            this.dCustomCombo.TabIndex = 22;
            this.dCustomCombo.Text = "100";
            // 
            // countLbl
            // 
            this.countLbl.Location = new System.Drawing.Point(62, 9);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(52, 24);
            this.countLbl.TabIndex = 23;
            this.countLbl.Text = "个数";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adjustLbl
            // 
            this.adjustLbl.Location = new System.Drawing.Point(224, 9);
            this.adjustLbl.Name = "adjustLbl";
            this.adjustLbl.Size = new System.Drawing.Size(52, 24);
            this.adjustLbl.TabIndex = 24;
            this.adjustLbl.Text = "调整值";
            this.adjustLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceLbl
            // 
            this.diceLbl.Location = new System.Drawing.Point(120, 9);
            this.diceLbl.Name = "diceLbl";
            this.diceLbl.Size = new System.Drawing.Size(98, 24);
            this.diceLbl.TabIndex = 25;
            this.diceLbl.Text = "骰子面数";
            this.diceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(13, 242);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(150, 23);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "还原骰子设置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResetBtn_MouseClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(182, 242);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 23);
            this.clearBtn.TabIndex = 27;
            this.clearBtn.Text = "清空记录";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearBtn_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 469);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.diceLbl);
            this.Controls.Add(this.adjustLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.dCustomCombo);
            this.Controls.Add(this.dCustomAdjustNud);
            this.Controls.Add(this.d100AdjustNud);
            this.Controls.Add(this.d20AdjustNud);
            this.Controls.Add(this.d8AdjustNud);
            this.Controls.Add(this.d6AdjustNud);
            this.Controls.Add(this.d4AdjustNud);
            this.Controls.Add(this.dCustomCountNud);
            this.Controls.Add(this.d6CountNud);
            this.Controls.Add(this.d100CountNud);
            this.Controls.Add(this.d20CountNud);
            this.Controls.Add(this.d8CountNud);
            this.Controls.Add(this.d4CountNud);
            this.Controls.Add(this.dCustomBtn);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.d100Btn);
            this.Controls.Add(this.d4Btn);
            this.Controls.Add(this.d20Btn);
            this.Controls.Add(this.d8Btn);
            this.Controls.Add(this.d6Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "骰子娘";
            ((System.ComponentModel.ISupportInitialize)(this.d4CountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8CountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20CountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100CountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6CountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCustomCountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4AdjustNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6AdjustNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8AdjustNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d20AdjustNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d100AdjustNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCustomAdjustNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d6Btn;
        private System.Windows.Forms.Button d8Btn;
        private System.Windows.Forms.Button d20Btn;
        private System.Windows.Forms.Button d4Btn;
        private System.Windows.Forms.Button d100Btn;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Button dCustomBtn;
        private System.Windows.Forms.NumericUpDown d4CountNud;
        private System.Windows.Forms.NumericUpDown d8CountNud;
        private System.Windows.Forms.NumericUpDown d20CountNud;
        private System.Windows.Forms.NumericUpDown d100CountNud;
        private System.Windows.Forms.NumericUpDown d6CountNud;
        private System.Windows.Forms.NumericUpDown dCustomCountNud;
        private System.Windows.Forms.NumericUpDown d4AdjustNud;
        private System.Windows.Forms.NumericUpDown d6AdjustNud;
        private System.Windows.Forms.NumericUpDown d8AdjustNud;
        private System.Windows.Forms.NumericUpDown d20AdjustNud;
        private System.Windows.Forms.NumericUpDown d100AdjustNud;
        private System.Windows.Forms.NumericUpDown dCustomAdjustNud;
        private System.Windows.Forms.ComboBox dCustomCombo;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label adjustLbl;
        private System.Windows.Forms.Label diceLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}


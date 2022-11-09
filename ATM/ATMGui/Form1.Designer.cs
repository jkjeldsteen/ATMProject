namespace ATMGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblCardNumberString = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardholder = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurrAction = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceString = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.tblKeypad = new System.Windows.Forms.TableLayoutPanel();
            this.btnPressOne = new System.Windows.Forms.Button();
            this.btnPressTwo = new System.Windows.Forms.Button();
            this.btnPressThree = new System.Windows.Forms.Button();
            this.btnPressFour = new System.Windows.Forms.Button();
            this.btnPressSix = new System.Windows.Forms.Button();
            this.btnPressSeven = new System.Windows.Forms.Button();
            this.btnPressEight = new System.Windows.Forms.Button();
            this.btnPressDot = new System.Windows.Forms.Button();
            this.btnPressZero = new System.Windows.Forms.Button();
            this.btnPressZeroZero = new System.Windows.Forms.Button();
            this.btnPressCancel = new System.Windows.Forms.Button();
            this.btnPressClear = new System.Windows.Forms.Button();
            this.btnPressAccept = new System.Windows.Forms.Button();
            this.btnPressNine = new System.Windows.Forms.Button();
            this.btnPressFive = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblKeypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.btnChangeUser);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeposit);
            this.splitContainer1.Panel1.Controls.Add(this.btnWithdraw);
            this.splitContainer1.Panel1.Controls.Add(this.lblCardNumberString);
            this.splitContainer1.Panel1.Controls.Add(this.lblCardNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lblCardholder);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrAction);
            this.splitContainer1.Panel2.Controls.Add(this.lblBalance);
            this.splitContainer1.Panel2.Controls.Add(this.lblBalanceString);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.tblKeypad);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.Location = new System.Drawing.Point(0, 350);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(266, 50);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.Location = new System.Drawing.Point(0, 400);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(266, 50);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblCardNumberString
            // 
            this.lblCardNumberString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCardNumberString.AutoSize = true;
            this.lblCardNumberString.Location = new System.Drawing.Point(12, 75);
            this.lblCardNumberString.Name = "lblCardNumberString";
            this.lblCardNumberString.Size = new System.Drawing.Size(79, 15);
            this.lblCardNumberString.TabIndex = 3;
            this.lblCardNumberString.Text = "Card Number";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardNumber.Location = new System.Drawing.Point(12, 54);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(166, 21);
            this.lblCardNumber.TabIndex = 2;
            this.lblCardNumber.Text = "1234 5678 9012 3456";
            // 
            // lblCardholder
            // 
            this.lblCardholder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCardholder.AutoSize = true;
            this.lblCardholder.Location = new System.Drawing.Point(12, 30);
            this.lblCardholder.Name = "lblCardholder";
            this.lblCardholder.Size = new System.Drawing.Size(71, 15);
            this.lblCardholder.TabIndex = 1;
            this.lblCardholder.Text = "Card Holder";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Firstname Lastname";
            // 
            // lblCurrAction
            // 
            this.lblCurrAction.AutoSize = true;
            this.lblCurrAction.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrAction.Location = new System.Drawing.Point(187, 407);
            this.lblCurrAction.Name = "lblCurrAction";
            this.lblCurrAction.Size = new System.Drawing.Size(158, 30);
            this.lblCurrAction.TabIndex = 4;
            this.lblCurrAction.Text = "Current Action:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(185, 9);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 28);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "0$";
            // 
            // lblBalanceString
            // 
            this.lblBalanceString.AutoSize = true;
            this.lblBalanceString.Location = new System.Drawing.Point(187, 40);
            this.lblBalanceString.Name = "lblBalanceString";
            this.lblBalanceString.Size = new System.Drawing.Size(48, 15);
            this.lblBalanceString.TabIndex = 2;
            this.lblBalanceString.Text = "Balance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Location = new System.Drawing.Point(185, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 69);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblCurrency);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblInput);
            this.splitContainer2.Size = new System.Drawing.Size(288, 69);
            this.splitContainer2.SplitterDistance = 96;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrency.Location = new System.Drawing.Point(0, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(77, 65);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "$: ";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInput.Location = new System.Drawing.Point(188, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 67);
            this.lblInput.TabIndex = 0;
            // 
            // tblKeypad
            // 
            this.tblKeypad.ColumnCount = 3;
            this.tblKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblKeypad.Controls.Add(this.btnPressOne, 0, 0);
            this.tblKeypad.Controls.Add(this.btnPressTwo, 1, 0);
            this.tblKeypad.Controls.Add(this.btnPressThree, 2, 0);
            this.tblKeypad.Controls.Add(this.btnPressFour, 0, 1);
            this.tblKeypad.Controls.Add(this.btnPressSix, 2, 1);
            this.tblKeypad.Controls.Add(this.btnPressSeven, 0, 2);
            this.tblKeypad.Controls.Add(this.btnPressEight, 1, 2);
            this.tblKeypad.Controls.Add(this.btnPressDot, 0, 3);
            this.tblKeypad.Controls.Add(this.btnPressZero, 1, 3);
            this.tblKeypad.Controls.Add(this.btnPressZeroZero, 2, 3);
            this.tblKeypad.Controls.Add(this.btnPressCancel, 0, 4);
            this.tblKeypad.Controls.Add(this.btnPressClear, 1, 4);
            this.tblKeypad.Controls.Add(this.btnPressAccept, 2, 4);
            this.tblKeypad.Controls.Add(this.btnPressNine, 2, 2);
            this.tblKeypad.Controls.Add(this.btnPressFive, 1, 1);
            this.tblKeypad.Location = new System.Drawing.Point(182, 147);
            this.tblKeypad.Name = "tblKeypad";
            this.tblKeypad.RowCount = 5;
            this.tblKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblKeypad.Size = new System.Drawing.Size(294, 253);
            this.tblKeypad.TabIndex = 0;
            // 
            // btnPressOne
            // 
            this.btnPressOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPressOne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPressOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressOne.ForeColor = System.Drawing.Color.White;
            this.btnPressOne.Location = new System.Drawing.Point(3, 3);
            this.btnPressOne.Name = "btnPressOne";
            this.btnPressOne.Size = new System.Drawing.Size(91, 44);
            this.btnPressOne.TabIndex = 0;
            this.btnPressOne.Text = "1";
            this.btnPressOne.UseVisualStyleBackColor = false;
            this.btnPressOne.Click += new System.EventHandler(this.btnPressOne_Click);
            // 
            // btnPressTwo
            // 
            this.btnPressTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressTwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressTwo.ForeColor = System.Drawing.Color.White;
            this.btnPressTwo.Location = new System.Drawing.Point(100, 3);
            this.btnPressTwo.Name = "btnPressTwo";
            this.btnPressTwo.Size = new System.Drawing.Size(92, 44);
            this.btnPressTwo.TabIndex = 1;
            this.btnPressTwo.Text = "2";
            this.btnPressTwo.UseVisualStyleBackColor = false;
            this.btnPressTwo.Click += new System.EventHandler(this.btnPressTwo_Click);
            // 
            // btnPressThree
            // 
            this.btnPressThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressThree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressThree.ForeColor = System.Drawing.Color.White;
            this.btnPressThree.Location = new System.Drawing.Point(198, 3);
            this.btnPressThree.Name = "btnPressThree";
            this.btnPressThree.Size = new System.Drawing.Size(93, 44);
            this.btnPressThree.TabIndex = 2;
            this.btnPressThree.Text = "3";
            this.btnPressThree.UseVisualStyleBackColor = false;
            this.btnPressThree.Click += new System.EventHandler(this.btnPressThree_Click);
            // 
            // btnPressFour
            // 
            this.btnPressFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressFour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressFour.ForeColor = System.Drawing.Color.White;
            this.btnPressFour.Location = new System.Drawing.Point(3, 53);
            this.btnPressFour.Name = "btnPressFour";
            this.btnPressFour.Size = new System.Drawing.Size(91, 44);
            this.btnPressFour.TabIndex = 3;
            this.btnPressFour.Text = "4";
            this.btnPressFour.UseVisualStyleBackColor = false;
            this.btnPressFour.Click += new System.EventHandler(this.btnPressFour_Click);
            // 
            // btnPressSix
            // 
            this.btnPressSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressSix.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressSix.ForeColor = System.Drawing.Color.White;
            this.btnPressSix.Location = new System.Drawing.Point(198, 53);
            this.btnPressSix.Name = "btnPressSix";
            this.btnPressSix.Size = new System.Drawing.Size(93, 44);
            this.btnPressSix.TabIndex = 5;
            this.btnPressSix.Text = "6";
            this.btnPressSix.UseVisualStyleBackColor = false;
            this.btnPressSix.Click += new System.EventHandler(this.btnPressSix_Click);
            // 
            // btnPressSeven
            // 
            this.btnPressSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressSeven.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressSeven.ForeColor = System.Drawing.Color.White;
            this.btnPressSeven.Location = new System.Drawing.Point(3, 103);
            this.btnPressSeven.Name = "btnPressSeven";
            this.btnPressSeven.Size = new System.Drawing.Size(91, 44);
            this.btnPressSeven.TabIndex = 6;
            this.btnPressSeven.Text = "7";
            this.btnPressSeven.UseVisualStyleBackColor = false;
            this.btnPressSeven.Click += new System.EventHandler(this.btnPressSeven_Click);
            // 
            // btnPressEight
            // 
            this.btnPressEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressEight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressEight.ForeColor = System.Drawing.Color.White;
            this.btnPressEight.Location = new System.Drawing.Point(100, 103);
            this.btnPressEight.Name = "btnPressEight";
            this.btnPressEight.Size = new System.Drawing.Size(92, 44);
            this.btnPressEight.TabIndex = 7;
            this.btnPressEight.Text = "8";
            this.btnPressEight.UseVisualStyleBackColor = false;
            this.btnPressEight.Click += new System.EventHandler(this.btnPressEight_Click);
            // 
            // btnPressDot
            // 
            this.btnPressDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressDot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressDot.ForeColor = System.Drawing.Color.White;
            this.btnPressDot.Location = new System.Drawing.Point(3, 153);
            this.btnPressDot.Name = "btnPressDot";
            this.btnPressDot.Size = new System.Drawing.Size(91, 44);
            this.btnPressDot.TabIndex = 9;
            this.btnPressDot.Text = "•";
            this.btnPressDot.UseVisualStyleBackColor = false;
            this.btnPressDot.Click += new System.EventHandler(this.btnPressDot_Click);
            // 
            // btnPressZero
            // 
            this.btnPressZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressZero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressZero.ForeColor = System.Drawing.Color.White;
            this.btnPressZero.Location = new System.Drawing.Point(100, 153);
            this.btnPressZero.Name = "btnPressZero";
            this.btnPressZero.Size = new System.Drawing.Size(92, 44);
            this.btnPressZero.TabIndex = 10;
            this.btnPressZero.Text = "0";
            this.btnPressZero.UseVisualStyleBackColor = false;
            this.btnPressZero.Click += new System.EventHandler(this.btnPressZero_Click);
            // 
            // btnPressZeroZero
            // 
            this.btnPressZeroZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressZeroZero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressZeroZero.ForeColor = System.Drawing.Color.White;
            this.btnPressZeroZero.Location = new System.Drawing.Point(198, 153);
            this.btnPressZeroZero.Name = "btnPressZeroZero";
            this.btnPressZeroZero.Size = new System.Drawing.Size(93, 44);
            this.btnPressZeroZero.TabIndex = 11;
            this.btnPressZeroZero.Text = "00";
            this.btnPressZeroZero.UseVisualStyleBackColor = false;
            this.btnPressZeroZero.Click += new System.EventHandler(this.btnPressZeroZero_Click);
            // 
            // btnPressCancel
            // 
            this.btnPressCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPressCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressCancel.Location = new System.Drawing.Point(3, 203);
            this.btnPressCancel.Name = "btnPressCancel";
            this.btnPressCancel.Size = new System.Drawing.Size(91, 47);
            this.btnPressCancel.TabIndex = 12;
            this.btnPressCancel.Text = "Cancel";
            this.btnPressCancel.UseVisualStyleBackColor = false;
            this.btnPressCancel.Click += new System.EventHandler(this.btnPressCancel_Click);
            // 
            // btnPressClear
            // 
            this.btnPressClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPressClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressClear.Location = new System.Drawing.Point(100, 203);
            this.btnPressClear.Name = "btnPressClear";
            this.btnPressClear.Size = new System.Drawing.Size(92, 47);
            this.btnPressClear.TabIndex = 13;
            this.btnPressClear.Text = "Clear";
            this.btnPressClear.UseVisualStyleBackColor = false;
            this.btnPressClear.Click += new System.EventHandler(this.btnPressClear_Click);
            // 
            // btnPressAccept
            // 
            this.btnPressAccept.BackColor = System.Drawing.Color.Lime;
            this.btnPressAccept.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressAccept.Location = new System.Drawing.Point(198, 203);
            this.btnPressAccept.Name = "btnPressAccept";
            this.btnPressAccept.Size = new System.Drawing.Size(93, 47);
            this.btnPressAccept.TabIndex = 14;
            this.btnPressAccept.Text = "Accept";
            this.btnPressAccept.UseVisualStyleBackColor = false;
            this.btnPressAccept.Click += new System.EventHandler(this.btnPressAccept_Click);
            // 
            // btnPressNine
            // 
            this.btnPressNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressNine.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressNine.ForeColor = System.Drawing.Color.White;
            this.btnPressNine.Location = new System.Drawing.Point(198, 103);
            this.btnPressNine.Name = "btnPressNine";
            this.btnPressNine.Size = new System.Drawing.Size(93, 44);
            this.btnPressNine.TabIndex = 8;
            this.btnPressNine.Text = "9";
            this.btnPressNine.UseVisualStyleBackColor = false;
            this.btnPressNine.Click += new System.EventHandler(this.btnPressNine_Click);
            // 
            // btnPressFive
            // 
            this.btnPressFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPressFive.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPressFive.ForeColor = System.Drawing.Color.White;
            this.btnPressFive.Location = new System.Drawing.Point(100, 53);
            this.btnPressFive.Name = "btnPressFive";
            this.btnPressFive.Size = new System.Drawing.Size(92, 44);
            this.btnPressFive.TabIndex = 4;
            this.btnPressFive.Text = "5";
            this.btnPressFive.UseVisualStyleBackColor = false;
            this.btnPressFive.Click += new System.EventHandler(this.btnPressFive_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeUser.Location = new System.Drawing.Point(0, 300);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(266, 50);
            this.btnChangeUser.TabIndex = 6;
            this.btnChangeUser.Text = "Change User";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblKeypad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblCardholder;
        private Label lblName;
        private Label lblCardNumberString;
        private Label lblCardNumber;
        private Button btnDeposit;
        private Button btnWithdraw;
        private TableLayoutPanel tblKeypad;
        private Button btnPressOne;
        private Label lblBalance;
        private Label lblBalanceString;
        private Panel panel1;
        private Button btnPressTwo;
        private Button btnPressThree;
        private Button btnPressFour;
        private Button btnPressSix;
        private Button btnPressSeven;
        private Button btnPressEight;
        private Button btnPressDot;
        private Button btnPressZero;
        private Button btnPressZeroZero;
        private Button btnPressCancel;
        private Button btnPressClear;
        private Button btnPressAccept;
        private Button btnPressNine;
        private Button btnPressFive;
        private SplitContainer splitContainer2;
        private Label lblCurrency;
        private Label lblInput;
        private Label lblCurrAction;
        private Button btnChangeUser;
    }
}
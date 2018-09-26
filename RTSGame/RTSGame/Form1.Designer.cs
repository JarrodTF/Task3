namespace RTSGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.unitLbl = new System.Windows.Forms.TextBox();
            this.upTimeLabel = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMill = new System.Windows.Forms.Label();
            this.colon1 = new System.Windows.Forms.Label();
            this.fullStop1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.teamMeleeBtn = new System.Windows.Forms.Button();
            this.teamRangeBtn = new System.Windows.Forms.Button();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.gridMap = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.resLabel = new System.Windows.Forms.Label();
            this.teamInformation = new System.Windows.Forms.Label();
            this.resLabel2 = new System.Windows.Forms.Label();
            this.undeadSymbol = new System.Windows.Forms.Label();
            this.humanSymbol = new System.Windows.Forms.Label();
            this.heartSymbol = new System.Windows.Forms.Label();
            this.diamondSymbol = new System.Windows.Forms.Label();
            this.allTeamResources = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.humanWarResources = new System.Windows.Forms.Label();
            this.undeadWarResources = new System.Windows.Forms.Label();
            this.humanCoal = new System.Windows.Forms.Label();
            this.humanIron = new System.Windows.Forms.Label();
            this.UndeadCoal = new System.Windows.Forms.Label();
            this.undeadIron = new System.Windows.Forms.Label();
            this.humanSteel = new System.Windows.Forms.Label();
            this.undeadSteel = new System.Windows.Forms.Label();
            this.coalLabel = new System.Windows.Forms.Label();
            this.ironLabel = new System.Windows.Forms.Label();
            this.steelLabel = new System.Windows.Forms.Label();
            this.coalLabel2 = new System.Windows.Forms.Label();
            this.ironLabel2 = new System.Windows.Forms.Label();
            this.steelLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(710, 15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(822, 15);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(106, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // unitLbl
            // 
            this.unitLbl.Location = new System.Drawing.Point(710, 81);
            this.unitLbl.Multiline = true;
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(244, 100);
            this.unitLbl.TabIndex = 3;
            // 
            // upTimeLabel
            // 
            this.upTimeLabel.AutoSize = true;
            this.upTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upTimeLabel.Location = new System.Drawing.Point(710, 193);
            this.upTimeLabel.Name = "upTimeLabel";
            this.upTimeLabel.Size = new System.Drawing.Size(74, 22);
            this.upTimeLabel.TabIndex = 4;
            this.upTimeLabel.Text = "Up Time:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(790, 193);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 24);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(847, 193);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(30, 24);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "00";
            // 
            // lblMill
            // 
            this.lblMill.AutoSize = true;
            this.lblMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMill.Location = new System.Drawing.Point(898, 200);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(22, 16);
            this.lblMill.TabIndex = 6;
            this.lblMill.Text = "00";
            this.lblMill.Click += new System.EventHandler(this.lblMill_Click);
            // 
            // colon1
            // 
            this.colon1.AutoSize = true;
            this.colon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon1.Location = new System.Drawing.Point(826, 191);
            this.colon1.Name = "colon1";
            this.colon1.Size = new System.Drawing.Size(15, 24);
            this.colon1.TabIndex = 7;
            this.colon1.Text = ":";
            // 
            // fullStop1
            // 
            this.fullStop1.AutoSize = true;
            this.fullStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullStop1.Location = new System.Drawing.Point(881, 198);
            this.fullStop1.Name = "fullStop1";
            this.fullStop1.Size = new System.Drawing.Size(11, 16);
            this.fullStop1.TabIndex = 8;
            this.fullStop1.Text = ".";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(934, 15);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(706, 55);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(247, 16);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "Click on a grid block to show information.";
            // 
            // teamMeleeBtn
            // 
            this.teamMeleeBtn.Location = new System.Drawing.Point(960, 107);
            this.teamMeleeBtn.Name = "teamMeleeBtn";
            this.teamMeleeBtn.Size = new System.Drawing.Size(92, 23);
            this.teamMeleeBtn.TabIndex = 13;
            this.teamMeleeBtn.Text = "Melee Unit: ♥";
            this.teamMeleeBtn.UseVisualStyleBackColor = true;
            this.teamMeleeBtn.Click += new System.EventHandler(this.teamMeleeBtn_Click);
            // 
            // teamRangeBtn
            // 
            this.teamRangeBtn.Location = new System.Drawing.Point(960, 136);
            this.teamRangeBtn.Name = "teamRangeBtn";
            this.teamRangeBtn.Size = new System.Drawing.Size(92, 23);
            this.teamRangeBtn.TabIndex = 14;
            this.teamRangeBtn.Text = "Ranged Unit: ♦";
            this.teamRangeBtn.UseVisualStyleBackColor = true;
            this.teamRangeBtn.Click += new System.EventHandler(this.teamRangeBtn_Click);
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Location = new System.Drawing.Point(990, 91);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(33, 13);
            this.unitLabel2.TabIndex = 15;
            this.unitLabel2.Text = "Click!";
            // 
            // gridMap
            // 
            this.gridMap.ColumnCount = 20;
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.gridMap.Location = new System.Drawing.Point(8, 15);
            this.gridMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridMap.Name = "gridMap";
            this.gridMap.RowCount = 20;
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.gridMap.Size = new System.Drawing.Size(677, 732);
            this.gridMap.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(822, 728);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(934, 728);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 23);
            this.loadButton.TabIndex = 19;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLabel.Location = new System.Drawing.Point(98, 26);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(21, 15);
            this.resLabel.TabIndex = 5;
            this.resLabel.Text = "00";
            // 
            // teamInformation
            // 
            this.teamInformation.AutoSize = true;
            this.teamInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamInformation.Location = new System.Drawing.Point(709, 245);
            this.teamInformation.Name = "teamInformation";
            this.teamInformation.Size = new System.Drawing.Size(174, 22);
            this.teamInformation.TabIndex = 20;
            this.teamInformation.Text = "TEAM INFORMATION:";
            // 
            // resLabel2
            // 
            this.resLabel2.AutoSize = true;
            this.resLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLabel2.Location = new System.Drawing.Point(98, 26);
            this.resLabel2.Name = "resLabel2";
            this.resLabel2.Size = new System.Drawing.Size(21, 15);
            this.resLabel2.TabIndex = 22;
            this.resLabel2.Text = "00";
            // 
            // undeadSymbol
            // 
            this.undeadSymbol.AutoSize = true;
            this.undeadSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.undeadSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undeadSymbol.Location = new System.Drawing.Point(709, 312);
            this.undeadSymbol.Name = "undeadSymbol";
            this.undeadSymbol.Size = new System.Drawing.Size(121, 19);
            this.undeadSymbol.TabIndex = 24;
            this.undeadSymbol.Text = "Undeads Symbol:";
            // 
            // humanSymbol
            // 
            this.humanSymbol.AutoSize = true;
            this.humanSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanSymbol.Location = new System.Drawing.Point(709, 280);
            this.humanSymbol.Name = "humanSymbol";
            this.humanSymbol.Size = new System.Drawing.Size(116, 19);
            this.humanSymbol.TabIndex = 23;
            this.humanSymbol.Text = "Humans Symbol:";
            // 
            // heartSymbol
            // 
            this.heartSymbol.AutoSize = true;
            this.heartSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heartSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartSymbol.Location = new System.Drawing.Point(842, 280);
            this.heartSymbol.Name = "heartSymbol";
            this.heartSymbol.Size = new System.Drawing.Size(18, 19);
            this.heartSymbol.TabIndex = 25;
            this.heartSymbol.Text = "♥";
            // 
            // diamondSymbol
            // 
            this.diamondSymbol.AutoSize = true;
            this.diamondSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diamondSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondSymbol.Location = new System.Drawing.Point(842, 312);
            this.diamondSymbol.Name = "diamondSymbol";
            this.diamondSymbol.Size = new System.Drawing.Size(18, 19);
            this.diamondSymbol.TabIndex = 26;
            this.diamondSymbol.Text = "♦";
            // 
            // allTeamResources
            // 
            this.allTeamResources.AutoSize = true;
            this.allTeamResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allTeamResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTeamResources.Location = new System.Drawing.Point(709, 347);
            this.allTeamResources.Name = "allTeamResources";
            this.allTeamResources.Size = new System.Drawing.Size(136, 22);
            this.allTeamResources.TabIndex = 27;
            this.allTeamResources.Text = "Team Resources:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.steelLabel);
            this.groupBox1.Controls.Add(this.ironLabel);
            this.groupBox1.Controls.Add(this.coalLabel);
            this.groupBox1.Controls.Add(this.humanSteel);
            this.groupBox1.Controls.Add(this.humanIron);
            this.groupBox1.Controls.Add(this.humanCoal);
            this.groupBox1.Controls.Add(this.humanWarResources);
            this.groupBox1.Controls.Add(this.resLabel);
            this.groupBox1.Location = new System.Drawing.Point(709, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Humans:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.steelLabel2);
            this.groupBox2.Controls.Add(this.ironLabel2);
            this.groupBox2.Controls.Add(this.coalLabel2);
            this.groupBox2.Controls.Add(this.undeadSteel);
            this.groupBox2.Controls.Add(this.undeadIron);
            this.groupBox2.Controls.Add(this.UndeadCoal);
            this.groupBox2.Controls.Add(this.undeadWarResources);
            this.groupBox2.Controls.Add(this.resLabel2);
            this.groupBox2.Location = new System.Drawing.Point(709, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Undead:";
            // 
            // humanWarResources
            // 
            this.humanWarResources.AutoSize = true;
            this.humanWarResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanWarResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanWarResources.Location = new System.Drawing.Point(6, 26);
            this.humanWarResources.Name = "humanWarResources";
            this.humanWarResources.Size = new System.Drawing.Size(86, 15);
            this.humanWarResources.TabIndex = 30;
            this.humanWarResources.Text = "War Resources:";
            // 
            // undeadWarResources
            // 
            this.undeadWarResources.AutoSize = true;
            this.undeadWarResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.undeadWarResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undeadWarResources.Location = new System.Drawing.Point(6, 26);
            this.undeadWarResources.Name = "undeadWarResources";
            this.undeadWarResources.Size = new System.Drawing.Size(86, 15);
            this.undeadWarResources.TabIndex = 31;
            this.undeadWarResources.Text = "War Resources:";
            // 
            // humanCoal
            // 
            this.humanCoal.AutoSize = true;
            this.humanCoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanCoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanCoal.Location = new System.Drawing.Point(6, 50);
            this.humanCoal.Name = "humanCoal";
            this.humanCoal.Size = new System.Drawing.Size(33, 15);
            this.humanCoal.TabIndex = 31;
            this.humanCoal.Text = "Coal:";
            // 
            // humanIron
            // 
            this.humanIron.AutoSize = true;
            this.humanIron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanIron.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanIron.Location = new System.Drawing.Point(6, 75);
            this.humanIron.Name = "humanIron";
            this.humanIron.Size = new System.Drawing.Size(30, 15);
            this.humanIron.TabIndex = 32;
            this.humanIron.Text = "Iron:";
            // 
            // UndeadCoal
            // 
            this.UndeadCoal.AutoSize = true;
            this.UndeadCoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UndeadCoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndeadCoal.Location = new System.Drawing.Point(6, 51);
            this.UndeadCoal.Name = "UndeadCoal";
            this.UndeadCoal.Size = new System.Drawing.Size(33, 15);
            this.UndeadCoal.TabIndex = 33;
            this.UndeadCoal.Text = "Coal:";
            // 
            // undeadIron
            // 
            this.undeadIron.AutoSize = true;
            this.undeadIron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.undeadIron.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undeadIron.Location = new System.Drawing.Point(6, 75);
            this.undeadIron.Name = "undeadIron";
            this.undeadIron.Size = new System.Drawing.Size(30, 15);
            this.undeadIron.TabIndex = 33;
            this.undeadIron.Text = "Iron:";
            // 
            // humanSteel
            // 
            this.humanSteel.AutoSize = true;
            this.humanSteel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanSteel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanSteel.Location = new System.Drawing.Point(6, 99);
            this.humanSteel.Name = "humanSteel";
            this.humanSteel.Size = new System.Drawing.Size(36, 15);
            this.humanSteel.TabIndex = 33;
            this.humanSteel.Text = "Steel:";
            // 
            // undeadSteel
            // 
            this.undeadSteel.AutoSize = true;
            this.undeadSteel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.undeadSteel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undeadSteel.Location = new System.Drawing.Point(6, 99);
            this.undeadSteel.Name = "undeadSteel";
            this.undeadSteel.Size = new System.Drawing.Size(36, 15);
            this.undeadSteel.TabIndex = 34;
            this.undeadSteel.Text = "Steel:";
            // 
            // coalLabel
            // 
            this.coalLabel.AutoSize = true;
            this.coalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coalLabel.Location = new System.Drawing.Point(98, 50);
            this.coalLabel.Name = "coalLabel";
            this.coalLabel.Size = new System.Drawing.Size(21, 15);
            this.coalLabel.TabIndex = 34;
            this.coalLabel.Text = "00";
            // 
            // ironLabel
            // 
            this.ironLabel.AutoSize = true;
            this.ironLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ironLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ironLabel.Location = new System.Drawing.Point(98, 75);
            this.ironLabel.Name = "ironLabel";
            this.ironLabel.Size = new System.Drawing.Size(21, 15);
            this.ironLabel.TabIndex = 35;
            this.ironLabel.Text = "00";
            // 
            // steelLabel
            // 
            this.steelLabel.AutoSize = true;
            this.steelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.steelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steelLabel.Location = new System.Drawing.Point(98, 99);
            this.steelLabel.Name = "steelLabel";
            this.steelLabel.Size = new System.Drawing.Size(21, 15);
            this.steelLabel.TabIndex = 36;
            this.steelLabel.Text = "00";
            // 
            // coalLabel2
            // 
            this.coalLabel2.AutoSize = true;
            this.coalLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coalLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coalLabel2.Location = new System.Drawing.Point(98, 51);
            this.coalLabel2.Name = "coalLabel2";
            this.coalLabel2.Size = new System.Drawing.Size(21, 15);
            this.coalLabel2.TabIndex = 37;
            this.coalLabel2.Text = "00";
            // 
            // ironLabel2
            // 
            this.ironLabel2.AutoSize = true;
            this.ironLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ironLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ironLabel2.Location = new System.Drawing.Point(98, 75);
            this.ironLabel2.Name = "ironLabel2";
            this.ironLabel2.Size = new System.Drawing.Size(21, 15);
            this.ironLabel2.TabIndex = 38;
            this.ironLabel2.Text = "00";
            // 
            // steelLabel2
            // 
            this.steelLabel2.AutoSize = true;
            this.steelLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.steelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steelLabel2.Location = new System.Drawing.Point(98, 99);
            this.steelLabel2.Name = "steelLabel2";
            this.steelLabel2.Size = new System.Drawing.Size(21, 15);
            this.steelLabel2.TabIndex = 39;
            this.steelLabel2.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 758);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allTeamResources);
            this.Controls.Add(this.diamondSymbol);
            this.Controls.Add(this.heartSymbol);
            this.Controls.Add(this.undeadSymbol);
            this.Controls.Add(this.humanSymbol);
            this.Controls.Add(this.teamInformation);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gridMap);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.teamRangeBtn);
            this.Controls.Add(this.teamMeleeBtn);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.fullStop1);
            this.Controls.Add(this.lblMill);
            this.Controls.Add(this.upTimeLabel);
            this.Controls.Add(this.unitLbl);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colon1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "The_RTS_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox unitLbl;
        private System.Windows.Forms.Label upTimeLabel;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMill;
        private System.Windows.Forms.Label colon1;
        private System.Windows.Forms.Label fullStop1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button teamMeleeBtn;
        private System.Windows.Forms.Button teamRangeBtn;
        private System.Windows.Forms.Label unitLabel2;
        private System.Windows.Forms.TableLayoutPanel gridMap;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label teamInformation;
        private System.Windows.Forms.Label resLabel2;
        private System.Windows.Forms.Label undeadSymbol;
        private System.Windows.Forms.Label humanSymbol;
        private System.Windows.Forms.Label heartSymbol;
        private System.Windows.Forms.Label diamondSymbol;
        private System.Windows.Forms.Label allTeamResources;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label humanWarResources;
        private System.Windows.Forms.Label undeadWarResources;
        private System.Windows.Forms.Label steelLabel;
        private System.Windows.Forms.Label ironLabel;
        private System.Windows.Forms.Label coalLabel;
        private System.Windows.Forms.Label humanSteel;
        private System.Windows.Forms.Label humanIron;
        private System.Windows.Forms.Label humanCoal;
        private System.Windows.Forms.Label steelLabel2;
        private System.Windows.Forms.Label ironLabel2;
        private System.Windows.Forms.Label coalLabel2;
        private System.Windows.Forms.Label undeadSteel;
        private System.Windows.Forms.Label undeadIron;
        private System.Windows.Forms.Label UndeadCoal;
    }
}


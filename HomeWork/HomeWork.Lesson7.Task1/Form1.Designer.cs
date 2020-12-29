
namespace HomeWork.Lesson7.Task1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tControlMain = new System.Windows.Forms.TabControl();
            this.tPageGameDoubler = new System.Windows.Forms.TabPage();
            this.labelG1CountStepsSum = new System.Windows.Forms.Label();
            this.labelG1CountSteps = new System.Windows.Forms.Label();
            this.buttonG1Plus = new System.Windows.Forms.Button();
            this.buttonG1Multi = new System.Windows.Forms.Button();
            this.labelG1YourNumber = new System.Windows.Forms.Label();
            this.labelG1yourdesc = new System.Windows.Forms.Label();
            this.labelG1Number = new System.Windows.Forms.Label();
            this.labelG1desc = new System.Windows.Forms.Label();
            this.buttonG1Back = new System.Windows.Forms.Button();
            this.labelGame1 = new System.Windows.Forms.Label();
            this.tPageGameGuessTheNumber = new System.Windows.Forms.TabPage();
            this.labelGame2 = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playDoublerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGuessTheNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelG2CountStepsSum = new System.Windows.Forms.Label();
            this.labelG2CountSteps = new System.Windows.Forms.Label();
            this.labelG2Description = new System.Windows.Forms.Label();
            this.tbG2Own = new System.Windows.Forms.TextBox();
            this.tControlMain.SuspendLayout();
            this.tPageGameDoubler.SuspendLayout();
            this.tPageGameGuessTheNumber.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tControlMain
            // 
            this.tControlMain.Controls.Add(this.tPageGameDoubler);
            this.tControlMain.Controls.Add(this.tPageGameGuessTheNumber);
            this.tControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControlMain.Location = new System.Drawing.Point(0, 24);
            this.tControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tControlMain.Name = "tControlMain";
            this.tControlMain.SelectedIndex = 0;
            this.tControlMain.Size = new System.Drawing.Size(275, 342);
            this.tControlMain.TabIndex = 0;
            // 
            // tPageGameDoubler
            // 
            this.tPageGameDoubler.Controls.Add(this.labelG1CountStepsSum);
            this.tPageGameDoubler.Controls.Add(this.labelG1CountSteps);
            this.tPageGameDoubler.Controls.Add(this.buttonG1Plus);
            this.tPageGameDoubler.Controls.Add(this.buttonG1Multi);
            this.tPageGameDoubler.Controls.Add(this.labelG1YourNumber);
            this.tPageGameDoubler.Controls.Add(this.labelG1yourdesc);
            this.tPageGameDoubler.Controls.Add(this.labelG1Number);
            this.tPageGameDoubler.Controls.Add(this.labelG1desc);
            this.tPageGameDoubler.Controls.Add(this.buttonG1Back);
            this.tPageGameDoubler.Controls.Add(this.labelGame1);
            this.tPageGameDoubler.Location = new System.Drawing.Point(4, 22);
            this.tPageGameDoubler.Margin = new System.Windows.Forms.Padding(2);
            this.tPageGameDoubler.Name = "tPageGameDoubler";
            this.tPageGameDoubler.Padding = new System.Windows.Forms.Padding(2);
            this.tPageGameDoubler.Size = new System.Drawing.Size(267, 316);
            this.tPageGameDoubler.TabIndex = 0;
            this.tPageGameDoubler.Text = "Doubler Game";
            this.tPageGameDoubler.UseVisualStyleBackColor = true;
            // 
            // labelG1CountStepsSum
            // 
            this.labelG1CountStepsSum.AutoSize = true;
            this.labelG1CountStepsSum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1CountStepsSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelG1CountStepsSum.Location = new System.Drawing.Point(132, 258);
            this.labelG1CountStepsSum.Name = "labelG1CountStepsSum";
            this.labelG1CountStepsSum.Size = new System.Drawing.Size(15, 15);
            this.labelG1CountStepsSum.TabIndex = 11;
            this.labelG1CountStepsSum.Text = "0 ";
            this.labelG1CountStepsSum.Visible = false;
            // 
            // labelG1CountSteps
            // 
            this.labelG1CountSteps.AutoSize = true;
            this.labelG1CountSteps.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1CountSteps.Location = new System.Drawing.Point(22, 258);
            this.labelG1CountSteps.Name = "labelG1CountSteps";
            this.labelG1CountSteps.Size = new System.Drawing.Size(112, 15);
            this.labelG1CountSteps.TabIndex = 10;
            this.labelG1CountSteps.Text = "Количество команд : ";
            this.labelG1CountSteps.Visible = false;
            // 
            // buttonG1Plus
            // 
            this.buttonG1Plus.Location = new System.Drawing.Point(16, 34);
            this.buttonG1Plus.Name = "buttonG1Plus";
            this.buttonG1Plus.Size = new System.Drawing.Size(75, 50);
            this.buttonG1Plus.TabIndex = 9;
            this.buttonG1Plus.Text = "+ 1";
            this.buttonG1Plus.UseVisualStyleBackColor = true;
            this.buttonG1Plus.Visible = false;
            this.buttonG1Plus.Click += new System.EventHandler(this.buttonG1Plus_Click);
            // 
            // buttonG1Multi
            // 
            this.buttonG1Multi.Location = new System.Drawing.Point(16, 95);
            this.buttonG1Multi.Name = "buttonG1Multi";
            this.buttonG1Multi.Size = new System.Drawing.Size(75, 50);
            this.buttonG1Multi.TabIndex = 8;
            this.buttonG1Multi.Text = "* 2";
            this.buttonG1Multi.UseVisualStyleBackColor = true;
            this.buttonG1Multi.Visible = false;
            this.buttonG1Multi.Click += new System.EventHandler(this.buttonG1Multi_Click);
            // 
            // labelG1YourNumber
            // 
            this.labelG1YourNumber.AutoSize = true;
            this.labelG1YourNumber.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1YourNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelG1YourNumber.Location = new System.Drawing.Point(127, 169);
            this.labelG1YourNumber.Name = "labelG1YourNumber";
            this.labelG1YourNumber.Size = new System.Drawing.Size(76, 39);
            this.labelG1YourNumber.TabIndex = 7;
            this.labelG1YourNumber.Text = "num";
            this.labelG1YourNumber.Visible = false;
            // 
            // labelG1yourdesc
            // 
            this.labelG1yourdesc.AutoSize = true;
            this.labelG1yourdesc.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1yourdesc.Location = new System.Drawing.Point(107, 125);
            this.labelG1yourdesc.Name = "labelG1yourdesc";
            this.labelG1yourdesc.Size = new System.Drawing.Size(71, 15);
            this.labelG1yourdesc.TabIndex = 6;
            this.labelG1yourdesc.Text = "Ваше число : ";
            this.labelG1yourdesc.Visible = false;
            // 
            // labelG1Number
            // 
            this.labelG1Number.AutoSize = true;
            this.labelG1Number.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1Number.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelG1Number.Location = new System.Drawing.Point(127, 64);
            this.labelG1Number.Name = "labelG1Number";
            this.labelG1Number.Size = new System.Drawing.Size(76, 39);
            this.labelG1Number.TabIndex = 5;
            this.labelG1Number.Text = "num";
            this.labelG1Number.Visible = false;
            // 
            // labelG1desc
            // 
            this.labelG1desc.AutoSize = true;
            this.labelG1desc.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG1desc.Location = new System.Drawing.Point(107, 33);
            this.labelG1desc.Name = "labelG1desc";
            this.labelG1desc.Size = new System.Drawing.Size(102, 15);
            this.labelG1desc.TabIndex = 4;
            this.labelG1desc.Text = "Дойдите до числа : ";
            this.labelG1desc.Visible = false;
            // 
            // buttonG1Back
            // 
            this.buttonG1Back.Location = new System.Drawing.Point(16, 155);
            this.buttonG1Back.Name = "buttonG1Back";
            this.buttonG1Back.Size = new System.Drawing.Size(75, 50);
            this.buttonG1Back.TabIndex = 3;
            this.buttonG1Back.Text = "Ход назад";
            this.buttonG1Back.UseVisualStyleBackColor = true;
            this.buttonG1Back.Visible = false;
            this.buttonG1Back.Click += new System.EventHandler(this.buttonG1Back_Click);
            // 
            // labelGame1
            // 
            this.labelGame1.AutoSize = true;
            this.labelGame1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGame1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelGame1.Location = new System.Drawing.Point(20, 140);
            this.labelGame1.Name = "labelGame1";
            this.labelGame1.Size = new System.Drawing.Size(229, 29);
            this.labelGame1.TabIndex = 0;
            this.labelGame1.Text = "press ctrl + A to play";
            this.labelGame1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tPageGameGuessTheNumber
            // 
            this.tPageGameGuessTheNumber.Controls.Add(this.tbG2Own);
            this.tPageGameGuessTheNumber.Controls.Add(this.labelG2Description);
            this.tPageGameGuessTheNumber.Controls.Add(this.labelG2CountStepsSum);
            this.tPageGameGuessTheNumber.Controls.Add(this.labelG2CountSteps);
            this.tPageGameGuessTheNumber.Controls.Add(this.labelGame2);
            this.tPageGameGuessTheNumber.Location = new System.Drawing.Point(4, 22);
            this.tPageGameGuessTheNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tPageGameGuessTheNumber.Name = "tPageGameGuessTheNumber";
            this.tPageGameGuessTheNumber.Padding = new System.Windows.Forms.Padding(2);
            this.tPageGameGuessTheNumber.Size = new System.Drawing.Size(267, 316);
            this.tPageGameGuessTheNumber.TabIndex = 1;
            this.tPageGameGuessTheNumber.Text = "Guess the number";
            this.tPageGameGuessTheNumber.UseVisualStyleBackColor = true;
            // 
            // labelGame2
            // 
            this.labelGame2.AutoSize = true;
            this.labelGame2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGame2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelGame2.Location = new System.Drawing.Point(20, 140);
            this.labelGame2.Name = "labelGame2";
            this.labelGame2.Size = new System.Drawing.Size(230, 29);
            this.labelGame2.TabIndex = 1;
            this.labelGame2.Text = "press ctrl + B to play";
            this.labelGame2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(275, 24);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "menuStrip1";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiMenu.Size = new System.Drawing.Size(53, 20);
            this.tsmiMenu.Text = "Меню";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playDoublerToolStripMenuItem,
            this.playGuessTheNumberToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Games";
            // 
            // playDoublerToolStripMenuItem
            // 
            this.playDoublerToolStripMenuItem.Name = "playDoublerToolStripMenuItem";
            this.playDoublerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.playDoublerToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.playDoublerToolStripMenuItem.Text = "Play Doubler";
            this.playDoublerToolStripMenuItem.Click += new System.EventHandler(this.playDoublerToolStripMenuItem_Click);
            // 
            // playGuessTheNumberToolStripMenuItem
            // 
            this.playGuessTheNumberToolStripMenuItem.Name = "playGuessTheNumberToolStripMenuItem";
            this.playGuessTheNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.playGuessTheNumberToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.playGuessTheNumberToolStripMenuItem.Text = "Play Guess the number";
            this.playGuessTheNumberToolStripMenuItem.Click += new System.EventHandler(this.playGuessTheNumberToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // labelG2CountStepsSum
            // 
            this.labelG2CountStepsSum.AutoSize = true;
            this.labelG2CountStepsSum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG2CountStepsSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelG2CountStepsSum.Location = new System.Drawing.Point(132, 258);
            this.labelG2CountStepsSum.Name = "labelG2CountStepsSum";
            this.labelG2CountStepsSum.Size = new System.Drawing.Size(15, 15);
            this.labelG2CountStepsSum.TabIndex = 13;
            this.labelG2CountStepsSum.Text = "0 ";
            this.labelG2CountStepsSum.Visible = false;
            // 
            // labelG2CountSteps
            // 
            this.labelG2CountSteps.AutoSize = true;
            this.labelG2CountSteps.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG2CountSteps.Location = new System.Drawing.Point(22, 258);
            this.labelG2CountSteps.Name = "labelG2CountSteps";
            this.labelG2CountSteps.Size = new System.Drawing.Size(117, 15);
            this.labelG2CountSteps.TabIndex = 12;
            this.labelG2CountSteps.Text = "Количество попыток : ";
            this.labelG2CountSteps.Visible = false;
            // 
            // labelG2Description
            // 
            this.labelG2Description.AutoSize = true;
            this.labelG2Description.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG2Description.Location = new System.Drawing.Point(11, 66);
            this.labelG2Description.Name = "labelG2Description";
            this.labelG2Description.Size = new System.Drawing.Size(248, 15);
            this.labelG2Description.TabIndex = 14;
            this.labelG2Description.Text = "Я загадал число от 1 до 100, попробуйте отгадать";
            this.labelG2Description.Visible = false;
            // 
            // tbG2Own
            // 
            this.tbG2Own.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbG2Own.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbG2Own.Location = new System.Drawing.Point(100, 112);
            this.tbG2Own.MaxLength = 3;
            this.tbG2Own.Name = "tbG2Own";
            this.tbG2Own.Size = new System.Drawing.Size(63, 53);
            this.tbG2Own.TabIndex = 15;
            this.tbG2Own.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbG2Own.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 366);
            this.Controls.Add(this.tControlMain);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tsMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lesson 7 | Task1 & Task 2";
            this.tControlMain.ResumeLayout(false);
            this.tPageGameDoubler.ResumeLayout(false);
            this.tPageGameDoubler.PerformLayout();
            this.tPageGameGuessTheNumber.ResumeLayout(false);
            this.tPageGameGuessTheNumber.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tControlMain;
        private System.Windows.Forms.TabPage tPageGameDoubler;
        private System.Windows.Forms.TabPage tPageGameGuessTheNumber;
        private System.Windows.Forms.MenuStrip tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label labelGame1;
        private System.Windows.Forms.Label labelGame2;
        private System.Windows.Forms.ToolStripMenuItem playDoublerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGuessTheNumberToolStripMenuItem;
        private System.Windows.Forms.Button buttonG1Back;
        private System.Windows.Forms.Label labelG1desc;
        private System.Windows.Forms.Label labelG1Number;
        private System.Windows.Forms.Label labelG1yourdesc;
        private System.Windows.Forms.Label labelG1YourNumber;
        private System.Windows.Forms.Button buttonG1Plus;
        private System.Windows.Forms.Button buttonG1Multi;
        private System.Windows.Forms.Label labelG1CountSteps;
        private System.Windows.Forms.Label labelG1CountStepsSum;
        private System.Windows.Forms.Label labelG2CountStepsSum;
        private System.Windows.Forms.Label labelG2CountSteps;
        private System.Windows.Forms.TextBox tbG2Own;
        private System.Windows.Forms.Label labelG2Description;
    }
}


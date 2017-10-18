namespace Инфа_5
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStepDec = new System.Windows.Forms.Button();
            this.btnStepInc = new System.Windows.Forms.Button();
            this.lblCoordX = new System.Windows.Forms.Label();
            this.lblCoordY = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblTextX = new System.Windows.Forms.Label();
            this.lblTextY = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 415);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStepDec
            // 
            this.btnStepDec.Location = new System.Drawing.Point(842, 376);
            this.btnStepDec.Name = "btnStepDec";
            this.btnStepDec.Size = new System.Drawing.Size(23, 23);
            this.btnStepDec.TabIndex = 13;
            this.btnStepDec.Text = "-";
            this.btnStepDec.UseVisualStyleBackColor = true;
            this.btnStepDec.Click += new System.EventHandler(this.btnStepDec_Click);
            // 
            // btnStepInc
            // 
            this.btnStepInc.Location = new System.Drawing.Point(894, 376);
            this.btnStepInc.Name = "btnStepInc";
            this.btnStepInc.Size = new System.Drawing.Size(22, 23);
            this.btnStepInc.TabIndex = 13;
            this.btnStepInc.Text = "+";
            this.btnStepInc.UseVisualStyleBackColor = true;
            this.btnStepInc.Click += new System.EventHandler(this.btnStepInc_Click);
            // 
            // lblCoordX
            // 
            this.lblCoordX.AutoSize = true;
            this.lblCoordX.Location = new System.Drawing.Point(860, 50);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(33, 13);
            this.lblCoordX.TabIndex = 14;
            this.lblCoordX.Text = "None";
            // 
            // lblCoordY
            // 
            this.lblCoordY.AutoSize = true;
            this.lblCoordY.Location = new System.Drawing.Point(860, 28);
            this.lblCoordY.Name = "lblCoordY";
            this.lblCoordY.Size = new System.Drawing.Size(33, 13);
            this.lblCoordY.TabIndex = 14;
            this.lblCoordY.Text = "None";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(839, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(839, 97);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(77, 23);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblTextX
            // 
            this.lblTextX.AutoSize = true;
            this.lblTextX.Location = new System.Drawing.Point(836, 28);
            this.lblTextX.Name = "lblTextX";
            this.lblTextX.Size = new System.Drawing.Size(17, 13);
            this.lblTextX.TabIndex = 15;
            this.lblTextX.Text = "X:";
            // 
            // lblTextY
            // 
            this.lblTextY.AutoSize = true;
            this.lblTextY.Location = new System.Drawing.Point(836, 50);
            this.lblTextY.Name = "lblTextY";
            this.lblTextY.Size = new System.Drawing.Size(17, 13);
            this.lblTextY.TabIndex = 15;
            this.lblTextY.Text = "Y:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(961, 24);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 454);
            this.Controls.Add(this.lblTextY);
            this.Controls.Add(this.lblTextX);
            this.Controls.Add(this.lblCoordY);
            this.Controls.Add(this.lblCoordX);
            this.Controls.Add(this.btnStepInc);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStepDec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStepDec;
        private System.Windows.Forms.Button btnStepInc;
        private System.Windows.Forms.Label lblCoordX;
        private System.Windows.Forms.Label lblCoordY;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblTextX;
        private System.Windows.Forms.Label lblTextY;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


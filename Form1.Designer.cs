
namespace EdediUsullar
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.lblDovrsayi = new System.Windows.Forms.Label();
            this.lblAraliq = new System.Windows.Forms.Label();
            this.lblFunksiya = new System.Windows.Forms.Label();
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.lblFinalResultFX = new System.Windows.Forms.Label();
            this.lblFinalResultX = new System.Windows.Forms.Label();
            this.dgwResult = new System.Windows.Forms.DataGridView();
            this.gbxInput.SuspendLayout();
            this.gbxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnCalculate);
            this.gbxInput.Controls.Add(this.txtFunction);
            this.gbxInput.Controls.Add(this.label3);
            this.gbxInput.Controls.Add(this.txtB);
            this.gbxInput.Controls.Add(this.label2);
            this.gbxInput.Controls.Add(this.txtA);
            this.gbxInput.Controls.Add(this.label1);
            this.gbxInput.Controls.Add(this.txtIteration);
            this.gbxInput.Controls.Add(this.lblDovrsayi);
            this.gbxInput.Controls.Add(this.lblAraliq);
            this.gbxInput.Controls.Add(this.lblFunksiya);
            this.gbxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxInput.Location = new System.Drawing.Point(0, 0);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(1250, 194);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "Input";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1087, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 40);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Hesabla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(88, 42);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(370, 23);
            this.txtFunction.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "]";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(175, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(35, 23);
            this.txtB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = ";";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 81);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(35, 23);
            this.txtA.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "[";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(88, 128);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(59, 23);
            this.txtIteration.TabIndex = 13;
            // 
            // lblDovrsayi
            // 
            this.lblDovrsayi.AutoSize = true;
            this.lblDovrsayi.Location = new System.Drawing.Point(12, 131);
            this.lblDovrsayi.Name = "lblDovrsayi";
            this.lblDovrsayi.Size = new System.Drawing.Size(56, 15);
            this.lblDovrsayi.TabIndex = 12;
            this.lblDovrsayi.Text = "Dövr Sayı";
            // 
            // lblAraliq
            // 
            this.lblAraliq.AutoSize = true;
            this.lblAraliq.Location = new System.Drawing.Point(12, 86);
            this.lblAraliq.Name = "lblAraliq";
            this.lblAraliq.Size = new System.Drawing.Size(38, 15);
            this.lblAraliq.TabIndex = 11;
            this.lblAraliq.Text = "Aralıq";
            // 
            // lblFunksiya
            // 
            this.lblFunksiya.AutoSize = true;
            this.lblFunksiya.Location = new System.Drawing.Point(12, 45);
            this.lblFunksiya.Name = "lblFunksiya";
            this.lblFunksiya.Size = new System.Drawing.Size(53, 15);
            this.lblFunksiya.TabIndex = 10;
            this.lblFunksiya.Text = "Funksiya";
            // 
            // gbxResult
            // 
            this.gbxResult.Controls.Add(this.lblFinalResultFX);
            this.gbxResult.Controls.Add(this.lblFinalResultX);
            this.gbxResult.Controls.Add(this.dgwResult);
            this.gbxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxResult.Location = new System.Drawing.Point(0, 194);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(1250, 440);
            this.gbxResult.TabIndex = 1;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Result";
            // 
            // lblFinalResultFX
            // 
            this.lblFinalResultFX.AutoSize = true;
            this.lblFinalResultFX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalResultFX.Location = new System.Drawing.Point(12, 380);
            this.lblFinalResultFX.Name = "lblFinalResultFX";
            this.lblFinalResultFX.Size = new System.Drawing.Size(0, 28);
            this.lblFinalResultFX.TabIndex = 2;
            // 
            // lblFinalResultX
            // 
            this.lblFinalResultX.AutoSize = true;
            this.lblFinalResultX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalResultX.Location = new System.Drawing.Point(12, 339);
            this.lblFinalResultX.Name = "lblFinalResultX";
            this.lblFinalResultX.Size = new System.Drawing.Size(0, 28);
            this.lblFinalResultX.TabIndex = 1;
            // 
            // dgwResult
            // 
            this.dgwResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwResult.Location = new System.Drawing.Point(3, 19);
            this.dgwResult.Name = "dgwResult";
            this.dgwResult.RowTemplate.Height = 25;
            this.dgwResult.Size = new System.Drawing.Size(1244, 275);
            this.dgwResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 634);
            this.Controls.Add(this.gbxResult);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxResult.ResumeLayout(false);
            this.gbxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Label lblDovrsayi;
        private System.Windows.Forms.Label lblAraliq;
        private System.Windows.Forms.Label lblFunksiya;
        private System.Windows.Forms.GroupBox gbxResult;
        private System.Windows.Forms.Label lblFinalResultFX;
        private System.Windows.Forms.Label lblFinalResultX;
        private System.Windows.Forms.DataGridView dgwResult;
    }
}


﻿namespace Kevin_Ma_Lab05_Ex01
{
    partial class GenericLinearSearchMethodTestForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.generateArrayGrpBox = new System.Windows.Forms.GroupBox();
            this.numOfEleLbl = new System.Windows.Forms.Label();
            this.searchGrpBox = new System.Windows.Forms.GroupBox();
            this.searchValLbl = new System.Windows.Forms.Label();
            this.numOfEleTb = new System.Windows.Forms.TextBox();
            this.searchKeyTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.generateDoubleArrayBtn = new System.Windows.Forms.Button();
            this.generateIntArrayBtn = new System.Windows.Forms.Button();
            this.generatedLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.queryResultsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.generateArrayGrpBox.SuspendLayout();
            this.searchGrpBox.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.generateArrayGrpBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.queryResultsGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.searchGrpBox);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 0;
            // 
            // generateArrayGrpBox
            // 
            this.generateArrayGrpBox.Controls.Add(this.listBox1);
            this.generateArrayGrpBox.Controls.Add(this.generatedLbl);
            this.generateArrayGrpBox.Controls.Add(this.generateDoubleArrayBtn);
            this.generateArrayGrpBox.Controls.Add(this.generateIntArrayBtn);
            this.generateArrayGrpBox.Controls.Add(this.numOfEleTb);
            this.generateArrayGrpBox.Controls.Add(this.numOfEleLbl);
            this.generateArrayGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateArrayGrpBox.Location = new System.Drawing.Point(12, 12);
            this.generateArrayGrpBox.Name = "generateArrayGrpBox";
            this.generateArrayGrpBox.Size = new System.Drawing.Size(283, 417);
            this.generateArrayGrpBox.TabIndex = 1;
            this.generateArrayGrpBox.TabStop = false;
            this.generateArrayGrpBox.Text = "Array Generation";
            // 
            // numOfEleLbl
            // 
            this.numOfEleLbl.AutoSize = true;
            this.numOfEleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfEleLbl.Location = new System.Drawing.Point(6, 34);
            this.numOfEleLbl.Name = "numOfEleLbl";
            this.numOfEleLbl.Size = new System.Drawing.Size(120, 13);
            this.numOfEleLbl.TabIndex = 0;
            this.numOfEleLbl.Text = "Number of Elements";
            // 
            // searchGrpBox
            // 
            this.searchGrpBox.Controls.Add(this.clearBtn);
            this.searchGrpBox.Controls.Add(this.searchBtn);
            this.searchGrpBox.Controls.Add(this.searchKeyTb);
            this.searchGrpBox.Controls.Add(this.searchValLbl);
            this.searchGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrpBox.Location = new System.Drawing.Point(4, 13);
            this.searchGrpBox.Name = "searchGrpBox";
            this.searchGrpBox.Size = new System.Drawing.Size(306, 93);
            this.searchGrpBox.TabIndex = 0;
            this.searchGrpBox.TabStop = false;
            this.searchGrpBox.Text = "Search";
            // 
            // searchValLbl
            // 
            this.searchValLbl.AutoSize = true;
            this.searchValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchValLbl.Location = new System.Drawing.Point(3, 34);
            this.searchValLbl.Name = "searchValLbl";
            this.searchValLbl.Size = new System.Drawing.Size(76, 13);
            this.searchValLbl.TabIndex = 0;
            this.searchValLbl.Text = "Search Key:";
            // 
            // numOfEleTb
            // 
            this.numOfEleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfEleTb.Location = new System.Drawing.Point(132, 32);
            this.numOfEleTb.Name = "numOfEleTb";
            this.numOfEleTb.Size = new System.Drawing.Size(145, 20);
            this.numOfEleTb.TabIndex = 1;
            // 
            // searchKeyTb
            // 
            this.searchKeyTb.Enabled = false;
            this.searchKeyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeyTb.Location = new System.Drawing.Point(85, 31);
            this.searchKeyTb.Name = "searchKeyTb";
            this.searchKeyTb.Size = new System.Drawing.Size(145, 20);
            this.searchKeyTb.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(28, 57);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(126, 57);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(92, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // generateDoubleArrayBtn
            // 
            this.generateDoubleArrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateDoubleArrayBtn.Location = new System.Drawing.Point(132, 58);
            this.generateDoubleArrayBtn.Name = "generateDoubleArrayBtn";
            this.generateDoubleArrayBtn.Size = new System.Drawing.Size(92, 23);
            this.generateDoubleArrayBtn.TabIndex = 6;
            this.generateDoubleArrayBtn.Text = "Double Array";
            this.generateDoubleArrayBtn.UseVisualStyleBackColor = true;
            // 
            // generateIntArrayBtn
            // 
            this.generateIntArrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateIntArrayBtn.Location = new System.Drawing.Point(34, 58);
            this.generateIntArrayBtn.Name = "generateIntArrayBtn";
            this.generateIntArrayBtn.Size = new System.Drawing.Size(92, 23);
            this.generateIntArrayBtn.TabIndex = 5;
            this.generateIntArrayBtn.Text = "Int Array";
            this.generateIntArrayBtn.UseVisualStyleBackColor = true;
            // 
            // generatedLbl
            // 
            this.generatedLbl.AutoSize = true;
            this.generatedLbl.Location = new System.Drawing.Point(6, 100);
            this.generatedLbl.Name = "generatedLbl";
            this.generatedLbl.Size = new System.Drawing.Size(151, 31);
            this.generatedLbl.TabIndex = 7;
            this.generatedLbl.Text = "Generated";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 277);
            this.listBox1.TabIndex = 8;
            // 
            // queryResultsGroupBox
            // 
            this.queryResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResultsGroupBox.Location = new System.Drawing.Point(4, 112);
            this.queryResultsGroupBox.Name = "queryResultsGroupBox";
            this.queryResultsGroupBox.Size = new System.Drawing.Size(306, 312);
            this.queryResultsGroupBox.TabIndex = 1;
            this.queryResultsGroupBox.TabStop = false;
            this.queryResultsGroupBox.Text = "Query Results";
            // 
            // GenericLinearSearchMethodTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GenericLinearSearchMethodTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Linear Search Method";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.generateArrayGrpBox.ResumeLayout(false);
            this.generateArrayGrpBox.PerformLayout();
            this.searchGrpBox.ResumeLayout(false);
            this.searchGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox generateArrayGrpBox;
        private System.Windows.Forms.Label numOfEleLbl;
        private System.Windows.Forms.GroupBox searchGrpBox;
        private System.Windows.Forms.Label searchValLbl;
        private System.Windows.Forms.TextBox numOfEleTb;
        private System.Windows.Forms.TextBox searchKeyTb;
        private System.Windows.Forms.Button generateDoubleArrayBtn;
        private System.Windows.Forms.Button generateIntArrayBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label generatedLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox queryResultsGroupBox;
    }
}


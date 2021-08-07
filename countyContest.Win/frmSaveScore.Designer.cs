
namespace countyContest.Win
{
    partial class frmSaveScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncorrectAnswer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNickname = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNickname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corrected Answer : ";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.AutoSize = true;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtCorrectAnswer.Location = new System.Drawing.Point(196, 21);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(14, 17);
            this.txtCorrectAnswer.TabIndex = 1;
            this.txtCorrectAnswer.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incorrected Answer : ";
            // 
            // txtIncorrectAnswer
            // 
            this.txtIncorrectAnswer.AutoSize = true;
            this.txtIncorrectAnswer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtIncorrectAnswer.Location = new System.Drawing.Point(196, 61);
            this.txtIncorrectAnswer.Name = "txtIncorrectAnswer";
            this.txtIncorrectAnswer.Size = new System.Drawing.Size(14, 17);
            this.txtIncorrectAnswer.TabIndex = 3;
            this.txtIncorrectAnswer.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Points :";
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.AutoSize = true;
            this.txtTotalPoints.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalPoints.Location = new System.Drawing.Point(196, 100);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.Size = new System.Drawing.Size(14, 17);
            this.txtTotalPoints.TabIndex = 5;
            this.txtTotalPoints.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nickname : ";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(147, 176);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(252, 20);
            this.txtNickname.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Location = new System.Drawing.Point(26, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSaveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 472);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncorrectAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(644, 504);
            this.Name = "frmSaveScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Scrore Screen";
            this.Load += new System.EventHandler(this.frmSaveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNickname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCorrectAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtIncorrectAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTotalPoints;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtNickname;
        private System.Windows.Forms.Button btnSave;
    }
}
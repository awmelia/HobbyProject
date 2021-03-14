namespace MuscleTrackerApp
{
    partial class MuscleForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExerciseType = new System.Windows.Forms.TabPage();
            this.tabPageExercise = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.labelWithWeights = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageExerciseType.SuspendLayout();
            this.tabPageExercise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageExerciseType);
            this.tabControl1.Controls.Add(this.tabPageExercise);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 202);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageExerciseType
            // 
            this.tabPageExerciseType.Controls.Add(this.dataGridView1);
            this.tabPageExerciseType.Controls.Add(this.radioButtonNo);
            this.tabPageExerciseType.Controls.Add(this.radioButtonYes);
            this.tabPageExerciseType.Controls.Add(this.labelWithWeights);
            this.tabPageExerciseType.Controls.Add(this.S);
            this.tabPageExerciseType.Controls.Add(this.label1);
            this.tabPageExerciseType.Location = new System.Drawing.Point(4, 22);
            this.tabPageExerciseType.Name = "tabPageExerciseType";
            this.tabPageExerciseType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExerciseType.Size = new System.Drawing.Size(593, 176);
            this.tabPageExerciseType.TabIndex = 0;
            this.tabPageExerciseType.Text = "ExerciseType";
            this.tabPageExerciseType.UseVisualStyleBackColor = true;
            // 
            // tabPageExercise
            // 
            this.tabPageExercise.Controls.Add(this.textBox1);
            this.tabPageExercise.Controls.Add(this.label3);
            this.tabPageExercise.Controls.Add(this.comboBox1);
            this.tabPageExercise.Controls.Add(this.label2);
            this.tabPageExercise.Location = new System.Drawing.Point(4, 22);
            this.tabPageExercise.Name = "tabPageExercise";
            this.tabPageExercise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExercise.Size = new System.Drawing.Size(593, 176);
            this.tabPageExercise.TabIndex = 1;
            this.tabPageExercise.Text = "Exercise";
            this.tabPageExercise.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(73, 37);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(128, 20);
            this.S.TabIndex = 1;
            // 
            // labelWithWeights
            // 
            this.labelWithWeights.AutoSize = true;
            this.labelWithWeights.Location = new System.Drawing.Point(20, 96);
            this.labelWithWeights.Name = "labelWithWeights";
            this.labelWithWeights.Size = new System.Drawing.Size(193, 13);
            this.labelWithWeights.TabIndex = 2;
            this.labelWithWeights.Text = "Does this exerciseType involve weights";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(53, 127);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(131, 127);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 175);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ExerciseType name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exercise name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            // 
            // MuscleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 210);
            this.Controls.Add(this.tabControl1);
            this.Name = "MuscleForm";
            this.Text = "MuscleForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageExerciseType.ResumeLayout(false);
            this.tabPageExerciseType.PerformLayout();
            this.tabPageExercise.ResumeLayout(false);
            this.tabPageExercise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageExerciseType;
        private System.Windows.Forms.TabPage tabPageExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Label labelWithWeights;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
﻿namespace BugTracker
{
    partial class AddProjectForm
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
            TB_ProjectName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DTP_Start = new DateTimePicker();
            DTP_End = new DateTimePicker();
            BT_Create = new Button();
            SuspendLayout();
            // 
            // TB_ProjectName
            // 
            TB_ProjectName.Location = new Point(188, 26);
            TB_ProjectName.Name = "TB_ProjectName";
            TB_ProjectName.Size = new Size(150, 31);
            TB_ProjectName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 29);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 3;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 74);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 111);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "End Date";
            // 
            // DTP_Start
            // 
            DTP_Start.Location = new Point(188, 69);
            DTP_Start.Name = "DTP_Start";
            DTP_Start.Size = new Size(300, 31);
            DTP_Start.TabIndex = 6;
            // 
            // DTP_End
            // 
            DTP_End.Location = new Point(188, 106);
            DTP_End.Name = "DTP_End";
            DTP_End.Size = new Size(300, 31);
            DTP_End.TabIndex = 7;
            // 
            // BT_Create
            // 
            BT_Create.Location = new Point(376, 171);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 8;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = true;
            BT_Create.Click += BT_Create_Click;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 319);
            Controls.Add(BT_Create);
            Controls.Add(DTP_End);
            Controls.Add(DTP_Start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_ProjectName);
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_ProjectName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker DTP_Start;
        private DateTimePicker DTP_End;
        private Button BT_Create;
    }
}
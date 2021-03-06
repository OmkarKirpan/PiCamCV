﻿namespace PiCamCV.WinForms.CameraConsumers
{
    partial class MotionDetectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControlOwner = new System.Windows.Forms.Panel();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxRepo = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBoxSubtractorConfig = new System.Windows.Forms.GroupBox();
            this.btnSetSubtractorConfig = new System.Windows.Forms.Button();
            this.chkBoxShadowDetection = new System.Windows.Forms.CheckBox();
            this.txtBoxThreshold = new System.Windows.Forms.TextBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.txtBoxHistory = new System.Windows.Forms.TextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.panelBiggestMode = new System.Windows.Forms.Panel();
            this.lblTargeting = new System.Windows.Forms.Label();
            this.ddlBiggestTargeting = new System.Windows.Forms.ComboBox();
            this.panelSettingsGroup = new System.Windows.Forms.Panel();
            this.sliderMaximumArea = new PiCamCV.WinForms.UserControls.SliderControl();
            this.chkRectangleStats = new System.Windows.Forms.CheckBox();
            this.sliderMinimumPercentMotion = new PiCamCV.WinForms.UserControls.SliderControl();
            this.sliderMinimumArea = new PiCamCV.WinForms.UserControls.SliderControl();
            this.sliderSize = new PiCamCV.WinForms.UserControls.SliderControl();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCaptured = new System.Windows.Forms.GroupBox();
            this.imageBoxCaptured = new Emgu.CV.UI.ImageBox();
            this.groupBoxMasked = new System.Windows.Forms.GroupBox();
            this.imageBoxMasked = new Emgu.CV.UI.ImageBox();
            this.groupBoxMotion = new System.Windows.Forms.GroupBox();
            this.imageBoxMotion = new Emgu.CV.UI.ImageBox();
            this.panelControlOwner.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxRepo.SuspendLayout();
            this.groupBoxSubtractorConfig.SuspendLayout();
            this.panelBiggestMode.SuspendLayout();
            this.panelSettingsGroup.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBoxCaptured.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCaptured)).BeginInit();
            this.groupBoxMasked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxMasked)).BeginInit();
            this.groupBoxMotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxMotion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlOwner
            // 
            this.panelControlOwner.Controls.Add(this.groupBoxSettings);
            this.panelControlOwner.Controls.Add(this.sliderSize);
            this.panelControlOwner.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlOwner.Location = new System.Drawing.Point(0, 0);
            this.panelControlOwner.Name = "panelControlOwner";
            this.panelControlOwner.Size = new System.Drawing.Size(200, 564);
            this.panelControlOwner.TabIndex = 0;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBoxRepo);
            this.groupBoxSettings.Controls.Add(this.groupBoxSubtractorConfig);
            this.groupBoxSettings.Controls.Add(this.panelBiggestMode);
            this.groupBoxSettings.Controls.Add(this.panelSettingsGroup);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSettings.Location = new System.Drawing.Point(0, 55);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 477);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // groupBoxRepo
            // 
            this.groupBoxRepo.Controls.Add(this.btnWrite);
            this.groupBoxRepo.Controls.Add(this.btnRead);
            this.groupBoxRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRepo.Location = new System.Drawing.Point(3, 374);
            this.groupBoxRepo.Name = "groupBoxRepo";
            this.groupBoxRepo.Size = new System.Drawing.Size(194, 50);
            this.groupBoxRepo.TabIndex = 7;
            this.groupBoxRepo.TabStop = false;
            this.groupBoxRepo.Text = "Settings Repository";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(91, 19);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(9, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // groupBoxSubtractorConfig
            // 
            this.groupBoxSubtractorConfig.Controls.Add(this.btnSetSubtractorConfig);
            this.groupBoxSubtractorConfig.Controls.Add(this.chkBoxShadowDetection);
            this.groupBoxSubtractorConfig.Controls.Add(this.txtBoxThreshold);
            this.groupBoxSubtractorConfig.Controls.Add(this.labelThreshold);
            this.groupBoxSubtractorConfig.Controls.Add(this.txtBoxHistory);
            this.groupBoxSubtractorConfig.Controls.Add(this.labelHistory);
            this.groupBoxSubtractorConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubtractorConfig.Location = new System.Drawing.Point(3, 231);
            this.groupBoxSubtractorConfig.Name = "groupBoxSubtractorConfig";
            this.groupBoxSubtractorConfig.Size = new System.Drawing.Size(194, 143);
            this.groupBoxSubtractorConfig.TabIndex = 6;
            this.groupBoxSubtractorConfig.TabStop = false;
            this.groupBoxSubtractorConfig.Text = "Subtractor Config";
            // 
            // btnSetSubtractorConfig
            // 
            this.btnSetSubtractorConfig.Location = new System.Drawing.Point(66, 108);
            this.btnSetSubtractorConfig.Name = "btnSetSubtractorConfig";
            this.btnSetSubtractorConfig.Size = new System.Drawing.Size(100, 25);
            this.btnSetSubtractorConfig.TabIndex = 5;
            this.btnSetSubtractorConfig.Text = "Set";
            this.btnSetSubtractorConfig.UseVisualStyleBackColor = true;
            this.btnSetSubtractorConfig.Click += new System.EventHandler(this.btnSetSubtractorConfig_Click);
            // 
            // chkBoxShadowDetection
            // 
            this.chkBoxShadowDetection.AutoSize = true;
            this.chkBoxShadowDetection.Location = new System.Drawing.Point(66, 85);
            this.chkBoxShadowDetection.Name = "chkBoxShadowDetection";
            this.chkBoxShadowDetection.Size = new System.Drawing.Size(114, 17);
            this.chkBoxShadowDetection.TabIndex = 4;
            this.chkBoxShadowDetection.Text = "Shadow Detection";
            this.chkBoxShadowDetection.UseVisualStyleBackColor = true;
            // 
            // txtBoxThreshold
            // 
            this.txtBoxThreshold.Location = new System.Drawing.Point(66, 54);
            this.txtBoxThreshold.Name = "txtBoxThreshold";
            this.txtBoxThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtBoxThreshold.TabIndex = 3;
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(6, 57);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(54, 13);
            this.labelThreshold.TabIndex = 2;
            this.labelThreshold.Text = "Threshold";
            // 
            // txtBoxHistory
            // 
            this.txtBoxHistory.Location = new System.Drawing.Point(66, 28);
            this.txtBoxHistory.Name = "txtBoxHistory";
            this.txtBoxHistory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHistory.TabIndex = 1;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(6, 31);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(39, 13);
            this.labelHistory.TabIndex = 0;
            this.labelHistory.Text = "History";
            // 
            // panelBiggestMode
            // 
            this.panelBiggestMode.Controls.Add(this.lblTargeting);
            this.panelBiggestMode.Controls.Add(this.ddlBiggestTargeting);
            this.panelBiggestMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBiggestMode.Location = new System.Drawing.Point(3, 191);
            this.panelBiggestMode.Name = "panelBiggestMode";
            this.panelBiggestMode.Size = new System.Drawing.Size(194, 40);
            this.panelBiggestMode.TabIndex = 10;
            // 
            // lblTargeting
            // 
            this.lblTargeting.AutoSize = true;
            this.lblTargeting.Location = new System.Drawing.Point(8, 9);
            this.lblTargeting.Name = "lblTargeting";
            this.lblTargeting.Size = new System.Drawing.Size(52, 13);
            this.lblTargeting.TabIndex = 10;
            this.lblTargeting.Text = "Targeting";
            // 
            // ddlBiggestTargeting
            // 
            this.ddlBiggestTargeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBiggestTargeting.FormattingEnabled = true;
            this.ddlBiggestTargeting.Items.AddRange(new object[] {
            "Area",
            "Pixels"});
            this.ddlBiggestTargeting.Location = new System.Drawing.Point(66, 6);
            this.ddlBiggestTargeting.Name = "ddlBiggestTargeting";
            this.ddlBiggestTargeting.Size = new System.Drawing.Size(121, 21);
            this.ddlBiggestTargeting.TabIndex = 9;
            this.ddlBiggestTargeting.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelSettingsGroup
            // 
            this.panelSettingsGroup.Controls.Add(this.sliderMaximumArea);
            this.panelSettingsGroup.Controls.Add(this.chkRectangleStats);
            this.panelSettingsGroup.Controls.Add(this.sliderMinimumPercentMotion);
            this.panelSettingsGroup.Controls.Add(this.sliderMinimumArea);
            this.panelSettingsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsGroup.Location = new System.Drawing.Point(3, 16);
            this.panelSettingsGroup.Name = "panelSettingsGroup";
            this.panelSettingsGroup.Size = new System.Drawing.Size(194, 175);
            this.panelSettingsGroup.TabIndex = 5;
            // 
            // sliderMaximumArea
            // 
            this.sliderMaximumArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderMaximumArea.Label = "Maximum Area";
            this.sliderMaximumArea.LargeChange = 30;
            this.sliderMaximumArea.Location = new System.Drawing.Point(0, 102);
            this.sliderMaximumArea.Maximum = 700;
            this.sliderMaximumArea.Minimum = 5;
            this.sliderMaximumArea.Name = "sliderMaximumArea";
            this.sliderMaximumArea.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderMaximumArea.Size = new System.Drawing.Size(194, 46);
            this.sliderMaximumArea.SmallChange = 10;
            this.sliderMaximumArea.TabIndex = 7;
            this.sliderMaximumArea.TickFrequency = 50;
            this.sliderMaximumArea.Value = 100;
            this.sliderMaximumArea.ValueChanged += new System.EventHandler(this.sliderMaximumArea_ValueChanged);
            // 
            // chkRectangleStats
            // 
            this.chkRectangleStats.AutoSize = true;
            this.chkRectangleStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkRectangleStats.Location = new System.Drawing.Point(0, 158);
            this.chkRectangleStats.Name = "chkRectangleStats";
            this.chkRectangleStats.Size = new System.Drawing.Size(194, 17);
            this.chkRectangleStats.TabIndex = 6;
            this.chkRectangleStats.Text = "Show Rectangle Stats";
            this.chkRectangleStats.UseVisualStyleBackColor = true;
            // 
            // sliderMinimumPercentMotion
            // 
            this.sliderMinimumPercentMotion.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderMinimumPercentMotion.Label = "Minimum Motion in Area (%)";
            this.sliderMinimumPercentMotion.LargeChange = 30;
            this.sliderMinimumPercentMotion.Location = new System.Drawing.Point(0, 46);
            this.sliderMinimumPercentMotion.Maximum = 100;
            this.sliderMinimumPercentMotion.Minimum = 1;
            this.sliderMinimumPercentMotion.Name = "sliderMinimumPercentMotion";
            this.sliderMinimumPercentMotion.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderMinimumPercentMotion.Size = new System.Drawing.Size(194, 56);
            this.sliderMinimumPercentMotion.SmallChange = 10;
            this.sliderMinimumPercentMotion.TabIndex = 5;
            this.sliderMinimumPercentMotion.TickFrequency = 5;
            this.sliderMinimumPercentMotion.Value = 100;
            this.sliderMinimumPercentMotion.ValueChanged += new System.EventHandler(this.sliderMinimumPercentMotion_ValueChanged);
            // 
            // sliderMinimumArea
            // 
            this.sliderMinimumArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderMinimumArea.Label = "Minimum Area";
            this.sliderMinimumArea.LargeChange = 30;
            this.sliderMinimumArea.Location = new System.Drawing.Point(0, 0);
            this.sliderMinimumArea.Maximum = 500;
            this.sliderMinimumArea.Minimum = 5;
            this.sliderMinimumArea.Name = "sliderMinimumArea";
            this.sliderMinimumArea.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderMinimumArea.Size = new System.Drawing.Size(194, 46);
            this.sliderMinimumArea.SmallChange = 10;
            this.sliderMinimumArea.TabIndex = 1;
            this.sliderMinimumArea.TickFrequency = 20;
            this.sliderMinimumArea.Value = 100;
            this.sliderMinimumArea.ValueChanged += new System.EventHandler(this.sliderMinimumArea_ValueChanged);
            // 
            // sliderSize
            // 
            this.sliderSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderSize.Label = "Image Scale";
            this.sliderSize.LargeChange = 5;
            this.sliderSize.Location = new System.Drawing.Point(0, 0);
            this.sliderSize.Maximum = 255;
            this.sliderSize.Minimum = 50;
            this.sliderSize.Name = "sliderSize";
            this.sliderSize.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderSize.Size = new System.Drawing.Size(200, 55);
            this.sliderSize.SmallChange = 1;
            this.sliderSize.TabIndex = 0;
            this.sliderSize.TickFrequency = 20;
            this.sliderSize.Value = 100;
            this.sliderSize.ValueChanged += new System.EventHandler(this.sliderControl1_ValueChanged);
            this.sliderSize.Load += new System.EventHandler(this.sliderSize_Load);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.groupBoxCaptured);
            this.flowLayoutPanel.Controls.Add(this.groupBoxMasked);
            this.flowLayoutPanel.Controls.Add(this.groupBoxMotion);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(703, 564);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // groupBoxCaptured
            // 
            this.groupBoxCaptured.Controls.Add(this.imageBoxCaptured);
            this.groupBoxCaptured.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCaptured.Name = "groupBoxCaptured";
            this.groupBoxCaptured.Size = new System.Drawing.Size(366, 231);
            this.groupBoxCaptured.TabIndex = 0;
            this.groupBoxCaptured.TabStop = false;
            this.groupBoxCaptured.Text = "Captured";
            // 
            // imageBoxCaptured
            // 
            this.imageBoxCaptured.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxCaptured.Location = new System.Drawing.Point(3, 16);
            this.imageBoxCaptured.Name = "imageBoxCaptured";
            this.imageBoxCaptured.Size = new System.Drawing.Size(360, 212);
            this.imageBoxCaptured.TabIndex = 4;
            this.imageBoxCaptured.TabStop = false;
            // 
            // groupBoxMasked
            // 
            this.groupBoxMasked.Controls.Add(this.imageBoxMasked);
            this.groupBoxMasked.Location = new System.Drawing.Point(375, 3);
            this.groupBoxMasked.Name = "groupBoxMasked";
            this.groupBoxMasked.Size = new System.Drawing.Size(226, 221);
            this.groupBoxMasked.TabIndex = 1;
            this.groupBoxMasked.TabStop = false;
            this.groupBoxMasked.Text = "Masked";
            // 
            // imageBoxMasked
            // 
            this.imageBoxMasked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxMasked.Location = new System.Drawing.Point(3, 16);
            this.imageBoxMasked.Name = "imageBoxMasked";
            this.imageBoxMasked.Size = new System.Drawing.Size(220, 202);
            this.imageBoxMasked.TabIndex = 4;
            this.imageBoxMasked.TabStop = false;
            // 
            // groupBoxMotion
            // 
            this.groupBoxMotion.Controls.Add(this.imageBoxMotion);
            this.groupBoxMotion.Location = new System.Drawing.Point(3, 240);
            this.groupBoxMotion.Name = "groupBoxMotion";
            this.groupBoxMotion.Size = new System.Drawing.Size(274, 250);
            this.groupBoxMotion.TabIndex = 2;
            this.groupBoxMotion.TabStop = false;
            this.groupBoxMotion.Text = "Motion";
            // 
            // imageBoxMotion
            // 
            this.imageBoxMotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxMotion.Location = new System.Drawing.Point(3, 16);
            this.imageBoxMotion.Name = "imageBoxMotion";
            this.imageBoxMotion.Size = new System.Drawing.Size(268, 231);
            this.imageBoxMotion.TabIndex = 4;
            this.imageBoxMotion.TabStop = false;
            // 
            // MotionDetectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelControlOwner);
            this.Name = "MotionDetectionControl";
            this.Size = new System.Drawing.Size(903, 564);
            this.Load += new System.EventHandler(this.MotionDetectionControl_Load);
            this.panelControlOwner.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxRepo.ResumeLayout(false);
            this.groupBoxSubtractorConfig.ResumeLayout(false);
            this.groupBoxSubtractorConfig.PerformLayout();
            this.panelBiggestMode.ResumeLayout(false);
            this.panelBiggestMode.PerformLayout();
            this.panelSettingsGroup.ResumeLayout(false);
            this.panelSettingsGroup.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.groupBoxCaptured.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCaptured)).EndInit();
            this.groupBoxMasked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxMasked)).EndInit();
            this.groupBoxMotion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxMotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlOwner;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBoxCaptured;
        private System.Windows.Forms.GroupBox groupBoxMasked;
        private System.Windows.Forms.GroupBox groupBoxMotion;
        private Emgu.CV.UI.ImageBox imageBoxCaptured;
        private Emgu.CV.UI.ImageBox imageBoxMasked;
        private Emgu.CV.UI.ImageBox imageBoxMotion;
        private UserControls.SliderControl sliderSize;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxSubtractorConfig;
        private System.Windows.Forms.Button btnSetSubtractorConfig;
        private System.Windows.Forms.CheckBox chkBoxShadowDetection;
        private System.Windows.Forms.TextBox txtBoxThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TextBox txtBoxHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Panel panelSettingsGroup;
        private UserControls.SliderControl sliderMinimumPercentMotion;
        private UserControls.SliderControl sliderMinimumArea;
        private System.Windows.Forms.GroupBox groupBoxRepo;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Panel panelBiggestMode;
        private System.Windows.Forms.Label lblTargeting;
        private System.Windows.Forms.ComboBox ddlBiggestTargeting;
        private System.Windows.Forms.CheckBox chkRectangleStats;
        private UserControls.SliderControl sliderMaximumArea;
    }
}

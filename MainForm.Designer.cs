﻿namespace Lab4
{
    partial class MainForm
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
            this.firstSignalLabel = new System.Windows.Forms.Label();
            this.firstSignalFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.firstSignalAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.firstSignalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.firstSignalInitialPhaseComboBox = new System.Windows.Forms.ComboBox();
            this.secondSignalInitialPhaseComboBox = new System.Windows.Forms.ComboBox();
            this.secondSignalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.secondSignalAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.secondSignalFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.secondSignalLabel = new System.Windows.Forms.Label();
            this.signalTypeLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.initialPhaseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstSignalPlotView = new OxyPlot.WindowsForms.PlotView();
            this.secondSignalPlotView = new OxyPlot.WindowsForms.PlotView();
            this.crossCorrelationRadioButton = new System.Windows.Forms.RadioButton();
            this.autoCorrelationRadioButton = new System.Windows.Forms.RadioButton();
            this.correlateButton = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // firstSignalLabel
            // 
            this.firstSignalLabel.AutoSize = true;
            this.firstSignalLabel.Location = new System.Drawing.Point(107, 13);
            this.firstSignalLabel.Name = "firstSignalLabel";
            this.firstSignalLabel.Size = new System.Drawing.Size(79, 20);
            this.firstSignalLabel.TabIndex = 0;
            this.firstSignalLabel.Text = "First signal";
            // 
            // firstSignalFrequencyTextBox
            // 
            this.firstSignalFrequencyTextBox.Location = new System.Drawing.Point(110, 85);
            this.firstSignalFrequencyTextBox.Name = "firstSignalFrequencyTextBox";
            this.firstSignalFrequencyTextBox.Size = new System.Drawing.Size(125, 27);
            this.firstSignalFrequencyTextBox.TabIndex = 1;
            // 
            // firstSignalAmplitudeTextBox
            // 
            this.firstSignalAmplitudeTextBox.Location = new System.Drawing.Point(110, 128);
            this.firstSignalAmplitudeTextBox.Name = "firstSignalAmplitudeTextBox";
            this.firstSignalAmplitudeTextBox.Size = new System.Drawing.Size(125, 27);
            this.firstSignalAmplitudeTextBox.TabIndex = 2;
            // 
            // firstSignalTypeComboBox
            // 
            this.firstSignalTypeComboBox.FormattingEnabled = true;
            this.firstSignalTypeComboBox.Items.AddRange(new object[] {
            "Sin",
            "Sawtooth",
            "Triangular"});
            this.firstSignalTypeComboBox.Location = new System.Drawing.Point(110, 38);
            this.firstSignalTypeComboBox.Name = "firstSignalTypeComboBox";
            this.firstSignalTypeComboBox.Size = new System.Drawing.Size(125, 28);
            this.firstSignalTypeComboBox.TabIndex = 3;
            // 
            // firstSignalInitialPhaseComboBox
            // 
            this.firstSignalInitialPhaseComboBox.FormattingEnabled = true;
            this.firstSignalInitialPhaseComboBox.Items.AddRange(new object[] {
            "0",
            "pi/2",
            "pi",
            "3pi/2"});
            this.firstSignalInitialPhaseComboBox.Location = new System.Drawing.Point(111, 173);
            this.firstSignalInitialPhaseComboBox.Name = "firstSignalInitialPhaseComboBox";
            this.firstSignalInitialPhaseComboBox.Size = new System.Drawing.Size(124, 28);
            this.firstSignalInitialPhaseComboBox.TabIndex = 4;
            // 
            // secondSignalInitialPhaseComboBox
            // 
            this.secondSignalInitialPhaseComboBox.FormattingEnabled = true;
            this.secondSignalInitialPhaseComboBox.Items.AddRange(new object[] {
            "0",
            "pi/2",
            "pi",
            "3pi/2"});
            this.secondSignalInitialPhaseComboBox.Location = new System.Drawing.Point(114, 384);
            this.secondSignalInitialPhaseComboBox.Name = "secondSignalInitialPhaseComboBox";
            this.secondSignalInitialPhaseComboBox.Size = new System.Drawing.Size(124, 28);
            this.secondSignalInitialPhaseComboBox.TabIndex = 9;
            // 
            // secondSignalTypeComboBox
            // 
            this.secondSignalTypeComboBox.FormattingEnabled = true;
            this.secondSignalTypeComboBox.Items.AddRange(new object[] {
            "Sin",
            "Sawtooth",
            "Triangular"});
            this.secondSignalTypeComboBox.Location = new System.Drawing.Point(113, 249);
            this.secondSignalTypeComboBox.Name = "secondSignalTypeComboBox";
            this.secondSignalTypeComboBox.Size = new System.Drawing.Size(125, 28);
            this.secondSignalTypeComboBox.TabIndex = 8;
            // 
            // secondSignalAmplitudeTextBox
            // 
            this.secondSignalAmplitudeTextBox.Location = new System.Drawing.Point(113, 339);
            this.secondSignalAmplitudeTextBox.Name = "secondSignalAmplitudeTextBox";
            this.secondSignalAmplitudeTextBox.Size = new System.Drawing.Size(125, 27);
            this.secondSignalAmplitudeTextBox.TabIndex = 7;
            // 
            // secondSignalFrequencyTextBox
            // 
            this.secondSignalFrequencyTextBox.Location = new System.Drawing.Point(113, 296);
            this.secondSignalFrequencyTextBox.Name = "secondSignalFrequencyTextBox";
            this.secondSignalFrequencyTextBox.Size = new System.Drawing.Size(125, 27);
            this.secondSignalFrequencyTextBox.TabIndex = 6;
            // 
            // secondSignalLabel
            // 
            this.secondSignalLabel.AutoSize = true;
            this.secondSignalLabel.Location = new System.Drawing.Point(110, 224);
            this.secondSignalLabel.Name = "secondSignalLabel";
            this.secondSignalLabel.Size = new System.Drawing.Size(101, 20);
            this.secondSignalLabel.TabIndex = 5;
            this.secondSignalLabel.Text = "Second signal";
            // 
            // signalTypeLabel
            // 
            this.signalTypeLabel.AutoSize = true;
            this.signalTypeLabel.Location = new System.Drawing.Point(12, 38);
            this.signalTypeLabel.Name = "signalTypeLabel";
            this.signalTypeLabel.Size = new System.Drawing.Size(40, 20);
            this.signalTypeLabel.TabIndex = 10;
            this.signalTypeLabel.Text = "Type";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(12, 85);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(76, 20);
            this.frequencyLabel.TabIndex = 11;
            this.frequencyLabel.Text = "Frequency";
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(12, 135);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(79, 20);
            this.amplitudeLabel.TabIndex = 12;
            this.amplitudeLabel.Text = "Amplitude";
            // 
            // initialPhaseLabel
            // 
            this.initialPhaseLabel.AutoSize = true;
            this.initialPhaseLabel.Location = new System.Drawing.Point(12, 181);
            this.initialPhaseLabel.Name = "initialPhaseLabel";
            this.initialPhaseLabel.Size = new System.Drawing.Size(89, 20);
            this.initialPhaseLabel.TabIndex = 13;
            this.initialPhaseLabel.Text = "Initial phase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Initial phase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amplitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // firstSignalPlotView
            // 
            this.firstSignalPlotView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstSignalPlotView.Location = new System.Drawing.Point(254, 35);
            this.firstSignalPlotView.Name = "firstSignalPlotView";
            this.firstSignalPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.firstSignalPlotView.Size = new System.Drawing.Size(768, 164);
            this.firstSignalPlotView.TabIndex = 18;
            this.firstSignalPlotView.Text = "plotView1";
            this.firstSignalPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.firstSignalPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.firstSignalPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // secondSignalPlotView
            // 
            this.secondSignalPlotView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondSignalPlotView.Location = new System.Drawing.Point(254, 205);
            this.secondSignalPlotView.Name = "secondSignalPlotView";
            this.secondSignalPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.secondSignalPlotView.Size = new System.Drawing.Size(768, 163);
            this.secondSignalPlotView.TabIndex = 19;
            this.secondSignalPlotView.Text = "plotView1";
            this.secondSignalPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.secondSignalPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.secondSignalPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // crossCorrelationRadioButton
            // 
            this.crossCorrelationRadioButton.AutoSize = true;
            this.crossCorrelationRadioButton.Location = new System.Drawing.Point(43, 432);
            this.crossCorrelationRadioButton.Name = "crossCorrelationRadioButton";
            this.crossCorrelationRadioButton.Size = new System.Drawing.Size(65, 24);
            this.crossCorrelationRadioButton.TabIndex = 20;
            this.crossCorrelationRadioButton.TabStop = true;
            this.crossCorrelationRadioButton.Text = "Cross";
            this.crossCorrelationRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoCorrelationRadioButton
            // 
            this.autoCorrelationRadioButton.AutoSize = true;
            this.autoCorrelationRadioButton.Location = new System.Drawing.Point(114, 432);
            this.autoCorrelationRadioButton.Name = "autoCorrelationRadioButton";
            this.autoCorrelationRadioButton.Size = new System.Drawing.Size(62, 24);
            this.autoCorrelationRadioButton.TabIndex = 21;
            this.autoCorrelationRadioButton.TabStop = true;
            this.autoCorrelationRadioButton.Text = "Auto";
            this.autoCorrelationRadioButton.UseVisualStyleBackColor = true;
            // 
            // correlateButton
            // 
            this.correlateButton.Location = new System.Drawing.Point(56, 473);
            this.correlateButton.Name = "correlateButton";
            this.correlateButton.Size = new System.Drawing.Size(94, 29);
            this.correlateButton.TabIndex = 22;
            this.correlateButton.Text = "Correlate";
            this.correlateButton.UseVisualStyleBackColor = true;
            this.correlateButton.Click += new System.EventHandler(this.correlateButton_Click);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotView1.Location = new System.Drawing.Point(254, 374);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(768, 163);
            this.plotView1.TabIndex = 23;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotView2.Location = new System.Drawing.Point(254, 544);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(768, 163);
            this.plotView2.TabIndex = 24;
            this.plotView2.Text = "plotView1";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 720);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.correlateButton);
            this.Controls.Add(this.autoCorrelationRadioButton);
            this.Controls.Add(this.crossCorrelationRadioButton);
            this.Controls.Add(this.secondSignalPlotView);
            this.Controls.Add(this.firstSignalPlotView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialPhaseLabel);
            this.Controls.Add(this.amplitudeLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.signalTypeLabel);
            this.Controls.Add(this.secondSignalInitialPhaseComboBox);
            this.Controls.Add(this.secondSignalTypeComboBox);
            this.Controls.Add(this.secondSignalAmplitudeTextBox);
            this.Controls.Add(this.secondSignalFrequencyTextBox);
            this.Controls.Add(this.secondSignalLabel);
            this.Controls.Add(this.firstSignalInitialPhaseComboBox);
            this.Controls.Add(this.firstSignalTypeComboBox);
            this.Controls.Add(this.firstSignalAmplitudeTextBox);
            this.Controls.Add(this.firstSignalFrequencyTextBox);
            this.Controls.Add(this.firstSignalLabel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstSignalLabel;
        private TextBox firstSignalFrequencyTextBox;
        private TextBox firstSignalAmplitudeTextBox;
        private ComboBox firstSignalTypeComboBox;
        private ComboBox firstSignalInitialPhaseComboBox;
        private ComboBox secondSignalInitialPhaseComboBox;
        private ComboBox secondSignalTypeComboBox;
        private TextBox secondSignalAmplitudeTextBox;
        private TextBox secondSignalFrequencyTextBox;
        private Label secondSignalLabel;
        private Label signalTypeLabel;
        private Label frequencyLabel;
        private Label amplitudeLabel;
        private Label initialPhaseLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private OxyPlot.WindowsForms.PlotView firstSignalPlotView;
        private OxyPlot.WindowsForms.PlotView secondSignalPlotView;
        private RadioButton crossCorrelationRadioButton;
        private RadioButton autoCorrelationRadioButton;
        private Button correlateButton;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
    }
}
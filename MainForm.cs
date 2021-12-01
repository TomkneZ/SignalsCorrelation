using OxyPlot.WindowsForms;
using System.Diagnostics;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private const string FirstSignalSeriesName = "first signal";
        private const string SecondSignalSeriesName = "second signal";

        private const string CorrelationSeriesName = "correlation";
        private const string FastCorrelationSeriesName = "fast correlation";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            firstSignalTypeComboBox.SelectedIndex = 0;
            firstSignalInitialPhaseComboBox.SelectedIndex = 0;

            secondSignalTypeComboBox.SelectedIndex = 0;
            secondSignalInitialPhaseComboBox.SelectedIndex = 0;
        }

        private void correlateButton_Click(object sender, EventArgs e)
        {
            double.TryParse(firstSignalFrequencyTextBox.Text, out var firstSignalFrequency);
            double.TryParse(firstSignalAmplitudeTextBox.Text, out var firstSignalAmplitude);
            var firstSignalInitialPhase = GetInitialPhaseValue(firstSignalInitialPhaseComboBox.SelectedIndex);

            double.TryParse(secondSignalFrequencyTextBox.Text, out var secondSignalFrequency);
            double.TryParse(secondSignalAmplitudeTextBox.Text, out var secondSignalAmplitude);
            var secondSignalInitialPhase = GetInitialPhaseValue(secondSignalInitialPhaseComboBox.SelectedIndex);

            var firstSignal = GetSignal(firstSignalTypeComboBox.SelectedIndex,
                firstSignalAmplitude, firstSignalFrequency, firstSignalInitialPhase);
            var secondSignal = GetSignal(secondSignalTypeComboBox.SelectedIndex,
                secondSignalAmplitude, secondSignalFrequency, secondSignalInitialPhase);            

            if (crossCorrelationRadioButton.Checked)
            {
                DrawSignalSeries(firstSignal, secondSignal,
                                 FirstSignalSeriesName, SecondSignalSeriesName,
                                 signalsPlotView);

                var correlationStart = DateTime.Now;
                var crossCorrelatedSignal = Correlation.CrossCorrelation(firstSignal, secondSignal);
                var time = DateTime.Now.Subtract(correlationStart).TotalMilliseconds;

                var fastCorrelationStart = DateTime.Now;
                var fastCrossCorrelatedSignal = Correlation.FastCrossCorrelation(firstSignal, secondSignal);
                var fastTime = (DateTime.Now - fastCorrelationStart).TotalMilliseconds;

                DisplayCorrelationTime(time.ToString(), fastTime.ToString());
                DrawSignalSeries(crossCorrelatedSignal, fastCrossCorrelatedSignal,
                                 CorrelationSeriesName, FastCorrelationSeriesName,
                                 correlationPlotView);
            }   
            
            if (autoCorrelationRadioButton.Checked)
            {
                DrawSignalSeries(firstSignal, null,
                                 FirstSignalSeriesName, null,
                                 signalsPlotView);
                var correlationStart = DateTime.Now;
                var autoCorrelatedSignal = Correlation.AutoCorrelation(firstSignal, 100);
                var time = DateTime.Now.Subtract(correlationStart).TotalMilliseconds;

                var fastCorrelationStart = DateTime.Now;
                var fastAutoCorrelatedSignal = Correlation.FastAutoCorrelation(firstSignal, 100);
                var fastTime = (DateTime.Now - fastCorrelationStart).TotalMilliseconds;

                DisplayCorrelationTime(time.ToString(), fastTime.ToString());
                DrawSignalSeries(autoCorrelatedSignal, fastAutoCorrelatedSignal,
                                 CorrelationSeriesName, FastCorrelationSeriesName,
                                 correlationPlotView);
            }
        }

        private double GetInitialPhaseValue(int selectedIndex) => 
            selectedIndex switch
        {
            1 => Math.PI / 2,
            2 => Math.PI,
            3 => 3 * Math.PI / 4,
            _ => 0.0
        };

        private double[] GetSignal(int selectedIndex, double amplitude, double frequency, double initialPhase) =>
            selectedIndex switch
        {
            1 => SignalGenerator.GenerateSawtooth(amplitude, frequency, initialPhase),
            2 => SignalGenerator.GenerateTriangular(amplitude, frequency, initialPhase),
            _ => SignalGenerator.GenerateSin(amplitude, frequency, initialPhase)
        };

        private void DrawSignalSeries(double[] firstSignal, double[] secondSignal, 
            string firstSeriesName, string secondSeriesName, PlotView signalsPlotView) 
        {
            var signalsPlotModel = PlotDrawer.GetPlotModel();
            var firstSignalSeries = PlotDrawer.GetSeriesFromPoints(firstSignal, firstSeriesName);
            signalsPlotModel.Series.Add(firstSignalSeries);

            if (secondSignal != null)
            {                
                var secondSignalSeries = PlotDrawer.GetSeriesFromPoints(secondSignal, secondSeriesName);
                signalsPlotModel.Series.Add(secondSignalSeries);                
            }
            
            signalsPlotView.Model = signalsPlotModel;
        }

        private void DisplayCorrelationTime(string time, string fastTime)
        {
            correlationTimeResultLabel.Text = time;
            fastCorrelationResultLabel.Text = fastTime;
        }
    }
}
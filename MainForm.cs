namespace Lab4
{
    public partial class MainForm : Form
    {
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

            firstSignalPlotView.Model = PlotDrawer.GetPlotModel(firstSignal);
            secondSignalPlotView.Model = PlotDrawer.GetPlotModel(secondSignal);
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
    }
}
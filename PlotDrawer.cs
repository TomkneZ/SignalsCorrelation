using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Lab4
{
    internal static class PlotDrawer
    {
        internal static PlotModel GetPlotModel(double[] points)
        {
            var model = new PlotModel() { DefaultColors = new List<OxyColor> { OxyColor.FromRgb(00, 0xFF, 00) } };

            model.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                IsAxisVisible = false
            });

            var series = new LineSeries
            {
                StrokeThickness = 1,
                MarkerSize = 1,
            };

            for (var i = 0; i < points.Length; i++)
            {
                var x_val = (float)i / (float)points.Length;
                var y_val = points[i];
                series.Points.Add(new DataPoint(x_val, y_val));
            }

            model.Series.Add(series);

            return model;
        }
    }
}

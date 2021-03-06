using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace Lab4
{
    internal static class PlotDrawer
    {
        internal static LineSeries GetSeriesFromPoints(double[] points, string seriesName)
        {
            var series = new LineSeries
            {
                StrokeThickness = 1,
                MarkerSize = 1,
                Title = seriesName
            };

            for (var i = 0; i < points.Length; i++)
            {
                var xVal = (float)i / (float)points.Length;
                var yVal = points[i];
                series.Points.Add(new DataPoint(xVal, yVal));
            }

            return series;
        }

        internal static PlotModel GetPlotModel()
        {
            var model = new PlotModel() {
                DefaultColors = new List<OxyColor> { OxyColor.FromRgb(00, 255, 00), OxyColor.FromRgb(255, 33, 44) },
                IsLegendVisible = true
            };

            var l = new Legend()
            {
                LegendPlacement = LegendPlacement.Inside,
                LegendPosition = LegendPosition.TopRight,
                LegendBackground = OxyColor.FromArgb(190, 255, 255, 255)
            };

            model.Legends.Add(l);

            model.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                IsAxisVisible = false
            });

            return model;
        }
    }
}

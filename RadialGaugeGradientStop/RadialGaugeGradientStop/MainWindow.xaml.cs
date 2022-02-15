using Microsoft.UI.Xaml;
using Syncfusion.UI.Xaml.Gauges;
using System.Collections.ObjectModel;
using Windows.UI;

namespace RadialGaugeGradientStop
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //SfRadialGauge radialGauge = new();
            //RadialAxis radialAxis = new();
            //radialGauge.Axes.Add(radialAxis);

            //// Creating gauge range.
            //GaugeRange gaugeRange = new()
            //{
            //    StartValue = 0,
            //    EndValue = 100
            //};

            //// Creating gradient stops for range.
            //var gradientStops = new ObservableCollection<GaugeGradientStop>
            //{
            //    new GaugeGradientStop { Value = 0, Color = Color.FromArgb(255, 255, 255, 0) },
            //    new GaugeGradientStop { Value = 50, Color = Color.FromArgb(255, 255, 0, 0) },
            //    new GaugeGradientStop { Value = 100, Color = Color.FromArgb(255, 0, 0, 255) }
            //};

            //// Assign gradient stops to range.
            //gaugeRange.GradientStops = gradientStops;
            //radialAxis.Ranges.Add(gaugeRange);
            //this.Content = radialGauge;
        }
    }
}

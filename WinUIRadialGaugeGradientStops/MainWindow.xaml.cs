using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;
using Syncfusion.UI.Xaml.Gauges;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIRadialGaugeGradientStops
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
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
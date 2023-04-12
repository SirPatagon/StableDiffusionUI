using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace StableDiffusionUI.Controls
{
    public partial class RangeSlider : UserControl
    {
        public static readonly StyledProperty<double> MaximumProperty =
            AvaloniaProperty.Register<RangeSlider, double>(nameof(Maximum));

        public double Maximum
        {
            get { return GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly StyledProperty<double> MinimumProperty =
            AvaloniaProperty.Register<RangeSlider, double>(nameof(Minimum));

        public double Minimum
        {
            get { return GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly StyledProperty<double> TickFrequencyProperty =
            AvaloniaProperty.Register<RangeSlider, double>(nameof(TickFrequency));

        public double TickFrequency
        {
            get { return GetValue(TickFrequencyProperty); }
            set { SetValue(TickFrequencyProperty, value); }
        }

        public static readonly StyledProperty<string> TitleProperty =
            AvaloniaProperty.Register<RangeSlider, string>(nameof(Title));

        public string Title
        {
            get { return GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly StyledProperty<double> ValueProperty =
            AvaloniaProperty.Register<RangeSlider, double>(nameof(Value));

        public double Value
        {
            get { return GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public RangeSlider()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Markup;
using System.Windows.Interop;
using System.Windows.Automation;

namespace WPF
{
    // Basic WPF Window Example
    public class BasicWindowExample : Window
    {
        public BasicWindowExample()
        {
            Title = "Basic WPF Window";
            Width = 300;
            Height = 200;
        }
    }

    // WPF Controls Example
    public class ControlsExample
    {
        public void CreateControls()
        {
            Button button = new Button { Content = "Click Me" };
            TextBox textBox = new TextBox { Text = "Enter text" };
            ComboBox comboBox = new ComboBox();
        }
    }

    // WPF Data Binding Example
    public class DataBindingExample
    {
        public void BindData()
        {
            Binding binding = new Binding("PropertyName");
            binding.Mode = BindingMode.TwoWay;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
        }
    }

    // WPF Documents Example
    public class DocumentsExample
    {
        public FlowDocument CreateDocument()
        {
            FlowDocument doc = new FlowDocument();
            Paragraph para = new Paragraph(new Run("Sample Text"));
            doc.Blocks.Add(para);
            return doc;
        }
    }

    // WPF Input Example
    public class InputExample
    {
        public void HandleInput()
        {
            CommandBinding binding = new CommandBinding(
                ApplicationCommands.Copy,
                ExecuteCopy,
                CanExecuteCopy);
        }

        private void ExecuteCopy(object sender, ExecutedRoutedEventArgs e) { }
        private void CanExecuteCopy(object sender, CanExecuteRoutedEventArgs e) { }
    }

    // WPF Media Example
    public class MediaExample
    {
        public void CreateMedia()
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            LinearGradientBrush gradient = new LinearGradientBrush();
        }
    }

    // WPF Imaging Example
    public class ImagingExample
    {
        public BitmapImage LoadImage()
        {
            return new BitmapImage(new Uri("image.png", UriKind.Relative));
        }
    }

    // WPF Animation Example
    public class AnimationExample
    {
        public void CreateAnimation()
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0,
                To = 100,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };
        }
    }

    // WPF Navigation Example
    public class NavigationExample : NavigationWindow
    {
        public void Navigate()
        {
            NavigationService.Navigate(new Uri("Page.xaml", UriKind.Relative));
        }
    }

    // WPF Shapes Example
    public class ShapesExample
    {
        public void DrawShapes()
        {
            Rectangle rect = new Rectangle
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Blue
            };
        }
    }

    // WPF Threading Example
    public class ThreadingExample
    {
        public void UpdateUI()
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                new Action(() => { /* UI update code */ }));
        }
    }

    // WPF XAML Example
    public class MarkupExample
    {
        public void LoadXaml()
        {
            ParserContext context = new ParserContext();
            FrameworkElement element = XamlReader.Parse("<Button>Click</Button>") as FrameworkElement;
        }
    }

    // WPF Interop Example
    public class InteropExample
    {
        public void HandleInterop()
        {
            HwndSource hwndSource = new HwndSource(new HwndSourceParameters());
            IntPtr handle = hwndSource.Handle;
        }
    }

    // WPF Automation Example
    public class AutomationExample
    {
        public void SetAutomation()
        {
            AutomationProperties.SetAutomationId(new Button(), "MyButton");
            AutomationProperties.SetName(new TextBox(), "MyTextBox");
        }
    }

    // WPF Visual State Example
    public class VisualStateExample
    {
        public void ManageStates()
        {
            VisualStateManager.GoToState(new Control(), "NormalState", true);
        }
    }
}
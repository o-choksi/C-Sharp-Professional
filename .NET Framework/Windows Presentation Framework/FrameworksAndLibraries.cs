using System;

namespace WPF
{
    // WPF Controls
    using System.Windows.Controls;
    public class MainWindow : Window {
        public MainWindow() {
            Button button = new Button() {
                Content = "Click Me",
                Width = 100,
                Height = 30
            };
        }
    }

    // WPF Layout
    using System.Windows.Controls;
    public class LayoutExample {
        public Grid CreateLayout() {
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            return grid;
        }
    }

    // WPF Data Binding
    using System.ComponentModel;
    public class ViewModel : INotifyPropertyChanged {
        private string _name;
        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    // WPF Commands
    using System.Windows.Input;
    public class RelayCommand : ICommand {
        private Action _execute;
        public RelayCommand(Action execute) {
            _execute = execute;
        }
        public bool CanExecute(object parameter) { return true; }
        public void Execute(object parameter) { _execute(); }
        public event EventHandler CanExecuteChanged;
    }

    // WPF Styles and Templates
    using System.Windows;
    public class StyleExample {
        public Style CreateButtonStyle() {
            Style style = new Style(typeof(Button));
            style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
            return style;
        }
    }

    // WPF Animation
    using System.Windows.Media.Animation;
    public class AnimationExample {
        public void CreateAnimation() {
            DoubleAnimation animation = new DoubleAnimation {
                From = 0,
                To = 100,
                Duration = TimeSpan.FromSeconds(2)
            };
        }
    }

    // WPF Resources
    using System.Windows;
    public class ResourceExample : Window {
        public ResourceExample() {
            Resources.Add("ButtonBackground", Brushes.Red);
            Button button = new Button();
            button.SetResourceReference(Button.BackgroundProperty, "ButtonBackground");
        }
    }

    // WPF Triggers
    using System.Windows;
    public class TriggerExample {
        public Trigger CreateTrigger() {
            return new Trigger {
                Property = UIElement.IsMouseOverProperty,
                Value = true,
                Setters = { new Setter(Button.BackgroundProperty, Brushes.Red) }
            };
        }
    }

    // WPF Dependency Properties
    using System.Windows;
    public class CustomControl : Control {
        public static readonly DependencyProperty CustomProperty = 
            DependencyProperty.Register("Custom", typeof(string), typeof(CustomControl));
            
        public string Custom {
            get { return (string)GetValue(CustomProperty); }
            set { SetValue(CustomProperty, value); }
        }
    }

    // WPF Attached Properties
    using System.Windows;
    public class GridHelpers {
        public static readonly DependencyProperty RowCountProperty =
            DependencyProperty.RegisterAttached("RowCount", typeof(int), typeof(GridHelpers));

        public static void SetRowCount(Grid grid, int value) {
            grid.SetValue(RowCountProperty, value);
        }
    }

    // WPF Events and Routed Events
    using System.Windows;
    public class EventExample {
        public static readonly RoutedEvent CustomEvent = 
            EventManager.RegisterRoutedEvent("Custom", RoutingStrategy.Bubble, 
                typeof(RoutedEventHandler), typeof(EventExample));
    }

    // WPF Visual States
    using System.Windows;
    public class VisualStateExample : Control {
        static VisualStateExample() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VisualStateExample),
                new FrameworkPropertyMetadata(typeof(VisualStateExample)));
        }
    }

    // WPF Behaviors
    using Microsoft.Xaml.Behaviors;
    public class CustomBehavior : Behavior<UIElement> {
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.MouseEnter += OnMouseEnter;
        }
    }

    // WPF Threading
    using System.Windows.Threading;
    public class ThreadingExample {
        public void UpdateUI() {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                new Action(() => {
                    // UI update code
                }));
        }
    }

    // WPF Navigation
    using System.Windows.Navigation;
    public class NavigationExample : NavigationWindow {
        public NavigationExample() {
            Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
    }
}
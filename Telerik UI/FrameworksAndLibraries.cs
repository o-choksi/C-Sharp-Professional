using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Data;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls.Chart;
using Telerik.Windows.Controls.Scheduling;
using Telerik.Windows.Controls.Navigation;
using Telerik.Windows.Controls.Input;
using Telerik.Windows.Controls.Docking;
using Telerik.Windows.Controls.RichTextBox;
using Telerik.Windows.Controls.Spreadsheet;
using Telerik.Windows.Controls.GanttView;
using Telerik.Windows.Controls.Map;
using Telerik.Windows.Controls.DataVisualization;
using Telerik.Windows.Documents.Core;
using Telerik.Windows.Documents.Flow;

namespace Telerik
{
    // Telerik.Windows.Controls Example
    public class ControlsExample 
    {
        private RadButton button;

        public void InitializeButton()
        {
            button = new RadButton();
            button.Content = "Click Me";
        }
    }

    // Telerik.Windows.Controls.Data Example
    public class DataExample
    {
        private RadDataForm dataForm;

        public void ConfigureDataForm()
        {
            dataForm = new RadDataForm();
            dataForm.AutoGenerateFields = true;
        }
    }

    // Telerik.Windows.Controls.GridView Example
    public class GridViewExample
    {
        private RadGridView grid;

        public void SetupGrid()
        {
            grid = new RadGridView();
            grid.AutoGenerateColumns = true;
        }
    }

    // Telerik.Windows.Controls.Chart Example
    public class ChartExample
    {
        private RadChartView chart;

        public void CreateChart()
        {
            chart = new RadChartView();
            chart.Series.Add(new LineSeries());
        }
    }

    // Telerik.Windows.Controls.Scheduling Example
    public class SchedulingExample
    {
        private RadScheduleView scheduler;

        public void InitializeScheduler()
        {
            scheduler = new RadScheduleView();
            scheduler.FirstDayOfWeek = DayOfWeek.Monday;
        }
    }

    // Telerik.Windows.Controls.Navigation Example
    public class NavigationExample
    {
        private RadTabControl tabControl;

        public void ConfigureNavigation()
        {
            tabControl = new RadTabControl();
            tabControl.Items.Add(new RadTabItem() { Header = "Tab 1" });
        }
    }

    // Telerik.Windows.Controls.Input Example
    public class InputExample
    {
        private RadDatePicker datePicker;

        public void SetupDatePicker()
        {
            datePicker = new RadDatePicker();
            datePicker.SelectedDate = DateTime.Today;
        }
    }

    // Telerik.Windows.Controls.Docking Example
    public class DockingExample
    {
        private RadDocking docking;

        public void ConfigureDocking()
        {
            docking = new RadDocking();
            docking.DocumentHost.AddDocument(new RadDocument());
        }
    }

    // Telerik.Windows.Controls.RichTextBox Example
    public class RichTextBoxExample
    {
        private RadRichTextBox richTextBox;

        public void InitializeEditor()
        {
            richTextBox = new RadRichTextBox();
            richTextBox.Document.DefaultStyleSettings.FontFamily = new System.Windows.Media.FontFamily("Arial");
        }
    }

    // Telerik.Windows.Controls.Spreadsheet Example
    public class SpreadsheetExample
    {
        private RadSpreadsheet spreadsheet;

        public void SetupSpreadsheet()
        {
            spreadsheet = new RadSpreadsheet();
            spreadsheet.CreateNewWorkbook();
        }
    }

    // Telerik.Windows.Controls.GanttView Example
    public class GanttViewExample
    {
        private RadGanttView ganttView;

        public void ConfigureGantt()
        {
            ganttView = new RadGanttView();
            ganttView.VisibleRange = new TimeSpan(30, 0, 0, 0);
        }
    }

    // Telerik.Windows.Controls.Map Example
    public class MapExample
    {
        private RadMap map;

        public void InitializeMap()
        {
            map = new RadMap();
            map.Center = new Location(42.6977, 23.3219); // Sofia coordinates
        }
    }

    // Telerik.Windows.Controls.DataVisualization Example
    public class DataVisualizationExample
    {
        private RadBulletGraph bulletGraph;

        public void CreateBulletGraph()
        {
            bulletGraph = new RadBulletGraph();
            bulletGraph.Value = 75;
        }
    }

    // Telerik.Windows.Documents.Core Example
    public class DocumentsCoreExample
    {
        private DocumentFormat format;

        public void SetDocumentFormat()
        {
            format = DocumentFormat.Rtf;
        }
    }

    // Telerik.Windows.Documents.Flow Example
    public class DocumentsFlowExample
    {
        private RadFlowDocument flowDocument;

        public void CreateDocument()
        {
            flowDocument = new RadFlowDocument();
            flowDocument.AddParagraph().AddRun("Hello World");
        }
    }
}

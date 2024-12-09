using System;

namespace Telerik
{
    // Grid Component
    using Telerik.Web.UI;
    public class GridExample {
        private readonly RadGrid _grid = new RadGrid();
        public void ConfigureGrid() {
            _grid.AllowPaging = true;
            _grid.PageSize = 10;
            _grid.AllowSorting = true;
            _grid.DataSource = GetDataSource();
            _grid.DataBind();
        }
    }

    // Chart Visualization
    using Telerik.Charting;
    public class ChartExample {
        private readonly RadChart _chart;
        public void CreateChart() {
            _chart = new RadChart();
            _chart.ChartTitle.Text = "Sales Report";
            _chart.AddSeries(new ChartSeries("Monthly Sales"));
            _chart.DataBind();
        }
    }

    // Scheduler Component
    using Telerik.Web.UI.Calendar;
    public class SchedulerExample {
        private readonly RadScheduler _scheduler;
        public void ConfigureScheduler() {
            _scheduler = new RadScheduler();
            _scheduler.SelectedView = SchedulerViewType.WeekView;
            _scheduler.DayStartTime = "08:00";
            _scheduler.DayEndTime = "18:00";
        }
    }

    // Editor Control
    using Telerik.Web.UI.Editor;
    public class EditorExample {
        private readonly RadEditor _editor;
        public void SetupEditor() {
            _editor = new RadEditor();
            _editor.Content = "Initial content";
            _editor.ToolsFile = "~/EditorTools.xml";
            _editor.EnableResize = true;
        }
    }

    // Upload Component
    using Telerik.Web.UI.Upload;
    public class UploadExample {
        private readonly RadUpload _upload;
        public void ConfigureUpload() {
            _upload = new RadUpload();
            _upload.AllowedFileExtensions = ".pdf,.doc,.docx";
            _upload.MaxFileSize = 10485760; // 10MB
            _upload.MultipleFileSelection = true;
        }
    }

    // Menu Navigation
    using Telerik.Web.UI.Navigation;
    public class MenuExample {
        private readonly RadMenu _menu;
        public void CreateMenu() {
            _menu = new RadMenu();
            _menu.EnableRoundedCorners = true;
            _menu.EnableScreenBoundaryDetection = true;
            _menu.LoadXmlFile("~/Menu.xml");
        }
    }

    // Window Management
    using Telerik.Web.UI.Windows;
    public class WindowExample {
        private readonly RadWindow _window;
        public void ShowWindow() {
            _window = new RadWindow();
            _window.Title = "Dialog Window";
            _window.Width = 500;
            _window.Height = 300;
            _window.Modal = true;
        }
    }

    // PDF Processing
    using Telerik.Windows.Documents.Fixed;
    public class PdfExample {
        private readonly RadFixedDocument _document;
        public void CreatePdf() {
            _document = new RadFixedDocument();
            RadFixedPage page = _document.Pages.AddPage();
            page.Size = new Size(792, 612); // Letter size
            _document.Save("output.pdf");
        }
    }

    // Spreadsheet Processing
    using Telerik.Windows.Documents.Spreadsheet;
    public class SpreadsheetExample {
        private readonly Workbook _workbook;
        public void ManageSpreadsheet() {
            _workbook = new Workbook();
            Worksheet sheet = _workbook.Worksheets.Add();
            sheet.Cells[0, 0].SetValue("Hello World");
            _workbook.Save("output.xlsx");
        }
    }

    // Report Processing
    using Telerik.Reporting;
    public class ReportExample {
        private readonly Report _report;
        public void GenerateReport() {
            _report = new Report();
            ReportParameter param = new ReportParameter();
            param.Name = "DateRange";
            _report.ReportParameters.Add(param);
            _report.Export(new PdfReportProcessor());
        }
    }

    // Data Access
    using Telerik.Data.Core;
    public class DataAccessExample {
        private readonly DataSourceBuilder _builder;
        public void ConfigureDataAccess() {
            _builder = new DataSourceBuilder();
            _builder.AddSort("Name", ListSortDirection.Ascending);
            _builder.AddFilter("Age", FilterOperator.IsGreaterThan, 18);
        }
    }

    // Image Processing
    using Telerik.Windows.Media.Imaging;
    public class ImageExample {
        private readonly RadBitmapImage _image;
        public void ProcessImage() {
            _image = new RadBitmapImage();
            _image.Load("input.jpg");
            _image.Resize(800, 600);
            _image.Save("output.jpg");
        }
    }

    // Map Visualization
    using Telerik.Web.UI.Map;
    public class MapExample {
        private readonly RadMap _map;
        public void ConfigureMap() {
            _map = new RadMap();
            _map.Zoom = 4;
            _map.Center = new MapPoint(40.7128, -74.0060);
            _map.EnableMouseWheelZoom = true;
        }
    }

    // Gauge Control
    using Telerik.Web.UI.Gauges;
    public class GaugeExample {
        private readonly RadRadialGauge _gauge;
        public void SetupGauge() {
            _gauge = new RadRadialGauge();
            _gauge.MinValue = 0;
            _gauge.MaxValue = 100;
            _gauge.Value = 75;
            _gauge.ShowLabels = true;
        }
    }

    // Barcode Generation
    using Telerik.Web.UI.Barcode;
    public class BarcodeExample {
        private readonly RadBarcode _barcode;
        public void GenerateBarcode() {
            _barcode = new RadBarcode();
            _barcode.Type = BarcodeType.QRCode;
            _barcode.Text = "https://www.telerik.com";
            _barcode.Width = 200;
        }
    }
}
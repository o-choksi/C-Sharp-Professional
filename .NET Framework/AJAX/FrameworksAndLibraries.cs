using System;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace AJAXControls
{
    // UpdatePanel Control
    public class UpdatePanelExample
    {
        protected UpdatePanel updatePanel1;
        protected Timer timer1;

        private void InitializeControls()
        {
            updatePanel1 = new UpdatePanel
            {
                UpdateMode = UpdatePanelUpdateMode.Conditional
            };
            timer1 = new Timer { Interval = 5000 };
        }
    }

    // ScriptManager Control
    public class ScriptManagerExample 
    {
        protected ScriptManager scriptManager1;

        private void InitializeControls()
        {
            scriptManager1 = new ScriptManager
            {
                EnablePartialRendering = true,
                AsyncPostBackTimeout = 90
            };
        }
    }

    // Timer Control
    public class TimerExample
    {
        protected Timer timer1;

        private void InitializeControls()
        {
            timer1 = new Timer
            {
                Interval = 1000,
                Enabled = true
            };
        }
    }

    // AsyncPostBackTrigger
    public class AsyncTriggerExample
    {
        protected UpdatePanel updatePanel1;
        protected Button button1;

        private void SetupTriggers()
        {
            AsyncPostBackTrigger trigger = new AsyncPostBackTrigger
            {
                ControlID = "button1",
                EventName = "Click"
            };
            updatePanel1.Triggers.Add(trigger);
        }
    }

    // PostBackTrigger
    public class PostBackTriggerExample
    {
        protected UpdatePanel updatePanel1;
        protected FileUpload fileUpload1;

        private void SetupTriggers()
        {
            PostBackTrigger trigger = new PostBackTrigger
            {
                ControlID = "fileUpload1"
            };
            updatePanel1.Triggers.Add(trigger);
        }
    }

    // UpdateProgress Control
    public class UpdateProgressExample
    {
        protected UpdateProgress updateProgress1;

        private void InitializeControls()
        {
            updateProgress1 = new UpdateProgress
            {
                DisplayAfter = 500,
                DynamicLayout = true
            };
        }
    }

    // Ajax Control Toolkit TabContainer
    public class TabContainerExample
    {
        protected AjaxControlToolkit.TabContainer tabContainer1;

        private void InitializeControls()
        {
            tabContainer1 = new AjaxControlToolkit.TabContainer
            {
                ActiveTabIndex = 0,
                AutoPostBack = true
            };
        }
    }

    // Ajax Control Toolkit Accordion
    public class AccordionExample
    {
        protected AjaxControlToolkit.Accordion accordion1;

        private void InitializeControls()
        {
            accordion1 = new AjaxControlToolkit.Accordion
            {
                HeaderSelectedCssClass = "accordionHeaderSelected",
                ContentCssClass = "accordionContent"
            };
        }
    }

    // Ajax Control Toolkit Modal Popup
    public class ModalPopupExample
    {
        protected AjaxControlToolkit.ModalPopupExtender modalPopup1;

        private void InitializeControls()
        {
            modalPopup1 = new AjaxControlToolkit.ModalPopupExtender
            {
                TargetControlID = "btnShow",
                PopupControlID = "pnlPopup",
                BackgroundCssClass = "modalBackground"
            };
        }
    }

    // Ajax Control Toolkit Calendar
    public class CalendarExample
    {
        protected AjaxControlToolkit.CalendarExtender calendar1;

        private void InitializeControls()
        {
            calendar1 = new AjaxControlToolkit.CalendarExtender
            {
                TargetControlID = "txtDate",
                Format = "MM/dd/yyyy"
            };
        }
    }

    // Ajax Control Toolkit AutoComplete
    public class AutoCompleteExample
    {
        protected AjaxControlToolkit.AutoCompleteExtender autoComplete1;

        private void InitializeControls()
        {
            autoComplete1 = new AjaxControlToolkit.AutoCompleteExtender
            {
                TargetControlID = "txtSearch",
                ServiceMethod = "GetCompletionList",
                MinimumPrefixLength = 1
            };
        }
    }

    // Ajax Control Toolkit Rating
    public class RatingExample
    {
        protected AjaxControlToolkit.Rating rating1;

        private void InitializeControls()
        {
            rating1 = new AjaxControlToolkit.Rating
            {
                CurrentRating = 3,
                MaxRating = 5,
                StarCssClass = "ratingStar"
            };
        }
    }

    // Ajax Control Toolkit Slider
    public class SliderExample
    {
        protected AjaxControlToolkit.SliderExtender slider1;

        private void InitializeControls()
        {
            slider1 = new AjaxControlToolkit.SliderExtender
            {
                Minimum = 0,
                Maximum = 100,
                Steps = 5
            };
        }
    }

    // Ajax Control Toolkit ColorPicker
    public class ColorPickerExample
    {
        protected AjaxControlToolkit.ColorPickerExtender colorPicker1;

        private void InitializeControls()
        {
            colorPicker1 = new AjaxControlToolkit.ColorPickerExtender
            {
                TargetControlID = "txtColor",
                PopupButtonID = "btnColor"
            };
        }
    }

    // Ajax Control Toolkit MaskedEdit
    public class MaskedEditExample
    {
        protected AjaxControlToolkit.MaskedEditExtender maskedEdit1;

        private void InitializeControls()
        {
            maskedEdit1 = new AjaxControlToolkit.MaskedEditExtender
            {
                TargetControlID = "txtPhone",
                Mask = "(999) 999-9999"
            };
        }
    }

    // Ajax Control Toolkit PasswordStrength
    public class PasswordStrengthExample
    {
        protected AjaxControlToolkit.PasswordStrength passwordStrength1;

        private void InitializeControls()
        {
            passwordStrength1 = new AjaxControlToolkit.PasswordStrength
            {
                TargetControlID = "txtPassword",
                DisplayPosition = AjaxControlToolkit.DisplayPosition.RightSide
            };
        }
    }

    // Ajax Control Toolkit HtmlEditor
    public class HtmlEditorExample
    {
        protected AjaxControlToolkit.HtmlEditorExtender htmlEditor1;

        private void InitializeControls()
        {
            htmlEditor1 = new AjaxControlToolkit.HtmlEditorExtender
            {
                TargetControlID = "txtContent",
                DisplaySourceTab = true
            };
        }
    }

    // Ajax Control Toolkit DragPanel
    public class DragPanelExample
    {
        protected AjaxControlToolkit.DragPanelExtender dragPanel1;

        private void InitializeControls()
        {
            dragPanel1 = new AjaxControlToolkit.DragPanelExtender
            {
                TargetControlID = "pnlDrag",
                DragHandleID = "pnlDragHandle"
            };
        }
    }

    // Ajax Control Toolkit ReorderList
    public class ReorderListExample
    {
        protected AjaxControlToolkit.ReorderList reorderList1;

        private void InitializeControls()
        {
            reorderList1 = new AjaxControlToolkit.ReorderList
            {
                AllowReorder = true,
                PostBackOnReorder = true
            };
        }
    }

    // Ajax Control Toolkit ValidatorCallout
    public class ValidatorCalloutExample
    {
        protected AjaxControlToolkit.ValidatorCalloutExtender validatorCallout1;

        private void InitializeControls()
        {
            validatorCallout1 = new AjaxControlToolkit.ValidatorCalloutExtender
            {
                TargetControlID = "rfvName",
                HighlightCssClass = "validatorCalloutHighlight"
            };
        }
    }
}
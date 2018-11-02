using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    static class Invoker
    {
        private static dynamic InvokedControl(dynamic control, System.Delegate method, params object[] args)
        {
            dynamic cntrl = control;

            if (control.InvokeRequired)
            {
                control.Invoke(method, args);
            }

            return control;
        }
        public enum Mode
        {
            SetMaximum = 0,
            SetValue = 1
        }

        //NumericUpDown
        private delegate void _SetNumericValue(NumericUpDown ctrl, decimal val);

        //Control
        private delegate void _SetText(Control control, string msg, string clr);
        private delegate void _SetHeight(Control control, int height);

        private delegate void _ChangeVisibilityForm(Control control, bool state);
        private delegate void _ChangeVisible(Control control, bool state);
        private delegate void _ChangeEnable(Control control, bool state);

        //Progressbar
        private delegate void _SetPrgbValue(ProgressBar prgb, int value, Mode mode);

        //ListView
        private delegate void _AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "");
        private delegate void _AddListItemRaw(ListView list, ListViewItem itm);
        private delegate void _ClearListView(ListView list);
        private delegate void _UpdateListView(ListView list, bool start = true);


        public static void ChangeVisibilityForm(Control control, bool state)
        {
            try
            {
                InvokedControl(control, new _ChangeVisibilityForm(ChangeVisibilityForm), control, state).Visible = state;
            }
            catch { }
        }
        public static void SetNumericValue(NumericUpDown control, decimal val)
        {
            try
            {
                InvokedControl(control, new _SetNumericValue(SetNumericValue), control, val).Value = val;
            }
            catch { }
        }
        public static void ChangeVisible(Control control, bool state)
        {
            try
            {
                InvokedControl(control, new _ChangeVisible(ChangeVisible), control, state).Visible = state;
            }
            catch { }
        }

        public static void SetHeight(Control control, int height)
        {
            try
            {
                InvokedControl(control, new _SetHeight(SetHeight), control, height).Height = height;
            }
            catch { }
        }

        public static void ChangeEnable(Control control, bool state)
        {
            try
            {
                InvokedControl(control, new _ChangeEnable(ChangeEnable), control, state).Enabled = state;
            }
            catch { }
        }
        public static void SetText(Control control, string msg, string clr = null)
        {
            try
            {
                Control cntrl = InvokedControl(control, new _SetText(SetText), control, msg, clr);
                cntrl.Text = msg;

                if (clr != null)
                {
                    cntrl.ForeColor = ColorTranslator.FromHtml(clr);
                }
            }
            catch { }
        }

        public static void UpdateList(ListView list, bool start = true)
        {
            try
            {
                dynamic cntrl = InvokedControl(list, new _UpdateListView(UpdateList), list, start);

                if (start)
                {
                    cntrl.BeginUpdate();
                }
                else
                {
                    cntrl.EndUpdate();
                }
            }
            catch { }
        }
        public static void ClearList(ListView list)
        {
            try
            {
                dynamic cntrl = InvokedControl(list, new _ClearListView(ClearList), list);
                cntrl.Items.Clear();
            }
            catch { }
        }
        public static void AddListItem(ListView list, ListViewItem itm)
        {
            try
            {
                dynamic cntrl = InvokedControl(list, new _AddListItemRaw(AddListItem), list, itm);
                cntrl.Items.Add(itm);
            }
            catch { }
        }
        public static void AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "")
        {
            try
            {
                dynamic cntrl = InvokedControl(list, new _AddListItem(AddListItem), list, value, subItem, subValue, tag);

                ListViewItem itm = new ListViewItem();
                itm.Tag = tag;
                itm.Text = value;
                if (subItem)
                {
                    itm.SubItems.Add(subValue);
                }
                cntrl.Items.Add(itm);
            }
            catch { }
        }

        public static void SetPrgbState(ProgressBar prgb, int value, Mode mode)
        {
            try
            {
                dynamic cntrl = InvokedControl(prgb, new _SetPrgbValue(SetPrgbState), prgb, value, mode);

                if (mode == Mode.SetMaximum)
                {
                    cntrl.Maximum = value;
                }
                else if (mode == Mode.SetValue)
                {
                    cntrl.Value = value;
                }
            }
            catch { }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public enum FormType
    {
        Login,
        Control
    }
    public class ViewForm : Form
    {
        public virtual FormType FormType { get; }
        public virtual void OnHide() { Hide(); }
        public virtual void OnShow() { Show(); }

    }
    internal static class Program
    {
        static Dictionary<FormType, ViewForm> FormFromType;
        static ViewForm currentForm;
        public static void SwitchFormType(FormType formType, bool isFirstTime = false, Action callback = null)
        {
            if (!isFirstTime)
            {
                if (currentForm.FormType == formType)
                {
                    callback?.Invoke();
                    return;
                }
                FormFromType[currentForm.FormType].OnHide();
            }
            currentForm = FormFromType[formType];
            if (isFirstTime)
            {
                Application.Run(currentForm);
                return;
            }
            currentForm.OnShow();

            callback?.Invoke();
        }

        internal static void CleanForm(FormType control)
        {
            foreach (var item in FormFromType)
            {
                if (item.Key != control)
                    item.Value.Close();
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormFromType = new Dictionary<FormType, ViewForm>
            {
                {FormType.Login, new LoginForm() },
                {FormType.Control, new ControlForm() },
            };

            SwitchFormType(FormType.Login, true);

        }
    }
}

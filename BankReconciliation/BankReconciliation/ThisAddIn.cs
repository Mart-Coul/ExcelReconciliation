using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Extensions;
using Microsoft.Office.Core;

namespace BankReconciliation
{
    public partial class ThisAddIn
    {
        Microsoft.Office.Tools.CustomTaskPane BankReconciliationPane;
        BankReconciliationUserControl BankReconciliationUC;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {
                BankReconciliationUC = new BankReconciliationUserControl();
                BankReconciliationPane = this.CustomTaskPanes.Add(BankReconciliationUC, "Bank Reconciliaon");
                BankReconciliationPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
                BankReconciliationPane.Width = 360;// Increased width so as to get rid of horizontal scroll bar
                BankReconciliationPane.VisibleChanged += new EventHandler(BankReconciliationTaskPane_VisibleChanged);
            }
            catch (System.Exception ex)
            {
                //mydocumentspath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Log";
                //if (!Directory.Exists(mydocumentspath))
                //    Directory.CreateDirectory(mydocumentspath);

                //sw = File.AppendText(mydocumentspath + @"\ExcelAddinLog.txt");
                //sw.WriteLine("Error Message from ValidateTemplate Function");
                //sw.WriteLine("--------------------------------------------");
                //sw.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy HH:mm"));
                //sw.WriteLine(ex.Message);
                //sw.WriteLine(ex.StackTrace);
                //sw.WriteLine("--------------------------------------------");
                //sw.Close();
                //sw = null;
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        
            
        }

       

        void BankReconciliationTaskPane_VisibleChanged(object sender, EventArgs e)
        {
            Globals.Ribbons.BankReconciliationRibbon.tbBankReconciliation.Checked = BankReconciliationPane.Visible;
        }

        public Microsoft.Office.Tools.CustomTaskPane BankReconciliationPaneReturn
        {
            get
            {
                return BankReconciliationPane;
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

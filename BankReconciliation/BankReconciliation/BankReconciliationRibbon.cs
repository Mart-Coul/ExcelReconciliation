using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace BankReconciliation
{
    public partial class BankReconciliationRibbon : OfficeRibbon
    {
        public BankReconciliationRibbon()
        {
            InitializeComponent();
        }

        private void BankReconciliationRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void tbBankReconciliation_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.BankReconciliationPaneReturn.Visible = ((RibbonToggleButton)sender).Checked;
        }
    }
}

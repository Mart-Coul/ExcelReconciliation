using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BankReconciliation
{
    public partial class BankReconciliationUserControl : UserControl
    {
        public BankReconciliationUserControl()
        {
            InitializeComponent();
        }

        private void btnReconciliation_Click(object sender, EventArgs e)
        {
            try
            {
                string csvString = string.Empty;
                foreach (string file in Directory.GetFiles(@"D:\MartinProjectDetails\MartinProject\Dropbox\Ranoj-Martin\BankDocuments"))
                {
                    
                    using (CsvFileReader reader = new CsvFileReader(file))
                    {
                        CsvRow row = new CsvRow();
                        while (reader.ReadRow(row))
                        {
                            foreach (string s in row)
                            {
                                 csvString += s;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                
                //throw;
            }

           
           
        }
    }
}

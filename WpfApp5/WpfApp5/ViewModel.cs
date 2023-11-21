using Infragistics.Documents.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace WpfApp5
{
    public class ViewModel
    {
        public List<MyModel> DataCollection { get; set; }
        public ViewModel()
        {
            DataCollection = GenerateMyData();
        }
        internal static List<MyModel> GenerateMyData()
        {
            var data = new List<MyModel>();
            //var fileName = "SampleData.xlsx";
            var resourceName = @"C:\Users\mahmood\Desktop\kasri\3d final\data1.xlsx";

            Workbook dataWorkbook;
            Worksheet sheetOne;

            //var assembly = Assembly.GetAssembly(typeof(ViewModel));
            //using (var stream = assembly.GetManifestResourceStream(resourceName))
            //{
                dataWorkbook = Workbook.Load(resourceName);
            //}

            // Get data from excel file
            if (dataWorkbook != null)
            {
                sheetOne = dataWorkbook.Worksheets[0];

                foreach (var row in sheetOne.Rows)                
                {
                    if (row.Cells[6].Value == null)
                        break;

                    // Skip the headers row
                    if (row.Index == 0) continue;
                    if (row.Index == 1) continue;
                    if (row.Index == 2) continue;
                    if (row.Index == 3) continue;
                    if (row.Index == 4) continue;
                    if (row.Index == 5) continue;

                    var mm = new MyModel
                    {
                        X = (double)row.Cells[7].Value,
                        Y = (double)row.Cells[8].Value,
                        Depth = (double)(row.Cells[6].Value),
                    };

                    data.Add(mm);
                }
            }
            else
            {
                MessageBox.Show("FileLoadingFailure");
            }

            return data;
        }

    }
}

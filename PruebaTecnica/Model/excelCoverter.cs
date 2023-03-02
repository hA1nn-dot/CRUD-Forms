using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.Model
{
    static class excelCoverter
    {
        static public void export(DataGridView table) {
            Microsoft.Office.Interop.Excel.Application exportData = new Microsoft.Office.Interop.Excel.Application();

            exportData.Application.Workbooks.Add(true);

            int indexColumn = 0;

            foreach (DataGridViewColumn column in table.Columns)
            {
                indexColumn++;
                exportData.Cells[1, indexColumn] = column.Name;

            }

            int indexRow = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                indexRow++;
                indexColumn = 0;

                foreach (DataGridViewColumn column in table.Columns)
                {
                    indexColumn++;
                    exportData.Cells[indexRow + 1, indexColumn] = row.Cells[column.Name].Value;
                }
            }

            exportData.Visible = true;
        }
    }
}

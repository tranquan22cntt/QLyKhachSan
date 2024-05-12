using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ExcelWrapper
    {
        protected ExcelPackage _excelPackage;
        protected ExcelWorksheet _worksheet;

        public ExcelWrapper(string filePath)
        {
            InitializeExcelPackage(filePath);
        }

        private void InitializeExcelPackage(string filePath)
        {
            if (File.Exists(filePath))
            {
                _excelPackage = new ExcelPackage(new FileInfo(filePath));
            }
            else
            {
                _excelPackage = new ExcelPackage();
                _excelPackage.Workbook.Worksheets.Add("Sheet1");
            }

            _worksheet = _excelPackage.Workbook.Worksheets[0];
        }

        public void SetValue(int row, int column, string value)
        {
            _worksheet.Cells[row, column].Value = value;
        }

        public string GetValue(int row, int column)
        {
            return _worksheet.Cells[row, column].Value?.ToString();
        }

        public void Save()
        {
            _excelPackage.Save();
        }

        public void SaveAs(string newFilePath)
        {
            _excelPackage.SaveAs(new FileInfo(newFilePath));
        }

        public void Close()
        {
            _excelPackage.Dispose();
        }
    }
}

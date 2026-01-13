using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace QuanLyHocSinh.Database
{
    public class ExcelHelper
    {
        public static void ExportToExcel(DataGridView dgv, string fileNameDefault)
        {
          
            if (dgv.Rows.Count == 0 || dgv.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            bool userOpened = false;

            try
            {
                
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "DuLieuXuat";

              
                int colIndex = 1;

             
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible) 
                    {
                        worksheet.Cells[1, colIndex] = dgv.Columns[i].HeaderText;

                      
                        Excel.Range headerRange = worksheet.Cells[1, colIndex];
                        headerRange.Font.Bold = true;
                        headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                        colIndex++;
                    }
                }

             
                for (int i = 0; i < dgv.Rows.Count; i++) 
                {
                    colIndex = 1; 
                    for (int j = 0; j < dgv.Columns.Count; j++) 
                    {
                        if (dgv.Columns[j].Visible && !dgv.Rows[i].IsNewRow)
                        {
                            
                            object value = dgv.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 2, colIndex] = value != null ? "'" + value.ToString() : "";
                            colIndex++;
                        }
                    }
                }

                Excel.Range usedRange = worksheet.UsedRange;

                usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                usedRange.Columns.AutoFit();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx"; 
                sfd.FileName = fileNameDefault + "_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!\nĐường dẫn: " + sfd.FileName);

                  
                    if (MessageBox.Show("Bạn có muốn mở file vừa xuất không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        excelApp.Visible = true; 
                        
                        userOpened = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
            finally
            {
                if (workbook != null && !userOpened)
                {
                    workbook.Close(false);
                }

                if (excelApp != null && !userOpened)
                {
                    excelApp.Quit();
                }

                releaseObject(worksheet);
                releaseObject(workbook);
                releaseObject(excelApp);
            }
        }

      
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi dọn dẹp bộ nhớ: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
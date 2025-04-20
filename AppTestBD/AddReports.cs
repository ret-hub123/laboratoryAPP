using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PdfSharp.Drawing.Layout;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using PdfSharp.Charting;



namespace AppTestBD
{
    public partial class AddReports : Form
    {
        public string laborantId { get; set; }
        public AddReports(string laborantId)
        {
            InitializeComponent();
            this.laborantId = laborantId;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

      
            string datetimepicker1 = dateTimePicker1.Text;
            string datetimepicker2 = dateTimePicker2.Text;

            DB dB = new DB();
            DataTable table1 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();


            SqlCommand command_select = new SqlCommand("SELECT * FROM PerformedServices WHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicker2", dB.getConnection());

            command_select.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select.Parameters.Add("@datetimepicker2", SqlDbType.DateTime).Value = datetimepicker2;

            try
            {
                adapter.SelectCommand = command_select;
                adapter.Fill(table1);
                
                dB.openConnection();
                if (table1 != null && table1.Rows.Count > 0)
                {

                    dataGridView1.DataSource = table1;

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            /*string TextService = textService.Text;
            string TextDescript = textDescript.Text;
            string TextType = textType.Text;

            if ( string.IsNullOrEmpty(TextType) || string.IsNullOrEmpty(TextDescript))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }

            DB dB = new DB();
            DataTable table = new DataTable();


            SqlCommand command_add_report = new SqlCommand("INSERT INTO Reports (report_type, creationDate, laborant_id, performed_services_id, report_Data)" +
            "VALUES(@report_type, CONVERT(DATETIME, @creationDate , 120), @laborant_id, @performed_services_id, @report_Data);", dB.getConnection());

            command_add_report.Parameters.Add("@report_Data", SqlDbType.VarChar).Value = TextDescript;
            command_add_report.Parameters.Add("@report_type", SqlDbType.VarChar).Value = TextType;
            command_add_report.Parameters.Add("@performed_services_id", SqlDbType.Int).Value = TextService;

            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            command_add_report.Parameters.Add("@laborant_id", SqlDbType.VarChar).Value = laborantId;
            command_add_report.Parameters.Add("@creationDate", SqlDbType.VarChar).Value = currentTimeString;

            try
            {
                dB.openConnection();
                command_add_report.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */




        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<DataTable> results = new List<DataTable>();

            string namepdf = NamePdf.Text;
            string textdescription = TextDescription.Text;

            string datetimepicker1 = dateTimePicker1.Text;
            string datetimepicker2 = dateTimePicker2.Text;

            DB dB = new DB();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();


            SqlCommand command_select = new SqlCommand("SELECT * FROM PerformedServices WHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicke2", dB.getConnection());
            SqlCommand command_select_len = new SqlCommand("SELECT COUNT(*) FROM PerformedServices WHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicke2", dB.getConnection());
            SqlCommand command_select_col_patient = new SqlCommand("SELECT COUNT(DISTINCT [Order].[patient_id]) AS TotalPatients FROM [PerformedServices]" +
                "INNER JOIN [OrderInServices] ON [PerformedServices].orderin_services_id = [OrderInServices].orderin_services_id INNER JOIN [Order] ON [OrderInServices].order_id = [Order].order_id " +
                "WHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicke2;", dB.getConnection());
            SqlCommand command_select_col_patient_for_server = new SqlCommand("SELECT [LaboratoryServices].[service_name], COUNT([Order].[patient_id]) AS 'Количество пациентов' FROM [PerformedServices] INNER JOIN [OrderInServices] ON [PerformedServices].orderin_services_id = [OrderInServices].orderin_services_id\r\nINNER JOIN [Order] ON [OrderInServices].order_id = [Order].order_id INNER JOIN [LaboratoryServices] ON [LaboratoryServices].laboratory_services_id = [OrderInServices].laboratory_services_id \r\nWHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicke2 GROUP BY [LaboratoryServices].[service_name];", dB.getConnection());


            command_select.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_len.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_len.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_col_patient.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_col_patient.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_col_patient_for_server.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_col_patient_for_server.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            if (string.IsNullOrEmpty(namepdf)){
                MessageBox.Show("Введите название файла");
                return;
            }
            if (string.IsNullOrEmpty(textdescription))
            {
                textdescription = "Описание " + namepdf;
            
            }


            PdfDocument document = new PdfDocument();
            document.Info.Title = namepdf;
            string filePath = @"C:\Users\CrivayCapcha\source\repos\AppTestBD\AppTestBD\reports\" + namepdf + ".pdf";



            if (radioButton1.Checked)
            {

                try
                {

                    dB.openConnection();


                    adapter.SelectCommand = command_select;
                    adapter.Fill(table1);
                    results.Add(table1);

                    adapter.SelectCommand = command_select_col_patient_for_server;
                    adapter.Fill(table2);
                    results.Add(table2);

                    string col_servis = Convert.ToString(command_select_len.ExecuteScalar());
                    Debug.Write(col_servis);
                    DataTable lenTable = new DataTable();
                    lenTable.Columns.Add("Count", typeof(string));
                    lenTable.Rows.Add(col_servis); 
                    results.Add(lenTable);

                    string col_patient = Convert.ToString(command_select_col_patient.ExecuteScalar());
                    Debug.Write(col_patient);
                    DataTable countTable = new DataTable();
                    countTable.Columns.Add("Count", typeof(string));
                    countTable.Rows.Add(col_patient);
                    results.Add(countTable);


                    ExportDataTableToPdf(results, namepdf, textdescription, document);
                    document.Save(filePath);
                    MessageBox.Show($"PDF-отчет сохранен в {namepdf}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    results.Clear();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButton2.Checked)
            {
                dB.openConnection();
                adapter.SelectCommand = command_select_col_patient_for_server;
                adapter.Fill(table2);
                results.Add(table2);


                ExportDataGraphToPdf(results, namepdf, textdescription, document);
                document.Save(filePath);
                MessageBox.Show($"PDF-отчет сохранен в {namepdf}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                results.Clear();


            }
            else if (radioButton3.Checked)
            {
                dB.openConnection();
                adapter.SelectCommand = command_select;
                adapter.Fill(table1);
                results.Add(table1);

                adapter.SelectCommand = command_select_col_patient_for_server;
                adapter.Fill(table2);
                results.Add(table2);

                string col_servis = Convert.ToString(command_select_len.ExecuteScalar());
                Debug.Write(col_servis);
                DataTable lenTable = new DataTable();
                lenTable.Columns.Add("Count", typeof(string));
                lenTable.Rows.Add(col_servis);
                results.Add(lenTable);

                string col_patient = Convert.ToString(command_select_col_patient.ExecuteScalar());
                Debug.Write(col_patient);
                DataTable countTable = new DataTable();
                countTable.Columns.Add("Count", typeof(string));
                countTable.Rows.Add(col_patient);
                results.Add(countTable);


                ExportDataTableandGraphToPdf(results, namepdf, textdescription, document);
                document.Save(filePath);
                MessageBox.Show($"PDF-отчет сохранен в {namepdf}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                results.Clear();

            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
            }

        }

        

        private void ExportDataTableToPdf(List<DataTable> ResRequest, string namepdf, string description, PdfDocument document)
        {

            document.Info.Title = namepdf;
            string filePath = @"C:\Users\CrivayCapcha\source\repos\AppTestBD\AppTestBD\reports\" + namepdf + ".pdf";


            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

      
            XFont font = new XFont("Verdana", 8); 
         
            double pageWidth = page.Width;
            double pageHeight = page.Height;
            double margin = 20;

            double currentY = margin;
            double currentX = margin;
            double availableWidth = pageWidth - 2 * margin;  
            double availableHeight = pageHeight - 2 * margin;
            double headerHeight = 20;


            gfx.DrawString(namepdf, font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 20;

          
           var rect = new XRect(currentX, currentY, availableWidth, 50);
            gfx.DrawString(description, font, XBrushes.Purple, rect, XStringFormats.TopCenter);
            currentY = 40 + currentY;


            double columnWidth = (pageWidth - 2 * margin) / ResRequest[0].Columns.Count;

            gfx.DrawString("Все заказы за указзынный период", font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 30;

            for (int i = 0; i < ResRequest[0].Columns.Count; i++)
            {
                string headerText = ResRequest[0].Columns[i].ColumnName;
                XRect headerRect = new XRect(currentX, currentY, columnWidth, headerHeight);

                gfx.DrawRectangle(XPens.Black, headerRect);
                gfx.DrawString(headerText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                currentX += columnWidth;
            }

          
            currentY += 30;
            currentX = margin;

         
            foreach (DataRow row in ResRequest[0].Rows)
            {
                for (int i = 0; i < ResRequest[0].Columns.Count; i++)
                {
                    string cellText = row[i]?.ToString() ?? string.Empty;
                    XRect cellRect = new XRect(currentX, currentY, columnWidth, 20);

                    gfx.DrawRectangle(XPens.Black, cellRect);
                    gfx.DrawString(cellText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                    currentX += columnWidth;
                }
                currentY += 20; 
                currentX = margin; 
            }
            currentY += 30;


            gfx.DrawString("Количество оказанных услуг " + ResRequest[2].Rows[0][0], font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);


            currentY += 30; 
            gfx.DrawString("Количество обслуженных пациентов " + ResRequest[3].Rows[0][0], font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 30;



            gfx.DrawString("Количество пациентов по услугам", font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 30;

            for (int i = 0; i < ResRequest[1].Columns.Count; i++)
            {
                string headerText = ResRequest[1].Columns[i].ColumnName;
                
                
                if (i == 0)
                {
                    gfx.DrawString(headerText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth + 20, 20), XStringFormats.Center);
                    XRect headerRect = new XRect(currentX, currentY, columnWidth + 20, headerHeight);
                    gfx.DrawRectangle(XPens.Black, headerRect);
                    currentX += columnWidth + 20;
                }
                else
                {
                    gfx.DrawString(headerText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                    XRect headerRect = new XRect(currentX, currentY, columnWidth + 20, headerHeight);
                    gfx.DrawRectangle(XPens.Black, headerRect);
                    currentX += columnWidth + 20;
                }

            }


            currentY += 30;
            currentX = margin;


            foreach (DataRow row in ResRequest[1].Rows)
            {
                for (int i = 0; i < ResRequest[1].Columns.Count; i++)
                {
                    string cellText = row[i]?.ToString() ?? string.Empty;
                    XRect cellRect = new XRect(currentX, currentY, columnWidth + 20, 20);

                    gfx.DrawRectangle(XPens.Black, cellRect);
                    
                    if (i == 0)
                    {
                        gfx.DrawString(cellText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth + 20, 20), XStringFormats.Center);
                        currentX += columnWidth + 20;
                    }
                    else
                    {
                        gfx.DrawString(cellText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                        currentX += columnWidth;
                    }
                    
                    

                }
                currentY += 20;
                currentX = margin;
            }
            currentY += 30;

            
            

           
        }


        private void ExportDataGraphToPdf(List<DataTable> ResRequest, string namepdf, string description, PdfDocument document)
        {
            
            document.Info.Title = namepdf;
            string filePath = @"C:\Users\CrivayCapcha\source\repos\AppTestBD\AppTestBD\reports\" + namepdf + ".pdf";


            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);


            XFont font = new XFont("Verdana", 8);


            double pageWidth = page.Width;
            double pageHeight = page.Height;
            double margin = 20;
            double maxValue = 0;

            double currentY = margin;
            double currentX = margin;
            double availableWidth = pageWidth - 2 * margin;
            double availableHeight = pageHeight - 2 * margin;
            double headerHeight = 20;

            foreach (DataRow row in ResRequest[0].Rows)
            {
                double value = Convert.ToDouble(row["Количество пациентов"]); // Имя столбца с количеством
                maxValue = Math.Max(maxValue, value);
            }


            gfx.DrawString(namepdf, font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 20;


            var rect = new XRect(currentX, currentY, availableWidth, 50);
            gfx.DrawString(description, font, XBrushes.Purple, rect, XStringFormats.TopCenter);
            currentY = 40 + currentY;

            XRect chartRect = new XRect(currentX, currentY, 500, 300);

            double chartAreaWidth = chartRect.Width - 2 * margin;
            double chartAreaHeight = chartRect.Height - 2 * margin;

            XPen axisPen = new XPen(XColors.Black, 1);

            gfx.DrawLine(axisPen, currentX + margin, currentY + chartRect.Height - margin, currentX + chartRect.Width - margin, currentY + chartRect.Height - margin);

            gfx.DrawLine(axisPen, currentX + margin, currentY + chartRect.Height - margin, currentX + margin, currentY + margin);


            double barWidth = chartAreaWidth / ResRequest[0].Rows.Count;
            XSolidBrush barBrush = new XSolidBrush(XColor.FromArgb(100, 70, 130, 180)); // Полупрозрачный синий

            for (int i = 0; i < ResRequest[0].Rows.Count; i++)
            {
                DataRow row = ResRequest[0].Rows[i];
                string serviceName = row["service_name"].ToString();
                double value = Convert.ToDouble(row["Количество пациентов"]);

                // Вычисляем высоту столбца
                double barHeight = (value / maxValue) * chartAreaHeight;

                // Вычисляем координаты столбца
                double barX = currentX + margin + i * barWidth;
                double barY = currentY + chartRect.Height - margin - barHeight;

                // Рисуем столбец
                XRect barRect = new XRect(barX, barY, barWidth, barHeight);
                gfx.DrawRectangle(barBrush, barRect);

                // Рисуем подпись (название услуги) под столбцом
                XSize labelSize = gfx.MeasureString(serviceName, font);

                // Вычисляем X координату для центрирования метки под столбцом
                double labelX = currentX + margin + i * barWidth + (barWidth - labelSize.Width) / 2;

                // Вычисляем Y координату для размещения метки под осью X, учитывая высоту шрифта и небольшой отступ
                double labelY = currentY + chartRect.Height - margin + labelSize.Height;

                // Создаем XRect для метки
                XRect labelRect = new XRect(labelX-20, currentY + chartRect.Height - margin, barWidth, labelSize.Height);

                gfx.DrawString(serviceName, font, XBrushes.Black, labelRect, XStringFormats.TopCenter);
            }


            currentY += chartRect.Height + 50;


            double columnWidth = (pageWidth - 2 * margin) / ResRequest[0].Columns.Count;

            gfx.DrawString("Количество пациентов по услугам", font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 30;

            for (int i = 0; i < ResRequest[0].Columns.Count; i++)
            {
                string headerText = ResRequest[0].Columns[i].ColumnName;
                XRect headerRect = new XRect(currentX, currentY, columnWidth, headerHeight);

                gfx.DrawRectangle(XPens.Black, headerRect);
                gfx.DrawString(headerText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                currentX += columnWidth;
            }


            currentY += 30;
            currentX = margin;


            foreach (DataRow row in ResRequest[0].Rows)
            {
                for (int i = 0; i < ResRequest[0].Columns.Count; i++)
                {
                    string cellText = row[i]?.ToString() ?? string.Empty;
                    XRect cellRect = new XRect(currentX, currentY, columnWidth, 20);

                    gfx.DrawRectangle(XPens.Black, cellRect);
                    gfx.DrawString(cellText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.Center);
                    currentX += columnWidth;
                }
                currentY += 20;
                currentX = margin;
            }
            currentY += 30;

          
            


        }

       
            private void ExportDataTableandGraphToPdf(List<DataTable> ResRequest, string namepdf, string description, PdfDocument document)
        {
            List<DataTable> res = new List<DataTable>();
            res.Add(ResRequest[1]);

            for (int i = 0; i < 4; i++)
            {
                Console.Write(ResRequest[i]);
            }

                Debug.Write(ResRequest[3]);
            ExportDataTableToPdf(ResRequest, namepdf, description, document);
            ExportDataGraphToPdf(res, namepdf, description, document);

            res.Clear();


        }


}
}

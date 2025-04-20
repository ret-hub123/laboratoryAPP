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
using iTextSharp.text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;



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
            /*
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
            SqlCommand command_select_col_patient_for_server = new SqlCommand("SELECT [LaboratoryServices].[service_name], COUNT([Order].[patient_id]) FROM [PerformedServices] INNER JOIN [OrderInServices] ON [PerformedServices].orderin_services_id = [OrderInServices].orderin_services_id\r\nINNER JOIN [Order] ON [OrderInServices].order_id = [Order].order_id INNER JOIN [LaboratoryServices] ON [LaboratoryServices].laboratory_services_id = [OrderInServices].laboratory_services_id \r\nWHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicke2 GROUP BY [LaboratoryServices].[service_name];", dB.getConnection());


            command_select.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_len.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_len.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_col_patient.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_col_patient.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;

            command_select_col_patient_for_server.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select_col_patient_for_server.Parameters.Add("@datetimepicke2", SqlDbType.DateTime).Value = datetimepicker2;



            try
            {
                adapter.SelectCommand = command_select;
                adapter.Fill(table1);
                adapter.SelectCommand = command_select_col_patient_for_server;
                adapter.Fill(table2);

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
            */

            string namepdf = NamePdf.Text;
            string textdescription = TextDescription.Text;  
            string datetimepicker1 = dateTimePicker1.Text;
            string datetimepicker2 = dateTimePicker2.Text;

            if (string.IsNullOrEmpty(namepdf) || string.IsNullOrEmpty(textdescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DB dB = new DB();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command_select = new SqlCommand("SELECT * FROM PerformedServices WHERE execution_date >= @datetimepicker1 AND execution_date <= @datetimepicker2", dB.getConnection());

            command_select.Parameters.Add("@datetimepicker1", SqlDbType.DateTime).Value = datetimepicker1;
            command_select.Parameters.Add("@datetimepicker2", SqlDbType.DateTime).Value = datetimepicker2;

            adapter.SelectCommand = command_select;
            

            
            


            if (radioButton1.Checked)
            {

                try
                {
                    dB.openConnection();
                    adapter.Fill(dataTable);

                    ExportDataTableToPdf(dataTable, namepdf, textdescription);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButton2.Checked)
            {

            }
            else if (radioButton3.Checked)
            {

            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
            }

        }


        private void ExportDataTableToPdf(DataTable dataTable, string namepdf, string description)
        {
            // Создаем новый PDF документ
            PdfDocument document = new PdfDocument();
            document.Info.Title = namepdf;
            string filePath = @"C:\Users\CrivayCapcha\source\repos\AppTestBD\AppTestBD\reports\" + namepdf + ".pdf";

            // Создаем новую страницу
            PdfPage page = document.AddPage();

            // Получаем графический объект для страницы
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            // Создаем шрифт
            XFont font = new XFont("Verdana", 8); // Сделаем шрифт меньше для таблицы

            // Размеры страницы
            double pageWidth = page.Width;
            double pageHeight = page.Height;
            

            // Отступы
            double margin = 20;

            // Начальные координаты для рисования таблицы
            double currentY = margin;
            double currentX = margin;
            double availableWidth = pageWidth - 2 * margin;  // Доступная ширина
            double availableHeight = pageHeight - 2 * margin; // Доступная высота

            // Рисуем заголовок
            gfx.DrawString(namepdf, font, XBrushes.Black, new XRect(currentX, currentY, availableWidth, 20), XStringFormats.TopCenter);
            currentY += 30;

          
            var rect = new XRect(currentX, currentY, 200, 100);
            XPen xpen = new XPen(XColors.Navy, 0.4);

            gfx.DrawRectangle(xpen, rect);


            XBrush brush = XBrushes.Purple;
            tf.DrawString(description, font, brush,
                          new XRect(rect.X + 5, rect.Y + 6, rect.Width, rect.Height), XStringFormats.TopLeft);



            currentY = 50 + currentY + rect.Height;
            // Ширина столбца (равномерно распределяем)
            double columnWidth = (pageWidth - 2 * margin) / dataTable.Columns.Count;

            // Рисуем заголовки
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                string headerText = dataTable.Columns[i].ColumnName;
                gfx.DrawString(headerText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.TopLeft);
                currentX += columnWidth;
            }

            // Сдвигаемся ниже заголовков
            currentY += 30;
            currentX = margin;

            // Рисуем данные
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    string cellText = row[i]?.ToString() ?? string.Empty;
                    gfx.DrawString(cellText, font, XBrushes.Black, new XRect(currentX, currentY, columnWidth, 20), XStringFormats.TopLeft);
                    currentX += columnWidth;
                }
                currentY += 20; // Сдвигаемся на следующую строку
                currentX = margin; // Возвращаемся к началу строки
            }

            // Сохраняем документ
            document.Save(filePath);
            

            MessageBox.Show($"PDF-отчет сохранен в {namepdf}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

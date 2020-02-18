using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            PdfReport pdfReport = new PdfReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
            
            
        }
    }
}

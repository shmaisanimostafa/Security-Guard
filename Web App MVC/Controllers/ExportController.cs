using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
//using Security_Guard.Data;
using Security_Guard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using File = Security_Guard.Models.File;

public class ExportController : Controller
{
    private DBContext Context { get; set; }
    public ExportController(DBContext ctx)
    {
        Context = ctx;
    }
    public IActionResult ExportToExcel()
    {
        // Get data
        List<File> data = GetData();

        // Create Excel package
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            // Add headers
            worksheet.Cells.LoadFromCollection(data, true);

            // Set up other Excel-related configurations if needed

            // Convert to byte array and return as a file
            var fileBytes = package.GetAsByteArray();
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_data.xlsx");
        }
    }

    private List<File> GetData()
    {
        IQueryable<File> queryFiles = Context.Files.OrderBy(f => f.Id);
        List<File> Files = queryFiles.ToList();

        return Files;
    }

}

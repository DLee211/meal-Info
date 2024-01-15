using System.Diagnostics.CodeAnalysis;
using ConsoleTableExt;

namespace meal_Info;

public class TableVisualisationEngine
{
    public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
    {
        Console.Clear();

        if (tableName == null)
            tableName = "";
        
        ConsoleTableBuilder
            .From(tableData)
            .WithColumn(tableName)
            .WithFormat(ConsoleTableBuilderFormat.Minimal)
            .ExportAndWriteLine(TableAligntment.Left);
    }
}
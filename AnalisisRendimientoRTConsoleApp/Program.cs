using AnalisisRendimientoRTConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido/a al Análisis de Rendimiento Deportivo en Tiempo Real!");
        //bienvenida a mi mundo
        var SECRET_KEY = "admin123";
        var API_KEY = "client123";

        // Datos de rendimiento simulados (pueden ser reemplazados por datos reales de Firebase)
        List<double> performanceData = new(){ 85.5, 90.2, 78.4, 92.3, 88.1 };

        // Instanciamos el analizador de datos
        DataAnalyzer analyzer = new();

        // Generamos el informe de rendimiento
        analyzer.GeneratePerformanceReport(performanceData);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

namespace AnalisisRendimientoRTConsoleApp
{
    public class DataAnalyzer
    {
        // Método para calcular el promedio de rendimiento deportivo de los usuarios
        public double CalculateAveragePerformance(List<double> performanceData)
        {
            if (performanceData == null || performanceData.Count == 0)
            {
                throw new ArgumentException("No se puede calcular el promedio de una lista vacía.");
            }

            double sum = 0;
            foreach (var data in performanceData)
            {
                sum += data;
            }
            return sum / performanceData.Count;
        }

        // Método para identificar el mejor rendimiento
        public double GetBestPerformance(List<double> performanceData)
        {
            if (performanceData == null || performanceData.Count == 0)
            {
                throw new ArgumentException("No se puede obtener el mejor rendimiento de una lista vacía.");
            }

            double bestPerformance = performanceData[0];
            foreach (var data in performanceData)
            {
                if (data > bestPerformance)
                {
                    bestPerformance = data;
                }
            }
            return bestPerformance;
        }

        // Método para generar un informe simple del rendimiento
        public void GeneratePerformanceReport(List<double> performanceData)
        {
            Console.WriteLine("Informe de Rendimiento Deportivo:");
            Console.WriteLine($"Promedio de Rendimiento: {CalculateAveragePerformance(performanceData):0.00}");
            Console.WriteLine($"Mejor Rendimiento: {GetBestPerformance(performanceData):0.00}");
        }
    }
}

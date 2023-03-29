using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Module.Controllers
{
    public class VectorController : ControllerBase
    {
        [HttpGet("exercise1")]
        public ActionResult Cosine(double[] x, double[] y)
        {
            if (x == null || y == null || x.Length != 3 || y.Length != 3)
            {
                return BadRequest("Invalid input. Please provide two 3-dimensional vectors.");
            }

            double dotProduct = x[0] * y[0] + x[1] * y[1] + x[2] * y[2];
            double magnitudeX = Math.Sqrt(x[0] * x[0] + x[1] * x[1] + x[2] * x[2]);
            double magnitudeY = Math.Sqrt(y[0] * y[0] + y[1] * y[1] + y[2] * y[2]);
            double cosine = dotProduct / (magnitudeX * magnitudeY);

            return Ok(cosine);
        }

        [HttpGet("exercise2")]
        public double CalculateCosSum(int n, double x)
        {
            if (n < 1)
            {
                throw new ArgumentException("n should be a natural number greater or equal to 1.", nameof(n));
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Cos(Math.Pow(x, i));
            }

            return sum;
        }
    }
}
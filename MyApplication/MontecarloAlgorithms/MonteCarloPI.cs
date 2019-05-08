﻿/// <summary>
/// The MonteCarloPI.cs file
/// </summary>
namespace MontecarloAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The MonteCarloPI implementation
    /// </summary>
    public class MonteCarloPI
    {
        /// <summary>
        /// Internal declaration of points dictionary
        /// </summary>
        private List<MPoint> points;

        /// <summary>
        /// The private declaration of random generator.
        /// </summary>
        private Random rnd;

        /// <summary>
        /// The public declaration of points.
        /// </summary>
        public List<MPoint> Points { get { return points; } }

        /// <summary>
        /// Use this method to generate a new point.
        /// The MonteCarloPI constructor.
        /// </summary>
        public MonteCarloPI()
        {
            this.rnd = new Random();
            this.points = new List<MPoint>();
        }

        /// <summary>
        /// Method to generate a new point.
        /// </summary>
        public void GeneratePoint()
        {
            MPoint newPoint = GenerateRandomPoint();
            this.points.Add(newPoint);
        }

        /// <summary>
        /// Returns PI value
        /// </summary>
        /// <returns>The PI approximation</returns>
        public float GetPI()
        {
            int circleCounter = this.points.Count(x=>x.insideCircle);
            int rectangleCounter = this.points.Count;

            return 4.0f * circleCounter / rectangleCounter;
        }

        /// <summary>
        /// Generates a new random point.
        /// </summary>
        /// <returns>An instance of MPoint.</returns>
        private MPoint GenerateRandomPoint()
        {
            float x = GenerateRandomValue();
            float y = GenerateRandomValue();

            double ratio = Math.Sqrt(x * x + y * y);
            bool insideCircle = ratio <= 0.5;

            MPoint newOne = new MPoint(x, y, insideCircle);
            return newOne;
        }

        /// <summary>
        /// Generates a random value
        /// </summary>
        /// <returns>The random value</returns>
        private float GenerateRandomValue()
        {
            return (float)rnd.NextDouble() - 0.5f;
        }
    }
}

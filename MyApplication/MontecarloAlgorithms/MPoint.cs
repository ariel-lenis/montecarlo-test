/// <summary>
/// The MPoint.cs file.
/// </summary>
namespace MontecarloAlgorithms
{
    /// <summary>
    /// The MPoint struct.
    /// </summary>
    public struct MPoint
    {
        /// <summary>
        /// The X coordinate.
        /// </summary>
        public double X;

        /// <summary>
        /// The Y coordinate.
        /// </summary>
        public double Y;

        /// <summary>
        /// insideCircle value
        /// </summary>
        public bool InsideCircle;

        /// <summary>
        /// Initialization of the MPoint value.
        /// </summary>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        /// <param name="insideCircle">True if the point is inside the circle.</param>
        public MPoint(double x, double y, bool insideCircle)
        {
            this.X = x;
            this.Y = y;
            this.InsideCircle = insideCircle;
        }
    }
}

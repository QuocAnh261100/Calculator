using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Math;
using AForge;

namespace calculator
{
    public class Line
    {
        private readonly float k; // line's slope
        private readonly float b; // Y-coordinate where line intersects Y-axis
        public bool IsVertical
        {
            get { return float.IsInfinity(k); }
        }

        /// <summary>
        /// Checks if the line horizontal or not.
        /// </summary>
        public bool IsHorizontal
        {
            get { return (k == 0); }
        }

        /// <summary>
        /// Gets the slope of the line.
        /// </summary>
        public float Slope { get { return k; } }

        /// <summary>
        /// If not <see cref="IsVertical"/>, gets the Line's Y-intercept.
        /// If <see cref="IsVertical"/> gets the line's X-intercept.
        /// </summary>
        public float Intercept { get { return b; } }

        /// <summary>
        /// Creates a <see cref="Line"/>  that goes through the two specified points.
        /// </summary>
        /// 
        /// <param name="point1">One point on the line.</param>
        /// <param name="point2">Another point on the line.</param>
        /// 
        /// <returns>Returns a <see cref="Line"/> representing the line between <paramref name="point1"/>
        /// and <paramref name="point2"/>.</returns>
        /// 
        /// <exception cref="ArgumentException">Thrown if the two points are the same.</exception>
        /// 
        public static Line FromPoints(Point point1, Point point2)
        {
            return new Line(point1, point2);
        }

        /// <summary>
        /// Creates a <see cref="Line"/> with the specified slope and intercept.
        /// </summary>
        /// 
        /// <param name="slope">The slope of the line</param>
        /// <param name="intercept">The Y-intercept of the line, unless the slope is an
        /// infinity, in which case the line's equation is "x = intercept" instead.</param>
        /// 
        /// <returns>Returns a <see cref="Line"/> representing the specified line.</returns>
        /// 
        /// <remarks><para>The construction here follows the same rules as for the rest of this class.
        /// Most lines are expressed as y = slope * x + intercept. Vertical lines, however, are 
        /// x = intercept. This is indicated by <see cref="IsVertical"/> being true or by 
        /// <see cref="Slope"/> returning <see cref="float.PositiveInfinity"/> or 
        /// <see cref="float.NegativeInfinity"/>.</para></remarks>
        /// 
        public static Line FromSlopeIntercept(float slope, float intercept)
        {
            return new Line(slope, intercept);
        }

        /// <summary>
        /// Constructs a <see cref="Line"/> from a radius and an angle (in degrees).
        /// </summary>
        /// 
        /// <param name="radius">The minimum distance from the line to the origin.</param>
        /// <param name="theta">The angle of the vector from the origin to the line.</param>
        /// 
        /// <returns>Returns a <see cref="Line"/> representing the specified line.</returns>
        /// 
        /// <remarks><para><paramref name="radius"/> is the minimum distance from the origin
        /// to the line, and <paramref name="theta"/> is the counterclockwise rotation from
        /// the positive X axis to the vector through the origin and normal to the line.</para>
        /// <para>This means that if <paramref name="theta"/> is in [0,180), the point on the line
        /// closest to the origin is on the positive X or Y axes, or in quadrants I or II. Likewise,
        /// if <paramref name="theta"/> is in [180,360), the point on the line closest to the
        /// origin is on the negative X or Y axes, or in quadrants III or IV.</para></remarks>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">Thrown if radius is negative.</exception>
        /// 
        //public static Line FromRTheta( float radius, float theta )
        //{
        //    return new Line( radius, theta, false );
        //}

        /// <summary>
        /// Constructs a <see cref="Line"/> from a point and an angle (in degrees).
        /// </summary>
        /// 
        /// <param name="point">The minimum distance from the line to the origin.</param>
        /// <param name="theta">The angle of the normal vector from the origin to the line.</param>
        /// 
        /// <remarks><para><paramref name="theta"/> is the counterclockwise rotation from
        /// the positive X axis to the vector through the origin and normal to the line.</para>
        /// <para>This means that if <paramref name="theta"/> is in [0,180), the point on the line
        /// closest to the origin is on the positive X or Y axes, or in quadrants I or II. Likewise,
        /// if <paramref name="theta"/> is in [180,360), the point on the line closest to the
        /// origin is on the negative X or Y axes, or in quadrants III or IV.</para></remarks>
        /// 
        /// <returns>Returns a <see cref="Line"/> representing the specified line.</returns>
        /// 
        public static Line FromPointTheta(Point point, float theta)
        {
            return new Line(point, theta);
        }

        #region Private Constructors
        public Line(Point start, Point end)
        {
            if (start == end)
            {
                throw new ArgumentException("Start point of the line cannot be the same as its end point.");
            }

            k = (end.Y - start.Y) / (end.X - start.X);
            b = float.IsInfinity(k) ? start.X : start.Y - k * start.X;
        }

        private Line(float slope, float intercept)
        {
            k = slope;
            b = intercept;
        }

        //private Line( float radius, float theta, bool unused )
        //{
        //    if ( radius < 0 )
        //    {
        //        throw new ArgumentOutOfRangeException( "radius", radius, "Must be non-negative" );
        //    }

        //    theta *= (float) ( Math.PI / 180 );

        //    float sine = (float) Math.Sin( theta ), cosine = (float) Math.Cos( theta );
        //    Point pt1 = new Point( radius * cosine, radius * sine );

        //    // -1/tan, to get the slope of the line, and not the slope of the normal
        //    k = -cosine / sine;

        //    if ( !float.IsInfinity( k ) )
        //    {
        //        b = pt1.Y - k * pt1.X;
        //    }
        //    else
        //    {
        //        b = Math.Abs( radius );
        //    }
        //}

        private Line(Point point, float theta)
        {
            theta *= (float)(Math.PI / 180);

            k = (float)(-1.0f / Math.Tan(theta));

            if (!float.IsInfinity(k))
            {
                b = point.Y - k * point.X;
            }
            else
            {
                b = point.X;
            }
        }
        #endregion

        /// <summary>
        /// Calculate minimum angle between this line and the specified line measured in [0, 90] degrees range.
        /// </summary>
        /// 
        /// <param name="secondLine">The line to find angle between.</param>
        /// 
        /// <returns>Returns minimum angle between lines.</returns>
        /// 
        public float GetAngleBetweenLines(Line secondLine)
        {
            float k2 = secondLine.k;

            bool isVertical1 = IsVertical;
            bool isVertical2 = secondLine.IsVertical;

            // check if lines are parallel
            if ((k == k2) || (isVertical1 && isVertical2))
                return 0;

            float angle;

            if ((!isVertical1) && (!isVertical2))
            {
                float tanPhi;
                if (k2 > k)
                {
                    tanPhi = (k2 - k)/(1+k*k2);
                }
                else
                {
                    tanPhi = (k - k2) / (1 + k * k2);
                }
                if(Math.Atan(tanPhi)>0)
                    angle = (float)((Math.PI - Math.Atan(tanPhi))*(180.0/Math.PI));
                else
                    angle = (float)((- Math.Atan(tanPhi)) * (180.0 / Math.PI));
            }
            else
            {
                // one of the lines is parallel to Y axis

                if (isVertical1)
                {

                    angle = (float)((Math.PI / 2 + Math.Atan(k2) * Math.Sign(k2))*(180.0/Math.PI));
                }
                else
                {
                    angle = (float)((Math.PI / 2 + Math.Atan(k) * Math.Sign(k))* (180.0 / Math.PI));
                }
            }

            // convert radians to degrees

            if (angle < 0)
            {
                angle = 180+angle;
            }

            return angle;
        }
    }
}

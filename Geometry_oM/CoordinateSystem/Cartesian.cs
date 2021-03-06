/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System.ComponentModel;
using BH.oM.Base;

namespace BH.oM.Geometry.CoordinateSystem
{
    [Description("Cartesian coordinate system. All vectors to be orthogonal unit vectors")]
    public class Cartesian : IGeometry, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public Vector X { get; } = Vector.XAxis;

        public Vector Y { get; } = Vector.YAxis;

        public Vector Z { get; } = Vector.ZAxis;

        public Point Origin { get; set; } = Point.Origin;

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public Cartesian(Point origin, Vector x, Vector y, Vector z)
        {
            Origin = origin;
            X = x;
            Y = y;
            Z = z;
        }

        /***************************************************/

        public Cartesian()
        { }

        /***************************************************/
        /**** Explicit Casting                          ****/
        /***************************************************/

        public static explicit operator Cartesian(Point point)
        {
            return new Cartesian() { Origin = point };
        }

        /***************************************************/
    }
}


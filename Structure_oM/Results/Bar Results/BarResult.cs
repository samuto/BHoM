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

using System;
using BH.oM.Common;
using System.ComponentModel;


namespace BH.oM.Structure.Results
{
    [Description("Base class for all bar result classes. Stores all identifier information and how to sort the results in a collection.")]
    public abstract class BarResult : IResult
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("Id of the bar that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package.")]
        public IComparable ObjectId { get; set; } = "";

        [Description("Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package.")]
        public IComparable ResultCase { get; set; } = "";

        [Description("Time step for time history results.")]
        public double TimeStep { get; set; } = 0.0;

        [Description("Position on the bar as normalised length, i.e. 0 for start, 1 for end and 0.5 for middle.")]
        public double Position { get; set; } = 0.0;

        [Description("How many division points along the bar was used when extracting this result. This generally means that this many results with the same ObjectId, ResultCase and TimeStep was extracted.")]
        public int Divisions { get; set; } = 1;

        /***************************************************/
        /**** IComparable Interface                     ****/
        /***************************************************/

        [Description("Controls how this result is sorted in relation to other results. Sorts with the following priority: Type, ObjectId, ResultCase, TimeStep, Position.")]
        public int CompareTo(IResult other)
        {
            BarResult otherRes = other as BarResult;

            if (otherRes == null)
                return this.GetType().Name.CompareTo(other.GetType().Name);

            int n = this.ObjectId.CompareTo(otherRes.ObjectId);
            if (n == 0)
            {
                int l = this.ResultCase.CompareTo(otherRes.ResultCase);
                if (l == 0)
                {
                    int t = this.TimeStep.CompareTo(otherRes.TimeStep);
                    return t == 0 ? this.Position.CompareTo(otherRes.Position) : t;
                }
                else
                {
                    return l;
                }
            }
            else
            {
                return n;
            }

        }

        /***************************************************/

    }
}


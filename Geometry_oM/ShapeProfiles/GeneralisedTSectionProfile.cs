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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BH.oM.Base;
using BH.oM.Geometry;

namespace BH.oM.Geometry.ShapeProfiles
{
    public class GeneralisedTSectionProfile : BHoMObject, IProfile, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public ShapeType Shape { get; } = ShapeType.Tee;

        public double Height { get; }

        public double WebThickness { get; }

        public double LeftOutstandWidth { get; }

        public double LeftOutstandThickness { get; }

        public double RightOutstandWidth { get; }

        public double RightOutstandThickness { get; }

        public bool MirrorAboutLocalY { get; }

        public ReadOnlyCollection<ICurve> Edges { get; }

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public GeneralisedTSectionProfile(double height, double webThickness, double leftOutstandWidth, double leftOutstandThickness, double rightOutstandWidth, double rightOutstandThickness, bool mirrorAboutLocalY, IEnumerable<ICurve> edges)
        {
            Height = height;
            WebThickness = webThickness;
            LeftOutstandWidth = leftOutstandWidth;
            LeftOutstandThickness = leftOutstandThickness;
            RightOutstandWidth = rightOutstandWidth;
            RightOutstandThickness = rightOutstandThickness;
            MirrorAboutLocalY = mirrorAboutLocalY;
            Edges = new ReadOnlyCollection<ICurve>(edges.ToList());
        }

        /***************************************************/
    }
}                                                   

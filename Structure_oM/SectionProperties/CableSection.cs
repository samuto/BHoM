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



using BH.oM.Base;
using BH.oM.Structure.MaterialFragments;
using System.ComponentModel;
using BH.oM.Quantities.Attributes;

namespace BH.oM.Structure.SectionProperties
{
    [Description("Cable section to be used on Bars. Defined by cable diameter, number of cables, and total area.")]
    public class CableSection : BHoMObject, ISectionProperty, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("Material of the cable section.")]
        public IMaterialFragment Material { get; set; } = null;

        /***************************************************/
        /**** Properties - Section dimensions           ****/
        /***************************************************/

        [Description("How many cables make up the cross section.")]
        public int NumberOfCables { get; } = 0;

        [Description("Diameter of each cable in the section.")]
        public double CableDiameter { get; } = 0;

        [Description("Type of cable(s) in the section.")]
        public CableType CableType { get; } = CableType.FullLockedCoil;

        [Description("Breaking load of the cable section. For Number of cables > 1 this is assumed to be the total breaking load of all cables.")]
        public double BreakingLoad { get; } = 0;

        /***************************************************/
        /**** Properties - Section constants            ****/
        /***************************************************/

        [Area]
        [Description("Gross Area of the cross section" +
                     "\nFor Number of cables > 1 this is assumed to be the total area of all cables.")]
        public double Area { get; }

        [Length]
        [Description("Radius of Gyration about the local Y-Axis.")]
        public double Rgy { get; }

        [Length]
        [Description("Radius of Gyration about the local Z-Axis.")]
        public double Rgz { get; }

        [TorsionConstant]
        [Description("Torsion Constant.")]
        public double J { get; }

        [SecondMomentOfArea]
        [Description("Moment of Inertia about the local Y-Axis.")]
        public double Iy { get; }

        [SecondMomentOfArea]
        [Description("Moment of Inertia about the local Z-Axis.")]
        public double Iz { get; }

        [WarpingConstant]
        [Description("Warping Constant.")]
        public double Iw { get; }

        [SectionModulus]
        [Description("Elastic Modulus of the section about the local Y-Axis.")]
        public double Wely { get; }

        [SectionModulus]
        [Description("Elastic Modulus of the section about the local Z-Axis.")]
        public double Welz { get; }

        [SectionModulus]
        [Description("Plastic Modulus of the section about the local Y-Axis.")]
        public double Wply { get; }

        [SectionModulus]
        [Description("Plastic Modulus of the section about the local Z-Axis.")]
        public double Wplz { get; }

        [Length]
        [Description("Geometric centre of the section in the local Z direction.")]
        public double CentreZ { get; }

        [Length]
        [Description("Geometric centre of the section in the local Y direction.")]
        public double CentreY { get; }

        [Length]
        [Description("Z distance from the centroid of the section to top edge of the section.")]
        public double Vz { get; }

        [Length]
        [Description("Z distance from the centroid of the section to bottom edge of the section.")]
        public double Vpz { get; }

        [Length]
        [Description("Y distance from the centroid of the section to right edge of the section.")]
        public double Vy { get; }

        [Length]
        [Description("Y distance from the centroid of the section to Left edge of the section.")]
        public double Vpy { get; }

        [Area]
        [Description("Shear Area in the local Y direction.")]
        public double Asy { get; }

        [Area]
        [Description("Shear Area in the local Z direction.")]
        public double Asz { get; }


        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/


        //Main constructor setting all of the properties of the object
        public CableSection(
            IMaterialFragment material,
            int numberOfCables,
            double cableDiameter,
            CableType cableType,
            double breakingLoad,

            double area,
            double rgy,
            double rgz,
            double j,
            double iy,
            double iz,
            double iw,
            double wely,
            double welz,
            double wply,
            double wplz,
            double centreZ,
            double centreY,
            double vz,
            double vpz,
            double vy,
            double vpy,
            double asy,
            double asz)

        {
            Material = material;
            CableDiameter = cableDiameter;
            NumberOfCables = numberOfCables;
            CableType = cableType;
            BreakingLoad = breakingLoad;

            Area = area;
            Rgy = rgy;
            Rgz = rgz;
            J = j;
            Iy = iy;
            Iz = iz;
            Iw = iw;
            Wely = wely;
            Welz = welz;
            Wply = wply;
            Wplz = wplz;
            CentreZ = centreZ;
            CentreY = centreY;
            Vz = vz;
            Vpz = vpz;
            Vy = vy;
            Vpy = vpy;
            Asy = asy;
            Asz = asz;

        }

        /***************************************************/
    }
}


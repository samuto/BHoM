﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Geometry;
using BH.oM.Base;

namespace BH.oM.Acoustic
{
    /// <summary>
    /// BH.oM Acoustic Panel as Mesh. Please make sure you mesh is exploded into individual quadrangular or triangular mesh faces.
    /// </summary>
    public struct Panel
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        /// <summary>
        /// Mesh geometry of the panel
        /// </summary>
        public Mesh Geometry { get; set; }

        /// <summary>
        /// List of absorbtion coefficients by frequency
        /// </summary>
        public List<double> R { get; set; }


        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public Panel(Mesh mesh, List<double> r) // TODO Add check for planarity of panel
        {
            Geometry = mesh;
            R = r;
        }
    }
}

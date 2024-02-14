﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYBIM.Analysis
{
    public struct PointLoad
    {
        /// <summary>
        /// e global direction the load is being applied in.
        /// </summary>
        public Direction direction { get; set; }
        /// <summary>
        ///The numeric value (magnitude) of the load.
        /// </summary>
        public double P { get; set; }
        /// <summary>
        /// the place of the point load on the axial beam
        /// </summary>
        public double X { get; set; }
    }
}

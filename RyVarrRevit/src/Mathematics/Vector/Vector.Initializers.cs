﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyVarrRevit.Mathematics
{
    public partial class Vector
    {
        #region Matrix
        /// <summary>
        /// Converts 1 column / row matrix to vector.
        /// </summary>
        public static Vector FromMatrix(Matrix matrix)
        {
            return FromMatrix(matrix.InnerMatrix);
        }

        /// <summary>
        /// Converts 1 column / row matrix to vector.
        /// </summary>
        public static Vector FromMatrix(double[,] matrix)
        {
            return new Vector(VectorFunctions.ToVector(matrix));
        }
        #endregion

        #region Random
        /// <summary>
        /// Generates random vector of n-dimensions where entries range from 0 to the specified max value.
        /// </summary>
        public static Vector GenerateRandomVector(int dimension, double maxValue)
        {
            return new Vector(VectorFunctions.GenerateRandomVector(dimension, maxValue));
        }
        #endregion
    }
}

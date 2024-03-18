﻿using RYBIM.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using RYBIM.RevitAdapter;


namespace RYBIM.RC
{
    /// <summary>
    /// The main model(Singleton) that analyze the revit physical RC model.It work with the FEModel3D not independent.
    /// </summary>
    public partial class RCModel
    {
        #region Properties
        private static RCModel instance = null;
        /// <summary>
        /// The Singleton RCModel object
        /// </summary>
        public static RCModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RCModel();
                }
                return instance;
            }
        }
        /// <summary>
        /// A dictionary that save the analytical elements Ids linked with there physical elements Ids.
        /// </summary>
        public FEModel3D FEModel { get; set; }

        /// <summary>physical
        /// A dictionary that save the analytical elements Ids linked with there analytical elements Ids.
        /// </summary>
        public Dictionary<string, string> Elements { get; set; }

        #endregion
        private RCModel() { 
            FEModel = new FEModel3D();
            Elements = new Dictionary<string, string>();
        }
    }
}

﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RYBIM.RevitAdapter;
using RYBIM.Analysis;
using Autodesk.Revit.DB.Structure;
using RYBIM.RC;
using System.Data.Common;

namespace RYBIM
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Test : IExternalCommand
    {
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            try
            {
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Adapter.Init(commandData.Application);

                var model = new FEModel3D();
                model.AddNode(0, 0, 0, "n1");
                model.AddNode(10, 0, 0, "n2");
                model.add_material(29000.0, 11200, 0.3, 2.836e-4, null, "mat");
                model.AddMember("n1", "n2", "mat", 100, 100, 250, 20, "elem");
                model.def_support("n1", true, true, true, true, true, true);
                model.def_support("n2", true, true, true, true, true, true);

                var factors = new Dictionary<string, double>
                {
                    { "D", 1.4 }
                };
                // model.add_load_combo(factors, "1.4D");

                model.add_member_pt_load("elem", Direction.Fy, -100, 5);
                //model.Add_node_load("n2", Direction.FY, -100);

                model.Analyze();

                //model.Members["elem"].plot_Shear(Direction.Fy);
                //.Members["elem"].plot_Moment(Direction.Mz);
                //model.Members["elem"].plot_Deflection(Direction.Fy);

                using (Transaction transaction = new Transaction(Adapter.doc, "Create Curve"))
                {
                    transaction.Start();

                    var mems = Adapter.getAllAnalyticalMembers();

                    Adapter.CreateLineLoad(mems[0], mems[0].GetCurve().GetEndPoint(0), mems[0].GetCurve().GetEndPoint(1),
                        new XYZ(0,2000,0), new XYZ(0, 200, 0), new XYZ(0, 0, 0), new XYZ(0, 0, 0));
                    TaskDialog.Show("ss", $"{Adapter.getAllPointLoads().Count}");

                    transaction.Commit();
                }

            }

            catch (Exception e)
            {
                message = e.Message;
                return Autodesk.Revit.UI.Result.Failed;
            }

            return Autodesk.Revit.UI.Result.Succeeded;
        }
        /// </ExampleMethod>
    }
    /// <remarks>
    /// This application's main class. The class must be Public.
    /// </remarks>
    public class Main : IExternalApplication
    {
        // Both OnStartup and OnShutdown must be implemented as public method
        public Result OnStartup(UIControlledApplication application)
        {
            string assembly =  Assembly.GetExecutingAssembly().Location;
            UIAdapter.Init(application);
            UIAdapter.CreateTab("RYBIM");

            // RectangularConcrete panel
            UIAdapter.AddPanel("Members creation");
            UIAdapter.AddPushBtn(0, "Generate", "RYBIM.RevitCommands.MembersGenerator", "press to generate Analytical Members from your rectungular concrete elements.");
          

            //text panel
            UIAdapter.AddPanel("textPanel");
            UIAdapter.AddPushBtn(1, "btn", "RYBIM.Test", "press this btn");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            // nothing to clean up in this simple case
            return Result.Succeeded;
        }
    }
}
//TODO : equivalent frame method for flat slabs
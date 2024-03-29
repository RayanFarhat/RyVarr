﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using RyVarrRevit.Analysis;
using RyVarrRevit.RC;
using RyVarrRevit.RevitAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
namespace RyVarrRevit.RevitCommands
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class PlotMember : IExternalCommand
    {
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
          ref string message, ElementSet elements)
        {
            try
            {
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Adapter.Init(commandData.Application);

                Element selectedElement = Adapter.SelectElement();
                if (selectedElement == null)
                {
                    message = "No element selected.";
                    return Result.Cancelled;
                }
                var elems = RCModel.Instance.Elements;
                var id = selectedElement.Id.ToString();
                var value = UIAdapter.TextBoxes["combo name"].Value;
                string comboName = "";
                if (value != null)
                    comboName = value.ToString();

                if (!RCModel.Instance.FEModel.LoadCombos.ContainsKey(comboName))
                {
                    TaskDialog.Show("RyVarr Error", "Please put existing load combination!");
                    return Result.Failed;
                }
                // is element analytical member
                if (elems.ContainsKey(id))
                {
                    var m = RCModel.Instance.FEModel.Members[id];
                    plot(m, comboName);
                    return Result.Succeeded;
                }
                // is physical element
                if (elems.ContainsValue(id))
                {
                    var memberId = elems.FirstOrDefault(x => x.Value == id).Key;
                    var m = RCModel.Instance.FEModel.Members[memberId];
                    plot(m,comboName);
                    return Result.Succeeded;
                }
                TaskDialog.Show("RyVarr Error","Element is not related to the analytical model.");
                return Result.Failed;
            }
            catch (Exception e)
            {
                message = e.Message;
                return Autodesk.Revit.UI.Result.Failed;
            }
        }
        private void plot(Member3D m, string comboName)
        {
            string checkedButtonName = UIAdapter.RadioButtonGroups["axisRadio"].Current.Name;
            if (checkedButtonName == "toggleButtonX")
            {
                m.plot_Deflection(Direction.Fx,comboName);
            }
            else if (checkedButtonName == "toggleButtonY")
            {
                m.plot_Shear(Direction.Fy,comboName);
                m.plot_Moment(Direction.Mz,comboName);
                m.plot_Deflection(Direction.Fy,comboName);
            }
            else if (checkedButtonName == "toggleButtonZ")
            {
                m.plot_Shear(Direction.Fz, comboName);
                m.plot_Moment(Direction.My, comboName);
                m.plot_Deflection(Direction.Fz, comboName);
            }
        }
    }
}

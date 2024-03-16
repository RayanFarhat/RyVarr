﻿using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.DB;
using RYBIM.RevitAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RYBIM.RC
{
    public partial class RCModel
    {
        public void generateElements()
        {
            Nodes.Clear();
            Elements.Clear();
            AddColsElems();
            AddBeamsElems();
        }
        public void AddBeamsElems()
        {
            var beams = Adapter.getAllBeams();

            foreach (var beam in beams)
            {
                var line = Adapter.getTwoPointsCurveOfElement(beam);
                bool foundSharedP1 = false;
                bool foundSharedP2 = false;
                var p1 = line.p1;
                var p2 = line.p2;
                var newP1 = p1;
                var newP2 = p2;
                foreach (var p in Nodes)
                {
                    if (isClose(p1, p))
                    {
                        newP1 = p;
                        foundSharedP1 = true;
                    }
                    else if (isClose(p2, p))
                    {
                        newP2 = p;
                        foundSharedP2 = true;
                    }
                }
                if (foundSharedP1 && foundSharedP2)
                {
                    var member = Adapter.CreateAnalyticalMember(newP1, newP2, AnalyticalStructuralRole.StructuralRoleColumn);
                    Elements.Add(member.Id.ToString(), beam.Id.ToString());
                }
                else if (foundSharedP1)
                {
                    newP2 = new XYZ(p2.X, p2.Y, newP1.Z);
                    Nodes.Add(newP2);
                    var member = Adapter.CreateAnalyticalMember(newP1, newP2, AnalyticalStructuralRole.StructuralRoleColumn);
                    Elements.Add(member.Id.ToString(), beam.Id.ToString());
                }
                else if (foundSharedP2)
                {
                    newP1 = new XYZ(p2.X, p2.Y, newP2.Z);
                    Nodes.Add(newP1);
                    var member = Adapter.CreateAnalyticalMember(newP1, newP2, AnalyticalStructuralRole.StructuralRoleColumn);
                    Elements.Add(member.Id.ToString(), beam.Id.ToString());
                }
            }
        }
        public void AddColsElems()
        {
            var columns = Adapter.getAllColumns();

            foreach (var col in columns)
            {
                if (Nodes.Count == 0)
                {
                    var p = Adapter.getTwoPointsCurveOfElement(col);
                    var p1 = p.p1;
                    var p2 = p.p2;

                    Nodes.Add(p1);
                    Nodes.Add(p2);
                    var member = Adapter.CreateAnalyticalMember(p1, p2, AnalyticalStructuralRole.StructuralRoleColumn);
                    Elements.Add(member.Id.ToString(), col.Id.ToString());
                }
                // if there is existing elements, try finding shared node
                else
                {
                    bool found = false;
                    var line = Adapter.getTwoPointsCurveOfElement(col);
                    var p1 = line.p1;
                    var p2 = line.p2;
                    foreach (var p in Nodes)
                    {
                        if (isClose(p1, p))
                        {
                            var diffX = p.X - p1.X;
                            var diffY = p.Y - p1.Y;
                            var diffZ = p.Z - p1.Z;
                            var newP2 = new XYZ(diffX + p2.X, diffY + p2.Y, diffZ + p2.Z);
                            var member = Adapter.CreateAnalyticalMember(p, newP2, AnalyticalStructuralRole.StructuralRoleColumn);
                            Elements.Add(member.Id.ToString(), col.Id.ToString());
                            Nodes.Add(newP2);
                            found = true;
                            break;
                        }
                        else if (isClose(p2, p))
                        {
                            var diffX = p.X - p2.X;
                            var diffY = p.Y - p2.Y;
                            var diffZ = p.Z - p2.Z;
                            var newP1 = new XYZ(diffX + p1.X, diffY + p1.Y, diffZ + p1.Z);
                            var member = Adapter.CreateAnalyticalMember(newP1, p, AnalyticalStructuralRole.StructuralRoleColumn);
                            Elements.Add(member.Id.ToString(), col.Id.ToString());
                            Nodes.Add(newP1);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Nodes.Add(p1);
                        Nodes.Add(p2);
                        var member = Adapter.CreateAnalyticalMember(p1, p2, AnalyticalStructuralRole.StructuralRoleColumn);
                        Elements.Add(member.Id.ToString(), col.Id.ToString());
                    }
                }
            }
        }
    }
}
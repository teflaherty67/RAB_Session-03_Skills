#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Forms = System.Windows.Forms;

#endregion

namespace RAB_Session_03_Skills
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // setup open file dialog

            Forms.OpenFileDialog selectFile = new Forms.OpenFileDialog();
            selectFile.InitialDirectory = @"C:\";
            selectFile.Filter = "CSV file|*.csv|All files|*.*";
            selectFile.Multiselect = false;

            // open file dialog

            string fileName = "";
            if(selectFile.ShowDialog() == Forms.DialogResult.OK)
            {
                fileName = selectFile.FileName;
            }

            if(fileName != "")
            {
                // do something with the file
            }

            myStruct struct1 = new myStruct();
            struct1.Name = "test name";
            struct1.Description = "this is a description";
            struct1.Distance = 100;

            return Result.Succeeded;
        }

        struct myStruct
        {
            public string Name;
            public string Description;
            public double Distance;
        }
    }
}

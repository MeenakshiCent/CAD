using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

public class LayoutCommands
{
    [CommandMethod("DeleteLayoutByName")]
    public void DeleteLayoutByName()
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Database db = doc.Database;
        Editor ed = doc.Editor;

        // Ask user for layout name to delete
        PromptStringOptions pStrOpts = new PromptStringOptions("\nEnter layout name to delete: ");
        pStrOpts.AllowSpaces = true;
        PromptResult pStrRes = ed.GetString(pStrOpts);

        if (pStrRes.Status != PromptStatus.OK)
        {
            ed.WriteMessage("\nCommand canceled.");
            return;
        }

        string layoutName = pStrRes.StringResult;

        using (Transaction tr = db.TransactionManager.StartTransaction())
        {
            DBDictionary layoutDict = tr.GetObject(db.LayoutDictionaryId, OpenMode.ForRead) as DBDictionary;

            if (!layoutDict.Contains(layoutName))
            {
                ed.WriteMessage($"\nLayout '{layoutName}' does not exist.");
                return;
            }

            ObjectId layoutId = layoutDict.GetAt(layoutName);
            Layout layout = tr.GetObject(layoutId, OpenMode.ForWrite) as Layout;

            // You cannot delete Model layout or current layout
            if (layout.ModelType)
            {
                ed.WriteMessage("\nCannot delete Model layout.");
                return;
            }

            // Check if layout is current layout
            if (layout.LayoutName == LayoutManager.Current.Layout)
            {
                ed.WriteMessage("\nCannot delete the current active layout. Switch to a different layout first.");
                return;
            }

            // Erase the layout
            layout.Erase();

            tr.Commit();
            ed.WriteMessage($"\nLayout '{layoutName}' deleted successfully.");
        }
    }
}

using UnityEngine;
using UnityEditor;

public class MultiObjectRenameWizard : ScriptableWizard {
    public string oldToken;
    public string newToken;

    [MenuItem("Edit/Multi-Object Rename Wizard &f", false, -101)]
    public static void CreateWizard() {
        var sw = ScriptableWizard.DisplayWizard("Multi-Object Rename Wizard", typeof(MultiObjectRenameWizard), "Rename");
        sw.minSize = sw.maxSize = new Vector2(400, 135);
    }

    private void OnWizardCreate() {
        foreach(var selectedObject in Selection.gameObjects) {
            string objName = selectedObject.name;
            if(objName.Contains(oldToken)) {
                Undo.RecordObject(selectedObject, "Multi-Object Rename Wizard");
                selectedObject.name = objName.Replace(oldToken, newToken);
            }
        }
    }

    void OnWizardUpdate() {
        if(string.IsNullOrEmpty(oldToken)) isValid = false;
        else isValid = true;
    }
}

using UnityEngine;
using UnityEditor;

public static class RemoveAutoName {
    [MenuItem("Edit/Remove Auto-Name &r", false, -101)]
    public static void RemoveFromSelection() {
        RemoveFromObjects(Selection.gameObjects);
    }

    public static void RemoveFromObjects(params GameObject[] objects) {
        foreach(var selectedObject in objects) {
            string objName = selectedObject.name;
            char lastChar = objName[objName.Length - 1];
            int indexOfAddedString = objName.LastIndexOf(" (");
            int uniqueNumberLength = objName.Length - (indexOfAddedString + 3);
            string uniqueNumberString = objName.Substring(indexOfAddedString + 2, uniqueNumberLength);
            int uniqueNumber;
            if(lastChar == ')' && indexOfAddedString != -1 && int.TryParse(uniqueNumberString, out uniqueNumber)) {
                Undo.RecordObject(selectedObject, "Remove Auto-Name");
                selectedObject.name = objName.Substring(0, indexOfAddedString);
            }
        }
    }
}

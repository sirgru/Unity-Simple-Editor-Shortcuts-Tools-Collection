using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public static class DuplicateWithoutAutoName {
    private static int _lengthOfAddedString = "(Clone)".Length;
    private static List<int> _selection = new List<int>();

    [MenuItem("Edit/Duplicate Without Auto-Name &d", false, -101)]
    public static void DeselectEverything() {
        foreach(var selectedObject in Selection.gameObjects) {
            var newGo = GameObject.Instantiate(selectedObject, selectedObject.transform.parent);
            newGo.name = newGo.name.Substring(0, newGo.name.Length - _lengthOfAddedString);
            _selection.Add(newGo.GetInstanceID());
        }

        Selection.instanceIDs = _selection.ToArray();
        _selection.Clear();
    }
}

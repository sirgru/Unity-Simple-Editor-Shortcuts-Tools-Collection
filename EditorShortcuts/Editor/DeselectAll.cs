using UnityEditor;
using UnityEngine;

public static class DeselectAll {

    private static GameObject _previousSelection;

    [MenuItem("Edit/Deselect All &e", false, -101)]
    public static void DeselectEverything() {
        if(Selection.activeGameObject != null) {
            _previousSelection = Selection.activeGameObject;
            Selection.activeGameObject = null;
        } else {
            Selection.activeGameObject = _previousSelection;
        }
    }
}
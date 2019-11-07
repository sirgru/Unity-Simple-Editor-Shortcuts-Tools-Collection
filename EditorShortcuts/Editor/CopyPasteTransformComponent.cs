using UnityEngine;
using UnityEditor;

public static class CopyPasteTransformComponent {
    struct TransformData {
        public Vector3      localPosition;
        public Quaternion   localRotation;
        public Vector3      localScale;

        public TransformData(Vector3 localPosition, Quaternion localRotation, Vector3 localScale) {
            this.localPosition  = localPosition;
            this.localRotation  = localRotation;
            this.localScale     = localScale;
        }
    }

    private static TransformData _data;
    private static Vector3? _dataCenter;

    [MenuItem("Edit/Copy Transform Values &c", false, -101)]
    public static void CopyTransformValues() {
        if(Selection.gameObjects.Length == 0) return;
        var selectionTr = Selection.gameObjects[0].transform;
        _data = new TransformData(selectionTr.localPosition, selectionTr.localRotation, selectionTr.localScale);
    }

    [MenuItem("Edit/Paste Transform Values &v", false, -101)]
    public static void PasteTransformValues() {
        foreach(var selection in Selection.gameObjects) {
            Transform selectionTr = selection.transform;
            Undo.RecordObject(selectionTr, "Paste Transform Values");
            selectionTr.localPosition = _data.localPosition;
            selectionTr.localRotation = _data.localRotation;
            selectionTr.localScale = _data.localScale;
        }
    }

    [MenuItem("Edit/Copy Center Position &k", false, -101)]
    public static void CopyCenterPosition() {
        if(Selection.gameObjects.Length == 0) return;
        var render = Selection.gameObjects[0].GetComponent<Renderer>();
        if(render == null) return;
        _dataCenter = render.bounds.center;
    }

    [MenuItem("Edit/Paste Center Position &l", false, -101)]
    public static void PasteCenterPosition() {
        if(_dataCenter == null) return;
        foreach(var selection in Selection.gameObjects) {
            Undo.RecordObject(selection.transform, "Paste Center Position");
            selection.transform.position = _dataCenter.Value;
        }
    }
}

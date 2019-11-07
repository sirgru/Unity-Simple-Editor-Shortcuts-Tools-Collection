using UnityEditor;

public static class InvertActiveInHierarchy {
    [MenuItem("Edit/Invert Active &a", false, -101)]
    public static void Process() {
        foreach(var selectedObject in Selection.gameObjects) {
            selectedObject.SetActive(!selectedObject.activeSelf);
        }
    }
}

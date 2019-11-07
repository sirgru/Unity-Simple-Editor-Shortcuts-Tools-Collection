### Simple Editor Shortcuts Tools Collection ###
This is a small collection of simple tools to help in scene editing workflows. Duplicating, parenting and renaming are a big part of what we do when editing scenes, so it is worth automating as much as possible. All shortcuts are relevant for Windows systems.

**Deselect All** (Alt + e): Deselects everything in Hierarchy and Project views instead of having to click on an empty space. Useful in busy scenes.

**Invert Active** (Alt + a): Inverts the "active self" flag in hierarchy. Works on multiple objects in Hierarchy and Project views.

**Remove Auto-Name** (Alt + r): Removes the auto-naming addition on objects created by duplicating (Ctrl + d). For example duplicating object named "Rock" would create objects "Rock (1)", "Rock (2)" ... "Rock (156)". After duplicating, select the new objects and press the shortcut, all objects will now be named "Rock". This removes visual clutter and useless 'information'. Works only on Hierarchy duplicates, not Project duplicates. Supports Undo.

**Duplicate Without Auto-Name** (Alt + d): Duplicates selected objects in the hierarchy without adding the standard Unity postfix " (1)", " (2)" etc. This works only on objects in Hierarchy, having an object selected in Project view will instantiate it in the root of the scene, which may not be intended.

**Multi-Object Rename Wizard** (Alt + f): Opens a wizard that will take all selected objects and replace one string in their name with another. Objects that have the same name can be bulk-renamed in the Inspector without this tool, but objects that share only part of the name can not. Supports Undo.
  
**Copy / Paste Transform Values** (copy: Alt + c, paste: Alt + v): Copies the local values of the Transform component of a selected object; Pastes the value into all selected objects. Useful in situations where an object is duplicated, reparented and set to exact same transform values relative to parent as the original. Usual workflow would involve the lengthier Copy Component / Paste Component Values procedure.   

**Copy / Paste Center Position** (copy: Alt + k, paste: Alt + l): Copies the value of the center of the selected object. This information is obtained through the Renderer component's `bounds.center` properties. If the selected object has no renderer, no copy operation will be performed. This data is then pasted on all selected objects as the value of transofrm.position. Useful in cases where pivot of the source object is not centered. Supports Undo.   

**Rename Shortcut** (Ctrl + r): Shortcut to rename with `Ctrl + r` instead of `F2`.




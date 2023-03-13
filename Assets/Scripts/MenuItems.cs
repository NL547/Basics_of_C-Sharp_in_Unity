using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItems
{
    [MenuItem("Window/Editor Custom Window")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
    }
}

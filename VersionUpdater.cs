using UnityEditor;
using UnityEngine;

public class VersionController : EditorWindow
{
    static string currentVersion;

    [MenuItem("Tools/Update Version &#v")]
    static void Init()
    {
        currentVersion = Application.version;
        EditorWindow.GetWindow(typeof(VersionController), true, "Update Version").Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Atualizar Versão da Build");

        GUILayout.Space(15);
        currentVersion = EditorGUILayout.TextArea(currentVersion);

        if (GUILayout.Button("Atualizar"))
        {
            PlayerSettings.bundleVersion = currentVersion;
            Debug.Log($"Versão do projeto atualizada para: {Application.version}");
            this.Close();
        }
    }
}

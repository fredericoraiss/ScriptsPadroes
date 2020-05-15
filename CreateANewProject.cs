using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateANewProject : ScriptableWizard
{
    public static List<string> principaisPastasNomes = new List<string> {"_Resources","_Scenes","_Scripts", "Prefabs" };


    private void OnEnable()
    {
            
    }


    [MenuItem("Tools/Pastas Iniciais")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard("Create Project Folders", typeof(CreateANewProject), "Create");
    }

    private void OnWizardCreate()
    {
        foreach (string pasta in principaisPastasNomes)
        {
            string guid = AssetDatabase.CreateFolder("Assets", pasta);
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
        }
        AssetDatabase.Refresh();
    }
}

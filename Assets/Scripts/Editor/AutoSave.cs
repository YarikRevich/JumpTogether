using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor;

#if UNITY_EDITOR
[InitializeOnLoad]
public class AutoSave 
{
    static AutoSave()
    {
        EditorApplication.playModeStateChanged += SaveOnLoad;
    }

    private static void SaveOnLoad(PlayModeStateChange state)
    {
        if(state == PlayModeStateChange.ExitingEditMode)
        {
            Debug.Log("Auto-saving....");
            EditorSceneManager.SaveOpenScenes();
            AssetDatabase.SaveAssets();
        }
    }
}
#endif
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad] // Ensures the script runs once the Unity editor loads
public class DefaultSceneOpener
{
    static DefaultSceneOpener()
    {
        EditorApplication.delayCall += OpenDefaultScene;
    }

    static void OpenDefaultScene()
    {
        // Specify the path to your default scene
        string defaultScene = "Assets/FirstBotDemo/Demo/Scenes/Playground.unity";

        if (EditorSceneManager.GetActiveScene().path != defaultScene)
        {
            EditorSceneManager.OpenScene(defaultScene); 
        }
    }
}
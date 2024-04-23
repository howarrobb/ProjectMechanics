using System.IO;
using UnityEditor;

public class BuildScript
{
    // Method to build for Windows
    public static void PerformWindowsBuild()
    {
        string buildPath = "Builds/Windows/MyGame.exe";
        string[] scenes = { "Assets/ProjectMechanics.unity" }; // Add your scenes here
        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Android;

public static class AndroidReleaseSetup
{
    [MenuItem("OTAKU OPS/Release/Configure Android")]
    public static void Configure()
    {
        PlayerSettings.applicationIdentifier = "com.otakuops.game";
        PlayerSettings.bundleVersion = "0.1.0";
        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.targetSdkVersion =
            AndroidSdkVersions.AndroidApiLevel36;
        PlayerSettings.Android.minSdkVersion =
            AndroidSdkVersions.AndroidApiLevel26;

        PlayerSettings.SetScriptingBackend(
            BuildTargetGroup.Android,
            ScriptingImplementation.IL2CPP
        );

        PlayerSettings.Android.targetArchitectures =
            AndroidArchitecture.ARM64;

        AssetDatabase.SaveAssets();

        EditorUtility.DisplayDialog(
            "OTAKU OPS",
            "Android release settings applied.",
            "OK"
        );
    }
}
#endif

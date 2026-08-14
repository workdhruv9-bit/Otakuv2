using UnityEngine;

public class ReleaseConfig : MonoBehaviour
{
    public const string PackageName = "com.otakuops.game";
    public const string GameName = "OTAKU OPS";
    public const int TargetApi = 36;

    public string versionName = "0.1.0";
    public int versionCode = 1;
    public bool productionBuild = false;

    public string backendBaseUrl = "https://YOUR-BACKEND-HOST";
}

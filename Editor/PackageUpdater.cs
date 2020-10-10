#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.PackageManager;

namespace GameWorkstore.GooglePlayGames
{
    public class PackageUpdater
    {
        [MenuItem("Help/PackageUpdate/GameWorkstore.GooglePlayGames")]
        public static void TrackPackages()
        {
            Client.Add("git://github.com/GameWorkstore/playgamespluginforunity.git");
        }
    }
}
#endif
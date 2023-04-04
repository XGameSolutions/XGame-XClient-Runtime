

using UnityEditor;
using UnityEngine;

namespace XGame
{
    public static class SceneViewResidentTool
    {
        private static string k_FoldupKey = "SceneViewResidentTool_Flodup";
        private static Rect k_ToolRect = new Rect(1f, 1f, 100f, 50f);
        private static Rect k_ToolTitleRect = new Rect(1f, 1f, 100f, 22f);

        private static int s_Foldup = 0;


        [InitializeOnLoadMethod]
        static void InitializeOnLoadMethod()
        {
            SceneView.duringSceneGui += OnSceneGUI;
            EditorApplication.update += Update;
            s_Foldup = PlayerPrefs.GetInt(k_FoldupKey, 0);
        }

        static void Update()
        {
        }

        static void OnSceneGUI(SceneView sceneView)
        {
            Handles.BeginGUI();
            if (s_Foldup == 1)
            {
                GUI.Label(k_ToolTitleRect, "场景工具", GUI.skin.button);
            }
            else
            {
                GUILayout.BeginArea(k_ToolRect, "场景工具", GUI.skin.window);
                GUILayout.EndArea();
            }
            Handles.EndGUI();
            if (Event.current != null && k_ToolTitleRect.Contains(Event.current.mousePosition)
                && Event.current.button == 0 && Event.current.type <= EventType.MouseUp)
            {
                s_Foldup = s_Foldup == 1 ? 0 : 1;
                PlayerPrefs.SetInt(k_FoldupKey, s_Foldup);
            }
        }
    }
}
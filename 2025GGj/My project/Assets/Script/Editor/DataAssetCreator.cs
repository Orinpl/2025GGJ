using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor.SceneManagement;

public class DataAssetCreator : OdinEditorWindow
{
    public static DataAssetCreator Instance;


    [MenuItem("创建数据/打开窗口")]
    private static void Open()
    {
        GetWindow(typeof(DataAssetCreator), false, "数据创建");
        if (Instance != null)
        {
            Instance.Close();
        }
        Instance = GetWindow<DataAssetCreator>();
    }

    [Button("生成模板")]
    private void CreateDataAssetConfig()
    {
        DataAssetConfig.CreateConfigAsset("Test");
    }

}

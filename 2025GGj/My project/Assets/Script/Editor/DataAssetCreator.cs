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


    [MenuItem("��������/�򿪴���")]
    private static void Open()
    {
        GetWindow(typeof(DataAssetCreator), false, "���ݴ���");
        if (Instance != null)
        {
            Instance.Close();
        }
        Instance = GetWindow<DataAssetCreator>();
    }

    [Button("����ģ��")]
    private void CreateDataAssetConfig()
    {
        DataAssetConfig.CreateConfigAsset("Test");
    }

}

using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class DataAssetConfig : SerializedScriptableObject
{

    public static void CreateConfigAsset(string name, string directoryPath = "Assets/Data")
    {

        // ȷ��Ŀ���ļ��д���
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        string uniqueAssetPath = AssetDatabase.GenerateUniqueAssetPath($"{directoryPath}/{name}.asset");
        DataAssetConfig instance = ScriptableObject.CreateInstance<DataAssetConfig>();


        AssetDatabase.CreateAsset(instance, uniqueAssetPath);
        EditorUtility.SetDirty(instance);
        AssetDatabase.SaveAssets();
    }

    [LabelText("������������")]
    public string Name = "";

}

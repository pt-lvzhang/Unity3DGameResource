﻿using UnityEngine;
using UnityEditor;
using System.Collections;





public class AssetBundleMaker
{
	[MenuItem("Ab/make")]
	public static void Make()
	{
		Object asset = AssetDatabase.LoadAssetAtPath("Assets/example/prefab/item.prefab",typeof(Object));
		BuildPipeline.BuildAssetBundle(asset,null,Application.dataPath+"/"+asset.name+".unity3d",BuildAssetBundleOptions.CompleteAssets|BuildAssetBundleOptions.CollectDependencies,BuildTarget.iPhone);

		asset = AssetDatabase.LoadAssetAtPath("Assets/example/prefab/Terrain.prefab",typeof(Object));
		BuildPipeline.BuildAssetBundle(asset,null,Application.dataPath+"/"+asset.name+".unity3d",BuildAssetBundleOptions.CompleteAssets|BuildAssetBundleOptions.CollectDependencies,BuildTarget.iPhone);

		asset = AssetDatabase.LoadAssetAtPath("Assets/example/prefab/Button.prefab",typeof(Object));
		BuildPipeline.BuildAssetBundle(asset,null,Application.dataPath+"/"+asset.name+".unity3d",BuildAssetBundleOptions.CompleteAssets|BuildAssetBundleOptions.CollectDependencies,BuildTarget.iPhone);
		AssetDatabase.Refresh();
	}
}

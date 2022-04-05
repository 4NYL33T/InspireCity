using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


    public class assetManager : MonoBehaviour
    {

        public static assetManager Instance = null;

        Dictionary<string, AssetBundle> allAssets = new Dictionary<string, AssetBundle>();

        public string url;
        public string bundleName;
        uint version;
        bool loading = false;

        void Awake()
        {
            if (Instance == null)
            { // Экземпляр менеджера был найден
                Instance = this; // Задаем ссылку на экземпляр объекта
            }
            else if (Instance == this)
            { // Экземпляр объекта уже существует на сцене
                Destroy(gameObject); // Удаляем объект
            }

            DontDestroyOnLoad(this.gameObject);
        }

        void Start()
        {

        }

        void Update()
        {
            if (loading)
            {
                StartCoroutine(GetBundle(url + bundleName, version));
                loading = false;
            }
        }

        IEnumerator GetBundle(string asset, uint version)
        {
            if (!(allAssets.ContainsKey(asset)))
            {
                var request = UnityWebRequestAssetBundle.GetAssetBundle(asset, version);
                yield return request.SendWebRequest();
                AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
                allAssets.Add(asset, bundle);
                Debug.Log("loaded");
                request.Dispose();
            }
        }

        public GameObject GetAsset(string name, string bundlename)
        {
            GameObject newasset = Resources.Load("Prefabs/" + name) as GameObject;
            //if (newasset == null) {newasset = allAssets[bundlename].LoadAsset<GameObject>(name); }
            if (newasset == null) { Debug.Log("error - couldn't find object"); }

            return newasset;
        }

        //public GameObject GetPrefab(string name, string bundlename, Transform parent = null)

    }


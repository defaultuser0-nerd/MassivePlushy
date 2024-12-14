using BepInEx;
using System;
using UnityEngine;

namespace MassivePlushy
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {

        void Start()
        {
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        void OnGameInitialized()
        {
            GameObject plushy = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/MonkePlushyDisplay/MonkePlushy_Prefab Variant/MonkePlushy/");
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/MonkePlushyDisplay/table (3)/").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/MonkePlushyDisplay/MonkePlushy_Prefab Variant/Glass_Base/").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/MonkePlushyDisplay/MonkePlushy_Prefab Variant/Monke_Base/").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/MonkePlushyDisplay/").SetActive(true);
            plushy.transform.localScale = new Vector3(5f, 5f, 5f);
            plushy.transform.position = new Vector3(-63.5583f, 11.7282f, -82.86f);
            plushy.transform.localRotation = Quaternion.Euler(7.5f, 167.5869f, 0f);
        }
    }
}

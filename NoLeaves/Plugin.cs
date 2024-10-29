using BepInEx;
using UnityEngine;

namespace NoLeaves
{
    [BepInPlugin("ComenttGT", "NoLeaves", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Start() => GorillaTagger.OnPlayerSpawned(OnSpawn);

        private void OnSpawn()
        {
            GameObject[] allObj = FindObjectsOfType<GameObject>();
            for(int i = 0; i < allObj.Length; i++)
            {
                if (allObj[i].name == "fallleaves (combined by EdMeshCombinerSceneProcessor)")
                    allObj[i].SetActive(false);
                else
                    continue;
            }
        }
    }
}

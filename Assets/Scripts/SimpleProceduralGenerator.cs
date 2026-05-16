using System.Collections.Generic;
using UnityEngine;

public class SimpleProceduralGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;

    private void Awake()
    {
        GenerateLevel();   
    }

    private void GenerateLevel()
    {
        for(int i=0;i<10;i++)
        {
            GameObject obj = Instantiate(prefabs[i%prefabs.Count]);
            obj.transform.position = transform.position + transform.forward * i * 10;
        }
    }
}

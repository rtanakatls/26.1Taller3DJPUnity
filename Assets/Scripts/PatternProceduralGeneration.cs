using System.Collections.Generic;
using UnityEngine;

public class PatternProceduralGeneration : MonoBehaviour
{
    [SerializeField] private List<LevelPattern> patterns;
    private LevelPattern currentPattern;


    private void Awake()
    {
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        int seed = Random.Range(0, 10000);
        currentPattern = patterns[seed % patterns.Count];
        List<GameObject> prefabs = currentPattern.pattern;
        for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(prefabs[i % prefabs.Count]);
            obj.transform.position = transform.position + transform.forward * i * 10;
        }
    }
}

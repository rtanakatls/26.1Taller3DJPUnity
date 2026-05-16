using UnityEngine;

public class NoiseProceduralGenerator : MonoBehaviour
{

    [SerializeField] private int gridSize;
    [SerializeField] private float scale;
    [SerializeField] private GameObject prefab;
    [SerializeField] private float maxHeight;

    private void Awake()
    {
        Generate();
    }

    private void Generate()
    {
        float seed = Random.Range(0, 10000);
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                float height = Mathf.PerlinNoise(i / scale + seed, j / scale + seed) * maxHeight;
                Vector3 position = new Vector3(i, height / 2, j);
                GameObject obj = Instantiate(prefab);
                obj.transform.position = position;
                obj.transform.localScale = new Vector3(1, height, 1);
            }
        }
    }
}

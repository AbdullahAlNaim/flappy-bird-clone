using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float pipeStartTime = 2f;
    [SerializeField] float pipeIntervals = 10f;
    Vector3 newPipe;
    private void Start()
    {
        // 5 < y < 15
        // RandomPipeSpawn();
        InvokeRepeating("RandomPipeSpawn", pipeStartTime, pipeIntervals);
    }

    void Update()
    {
        
    }

    private void RandomPipeSpawn()
    {
        float pipeHeight = Random.Range(5f, 15f);
        newPipe = transform.position;
        newPipe.y = pipeHeight;
        Instantiate(prefab, newPipe, Quaternion.identity);
    }
}

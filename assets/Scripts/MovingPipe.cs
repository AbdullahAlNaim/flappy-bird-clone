using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    [SerializeField] float pipeSpeed;
    [SerializeField] float pipeStartTime = 2f;
    [SerializeField] float pipeIntervals = 10f;
    [SerializeField] float timekillPipe = 7f;
    [SerializeField] GameObject currentPipe;
    void Start()
    {
        InvokeRepeating("RandomPipeSpawn", pipeStartTime, pipeIntervals);
        Destroy(currentPipe, timekillPipe);
    }
    void Update()
    {
        transform.position -= new Vector3(pipeSpeed * Time.deltaTime, 0, 0);
    }

    // void DestroyPipe() 
    // {
        
    // }
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Camera Camera;
    public GameObject prefab, player;
    private Vector3 Offset;

    private void Start()
    {
        
        Offset = new Vector3(0, -1.3f, 1.5f);
    }
    public void CreatInstance()
    {
        Instantiate(prefab, player.transform.position + Offset, Quaternion.identity);
    }
}

using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreatInstance()
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.Value , Quaternion.identity);
    }
    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var v in obj.Vector3List)
        {
            Instantiate(prefab, v.Value, Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        
        Instantiate(prefab, obj.Vector3List[num].Value, Quaternion.identity);
        num++;
        if (num == obj.Vector3List.Count)
        {
            num = 0;
        }
    }
    public void CreateInstanceRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.Vector3List.Count - 1);
        Instantiate(prefab, obj.Vector3List[num].Value, Quaternion.identity);

    }
}

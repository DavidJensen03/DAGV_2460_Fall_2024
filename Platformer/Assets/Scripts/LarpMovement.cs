using UnityEngine;

public class LarpMovement : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 targetPosition; 
    public float moveDuration = 2f;
    public Vector3Data CameraPos;
    public Vector3Data playerPos;

    void Start()
    {
        Vector3 startPosition = playerPos.value;
        Vector3 targetPosition = CameraPos.value + new Vector3 (0,-1.55f,1.4f);

        StartCoroutine(MoveObjectCoroutine(startPosition, targetPosition, moveDuration));
    }


    public System.Collections.IEnumerator MoveObjectCoroutine(Vector3 start, Vector3 target, float duration)
    {
        float elapsedTime = 0f;  
        while (elapsedTime < duration)
        {
          
            transform.position = Vector3.Lerp(start, target, elapsedTime / duration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }


        transform.position = target;
    }
}

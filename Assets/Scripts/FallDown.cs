using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {

        if(transform.position.y < -4.5f)
            Destroy(gameObject);
        
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}

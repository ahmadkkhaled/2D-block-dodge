using UnityEngine;

public class BlockDestroy : MonoBehaviour
{

   
    void Update()
    {
        if(transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}

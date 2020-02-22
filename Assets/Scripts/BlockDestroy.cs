using UnityEngine;

public class BlockDestroy : MonoBehaviour
{

   
    void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}

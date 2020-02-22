using UnityEngine;

public class BlockGravity : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 100f;
    }


}


using UnityEngine;

public class coincollection : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        
        
    }

}

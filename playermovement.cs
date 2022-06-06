
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float addedforce;
    Vector3 movement;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.z = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        
        rb.AddForce(addedforce * Time.deltaTime, 0, 0);

        
    }
    private void LateUpdate()
    {
        transform.Translate(movement, Space.Self);
    }
    
}

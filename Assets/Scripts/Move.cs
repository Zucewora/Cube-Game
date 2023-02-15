using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f, hSpeed =10f;
    private Rigidbody _rb;
    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal")*hSpeed ;
        float v = Input.GetAxis("Vertical")*speed;
        _rb.velocity = transform.TransformDirection(new Vector3(-v,_rb.velocity.y,h));
    }
}

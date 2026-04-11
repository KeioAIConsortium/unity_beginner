//②Floor（ジャンプ台）でBallに力を加える
using UnityEngine;

public class JumpFloor : MonoBehaviour
{
    public float jumpForce = 8f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}

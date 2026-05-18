//Floor（ジャンプ台）でBallに力を加える
using UnityEngine;

public class JumpFloor : MonoBehaviour
{
    public float jumpForce = 8f;//どれくらいの力で飛ばすか

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")//飛ばしたいオブジェクト名を入れる(今回なら"Ball"というオブジェクトにのみ反応)
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}

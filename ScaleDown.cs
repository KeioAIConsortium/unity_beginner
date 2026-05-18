using UnityEngine;

public class ScaleDown : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.localScale -=
            Vector3.one * speed * Time.deltaTime;

        // 小さくなりすぎたら削除
        if (transform.localScale.x <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
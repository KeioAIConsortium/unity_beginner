//左右に移動
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 5f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);

        transform.position =
            startPos + new Vector3(x, 0, 0);
    }
}

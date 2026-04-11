//③時間差で動く装置
using UnityEngine;

public class DelayedMove : MonoBehaviour
{
    public float delay = 3f;
    public float speed = 3f;

    private float timer = 0f;
    private bool isMoving = false;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            isMoving = true;
        }

        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
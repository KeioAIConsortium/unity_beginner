//だんだん大きくなる
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.localScale +=
            Vector3.one * speed * Time.deltaTime;
    }
}

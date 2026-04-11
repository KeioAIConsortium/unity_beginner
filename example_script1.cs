//①一定時間後に消える床//
using UnityEngine;

public class FloorDisappear : MonoBehaviour
{
    public float delay = 3f; //何秒後に消えるか設定(3fなら3秒後)

    void Start()
    {
        Invoke("Disappear", delay);
    }

    void Disappear()
    {
        gameObject.SetActive(false);
    }
}


using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;

    void Update()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }
}

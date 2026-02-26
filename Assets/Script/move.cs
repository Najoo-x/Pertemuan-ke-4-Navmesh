using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}
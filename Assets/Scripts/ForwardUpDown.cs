using UnityEngine;

public class ForwardUpDown : MonoBehaviour
{
    public float speed = 5f;
    public float height = 1f;
    public float floatSpeed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        //use 'down' because the model is facing this direction, even though it's moving forward.
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * height;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
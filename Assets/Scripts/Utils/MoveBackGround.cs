using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    private float lenghth;
    private float startPos;
    private Transform cam;
    [SerializeField] float parallaxEffect;

    void Start()
    {
        cam = Camera.main.transform;
        startPos = transform.position.x;
        lenghth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = cam.position.x * (1 - parallaxEffect);
        float distance = cam.position.x * parallaxEffect;
        transform.position = new Vector3(
            startPos + distance, transform.position.y, transform.position.z
        );

        if (temp > startPos + lenghth)
        {
            startPos += lenghth;
        }
        else if (temp < startPos - lenghth)
        {
            startPos -= lenghth;
        }
    }
}

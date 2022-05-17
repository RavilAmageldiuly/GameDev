using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus1 : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody2D rb;
    float Xmin;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        // screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Xmin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < Xmin * 2)
        {
            Destroy(this.gameObject);
        }
    }
}

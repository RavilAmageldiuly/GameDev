using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPlusses : MonoBehaviour
{
    public GameObject plusPrefab;
    public float respawnTime = 1.0f;
    // private Vector2 screenBounds;

    float Xmin;
    float Xmax;
    float Ymin;
    float Ymax;

    // Start is called before the first frame update
    void Start()
    {
        // screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(bonuses());
        Xmin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        Xmax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        Ymin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        Ymax = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

    }

    private void spawnPlusses()
    {
        GameObject a = Instantiate(plusPrefab) as GameObject;
        a.transform.position = new Vector2(Xmax * 2, Random.Range(Ymin + 0.5f, -1));
        // print(Ymin + "; " + Ymax);
    }

    IEnumerator bonuses()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlusses();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

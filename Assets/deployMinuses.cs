using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployMinuses : MonoBehaviour
{

    public GameObject minusPrefab;
    public float respawnTime = 2.0f;

    float Xmin;
    float Xmax;
    float Ymin;
    float Ymax;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(minusses());
        Xmin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        Xmax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        Ymin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        Ymax = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    private void spawnPlusses()
    {
        GameObject a = Instantiate(minusPrefab) as GameObject;
        a.transform.position = new Vector2(Xmax * 2, Random.Range(Ymin + 0.5f, -1));
    }

    IEnumerator minusses()
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

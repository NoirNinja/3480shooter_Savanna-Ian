using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swooper : MonoBehaviour
{
    public bool goingUp;
    public float speed;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp)
        {
            transform.Translate(new Vector3(Mathf.Sin(Time.time * 3f) * .5f, 1, 0) * speed * Time.deltaTime);
        }
        else if (goingUp == false)
        {
            transform.Translate(new Vector3(Mathf.Sin(Time.time * 3f) * .5f, -1, 0) * speed * Time.deltaTime);
        }

        if (transform.position.y >= gameManager.verticalScreenSize * 1.25f || transform.position.y <= -gameManager.verticalScreenSize * 1.25f)
        {
            Destroy(this.gameObject);
        }
    }
}

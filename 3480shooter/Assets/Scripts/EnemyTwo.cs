using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Mathf.Sin(Time.time * 3f) *.5f , -1, 0) * Time.deltaTime * 2f);
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

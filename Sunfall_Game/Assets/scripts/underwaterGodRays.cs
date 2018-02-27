using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underwaterGodRays : MonoBehaviour {

    public float minTarget;
    public float maxTarget;

    float target;
    float from;

    float currentTiming;
    float time;
    SpriteRenderer render;

    private void Start()
    {
        render = GetComponent<SpriteRenderer>();
       
    }

    void Rescale()
    {
        time = 0f;
        from = target;
        target = Random.Range(minTarget, maxTarget);
        currentTiming = Random.Range(0.5f, 2.5f);
    }



    // Update is called once per frame
    void Update () {

        if (maxTarget > 0f) { 
            if (time >= currentTiming) {
                Rescale();
            }

            render.color = new Color(1f, 1f, 1f, Mathf.Lerp(from, target, time / currentTiming));
            time += Time.deltaTime;
        }

    }
}

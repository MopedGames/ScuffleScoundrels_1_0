using UnityEngine;
using System.Collections;

public class scaleAnimation : MonoBehaviour {

    private Vector3 startSize;

    public AnimationCurve animation;
    public float speed;
    public Vector3 endSize;

    private float timer;
    // Update is called once per frame

    void Awake () {
        startSize = transform.localScale;
    }

    void Update () {
        transform.localScale = Vector3.Lerp(startSize, endSize, animation.Evaluate (speed * timer));
        timer += Time.deltaTime;
    }

    public void Restart()
    {
        timer = 0;
        transform.localScale = Vector3.zero;
    }
}

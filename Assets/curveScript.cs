using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curveScript : MonoBehaviour
{
    public AnimationCurve animCurve;
    public Transform curveBoi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar pressed.");
            StartCoroutine(SmoothOperator());
        }
    }

    IEnumerator SmoothOperator()
    {
        Vector3 start = this.transform.position;

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;

            transform.position = Vector3.LerpUnclamped(start, curveBoi.position, animCurve.Evaluate(t));

            yield return null;
        }
    }
}

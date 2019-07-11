
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Tracker : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public int MarkTracker;

    // Update is called once per frame
    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = mark01.transform.position;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = mark03.transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 3)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

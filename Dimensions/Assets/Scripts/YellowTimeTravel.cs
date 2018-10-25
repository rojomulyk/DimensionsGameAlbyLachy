using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTimeTravel : MonoBehaviour
{

    public YellowTimeTravelList Yellow;
    public int colsSteps = 0;
    public int colscount;
    public int collides = 0;
    public int hits;
    public int colstimes = 0;

    void OnCollisionEnter(Collision collision)
    {
        colsSteps = (colsSteps + (1));

        if (Yellow.replay == (1))
        {
            collides = (collides + (1));
        }

    }

    public void Update()
    {
        colscount = (Yellow.cols.Count);

        if (Yellow.cols[colstimes] == Yellow.replay)
        {
            colstimes = (colstimes + (1));
            collides = (collides + (1));


            if (collides != colsSteps)
            {
                StartCoroutine (Seconds());
            }

        }

    }

    public IEnumerator Seconds();

}

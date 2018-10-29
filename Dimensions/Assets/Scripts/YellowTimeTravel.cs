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
    public int colsstay = 0;
    public int test;
    public int jump = 0;
    public int leaves = 0;
    public int colstimes20;

    void OnCollisionEnter(Collision collision)
    {
        colsSteps = (colsSteps + (1));

        //makes sure the numbers start on the same number
        if (Yellow.replay == (1))
        {
            collides = (collides + (1));
        }

    }

    void OnCollisionExit(Collision collision)
    {
        jump = (jump + (1));

        //makes sure the numbers start on the same number
        if (Yellow.replay == (1))
        {
            leaves = (leaves + (1));
        }

    }

    public void Update()
    {
        colscount = (Yellow.cols.Count);

        if (Yellow.cols[colstimes] == Yellow.replay)
        {
            colstimes = (colstimes + (1));
            collides = (collides + (1));
        }

        if (Yellow.jumps[colstimes20] == Yellow.replay)
        {
            colstimes20 = (colstimes20 + (1));
            leaves = (leaves + (1));
        }

        if (collides != colsSteps)
        {
            Debug.Log("lool");
        }

        if (leaves != jump)
        {
            Debug.Log("lool");
        }

    }

}

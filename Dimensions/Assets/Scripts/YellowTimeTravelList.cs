using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTimeTravelList : MonoBehaviour {

    public GameObject Player;
    public Vector3 Vector;
    public List<Vector3> vecs = new List<Vector3>();
    public bool A = false;
    public bool B = false;
    public GameObject PrevSelf;
    public int next = 0;
    public bool C;
    public bool D;
    public List<int> cols = new List<int>();
    public int steps;
    public bool recording;
    public int replay;
    public bool replaying;
    public bool numcount;
    public YellowTimeTravel Yellow;

    public void Start()
    {
        A = false;
        B = false;
        D = true;
        recording = false;
    }

    private void FixedUpdate()
    {
        Vector = Player.transform.position;
    }

    void Update()
    {             
        if (B == false)
        {
            if (Input.GetKeyUp("i"))
            {
                A = true;
                recording = true;
            }
        }
        if (A == true)
        {
            StartCoroutine(Wait());
        }
        if (next > 97)
        {
            D = false;
        }
        if (vecs.Count > (98F)) {
            B = true;
            recording = false;
        }
        if (D)
        {
            if (B)
            {
                if (Input.GetKeyDown("u"))
                {
                    C = true;
                    next = next + 1;
                    StartCoroutine(Wait());
                    replaying = true;
                }
            }
        }  
    }

    public IEnumerator Wait()
    {
        if (B == false)
        {
            A = false;
            yield return new WaitForSeconds(0.07f);
            vecs.Add(Vector);
            steps = (steps + (1));
            A = true;
        }

        if (C)
        {
            C = false;            
            PrevSelf.transform.position = vecs[next];
            replay = (replay + (1));
            yield return new WaitForSeconds(0.07f);
            vecs.Remove(vecs[next]);
            C = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (recording)
        {
            cols.Add(steps);
        }
    } 
}

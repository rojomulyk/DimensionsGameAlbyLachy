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

    public void Start()
    {
        A = false;
        B = false;
        D = true;
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
                }
            }
        }  
    }

    public IEnumerator Wait()
    {
        if (B == false)
        {
            A = false;
            yield return new WaitForSeconds(0.07F);
            vecs.Add(Vector);
            A = true;
        }

        if (C)
        {
            C = false;            
            PrevSelf.transform.position = vecs[next];                        
            yield return new WaitForSeconds(0.07F);
            vecs.Remove(vecs[next]);
            C = true;
        }

    }
}

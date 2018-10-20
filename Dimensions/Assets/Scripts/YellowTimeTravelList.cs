using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTimeTravelList : MonoBehaviour {

    public GameObject Player;
    public Vector3 Vector;
    public List<Vector3> vecs = new List<Vector3>();
    public bool A = false;

    public void Start()
    {
        A = true;       
    }

    private void FixedUpdate()
    {
        Vector = Player.transform.position;
    }

    void Update()
    {
        if (A == true)
        {
            StartCoroutine(Wait());
        }
        if (vecs.Count > (100F)) {
            A = false;
        }
    }

    public IEnumerator Wait()
    {
        A = false;
        yield return new WaitForSeconds(0.1F);
        vecs.Add(Vector);
        A = true;       
    }
}

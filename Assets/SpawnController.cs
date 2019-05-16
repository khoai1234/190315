using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SpawnController : MonoBehaviour
{

    public GameObject police;
    public GameObject terrorist;
    public GameObject hostage1;
    public GameObject hostage2;


    public Transform spawnpointA;
    public Transform spawnpointB;
    public Transform spawnpointC;
    //khung bo
    public Transform spawnpointD;
    //con tim
    public Transform spawnpointE;
    public Transform spawnpointF;


    public InputField field1;
    public InputField field2;
    public InputField field3;
    public InputField field4;
    public InputField field5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                int f1 = 3;
                for (int i = 0; i < f1; i++)
                {
                    //GameObject PolA = Instantiate(police, spawnpointA.position, spawnpointA.rotation) as GameObject;
                    GameObject PolA = Instantiate(police, new Vector3(hit.point.x + UnityEngine.Random.Range(1, 5),
                         hit.point.y,
                         hit.point.z + UnityEngine.Random.Range(1, 5)), transform.rotation) as GameObject;

                }

                UnityEngine.Debug.Log("true" + hit.point);
            }

            //UnityEngine.Debug.Log(ray.dire);
        }
        // public int randomX = UnityEngine.Random.Range(0, 2);
        //public int randomZ = UnityEngine.Random.Range(0, 2);
    }

    public void OnClickEvent()
    {
        int f1, f2, f3, f4, f5;
        
        //int randomX = UnityEngine.Random.Range(0, 2);
        //int randomZ = UnityEngine.Random.Range(0, 2);
        f1 = Convert.ToInt32(field1.text);
        f2 = Convert.ToInt32(field2.text);
        f3 = Convert.ToInt32(field3.text);
        //SL khung bo
        f4 = Convert.ToInt32(field4.text);
        //SL con tim
        f5 = Convert.ToInt32(field5.text);
        //spawn police
        for (int i = 0; i < f1; i++)
        {
            GameObject PolA = Instantiate(police, spawnpointA.position, spawnpointA.rotation) as GameObject;
            //GameObject PolA = Instantiate(police, new Vector3 (spawnpointA.position.x + UnityEngine.Random.Range(0,2),0, spawnpointA.position.z + UnityEngine.Random.Range(0, 1)), spawnpointA.rotation) as GameObject;
        }

        for (int i = 0; i < f2; i++)
        {
            GameObject PolB = Instantiate(police, spawnpointB.position, spawnpointB.rotation) as GameObject;
            //GameObject PolB = Instantiate(police, new Vector3(spawnpointB.position.x + UnityEngine.Random.Range(0, 2), 0, spawnpointB.position.z + UnityEngine.Random.Range(0, 1)), spawnpointB.rotation) as GameObject;
        }

        for (int i = 0; i < f3; i++)
        {
            GameObject PolC = Instantiate(police, spawnpointC.position, spawnpointC.rotation) as GameObject;
            //GameObject PolC = Instantiate(police, new Vector3(spawnpointC.position.x + UnityEngine.Random.Range(0, 1), 0, spawnpointC.position.z + UnityEngine.Random.Range(0, 1)), spawnpointC.rotation) as GameObject;
        }

        for (int i = 0; i < f4; i++)
        {
            GameObject Terr = Instantiate(terrorist, spawnpointD.position, spawnpointD.rotation) as GameObject;
            //GameObject Terr = Instantiate(terrorist, new Vector3(spawnpointD.position.x + UnityEngine.Random.Range(0, 1), 0, spawnpointD.position.z + UnityEngine.Random.Range(0, 1)), spawnpointD.rotation) as GameObject;
        }

        for (int i = 0; i < f5; i++)
        {
            int x = UnityEngine.Random.Range(1, 2);
            if (x == 1)
            {
                GameObject Hosta1 = Instantiate(hostage1, spawnpointE.position, spawnpointE.rotation) as GameObject;
                Debug.Log("1");
            }
            if (x == 2)
            {
                GameObject Hosta2 = Instantiate(hostage2, spawnpointF.position, spawnpointF.rotation) as GameObject;
                Debug.Log("2");
            }
            x = 2;
            //GameObject PolA = Instantiate(police, spawnpointA.position, spawnpointA.rotation) as GameObject;
        }

    }
}

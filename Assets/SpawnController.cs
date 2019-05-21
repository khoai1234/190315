using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.Characters.ThirdPerson;

public class SpawnController : MonoBehaviour
{

    public GameObject police;
    public GameObject terrorist;
    public GameObject hostage1;
    public GameObject hostage2;
    public GameObject rescure;

    public GameObject Target1;

    public Transform spawnRes;
    public Transform spawnpointA;
    public Transform spawnpointB;
    public Transform spawnpointC;
    //khung bo
    public Transform spawnpointD;
    //con tim
    public Transform spawnpointE;
    public Transform spawnpointF;
    public Transform spawnpointH;

    public InputField field1;
    public InputField field2;
    public InputField field3;
    public InputField field4;
    public InputField field5;
    int x;
    Vector3 HostaSpawnPos;
    GameObject[] ResTeam;
    bool ResDeployed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int x = UnityEngine.Random.Range(1, 2);
        // public int randomX = UnityEngine.Random.Range(0, 2);
        //public int randomZ = UnityEngine.Random.Range(0, 2);
//        Vector3 HostaSpawnPos = new Vector3();
      //  HostaSpawnPos = spawnpointE.transform.position;
        // ;
      //  HostaSpawnPos.x += UnityEngine.Random.Range(-1, 2);
      //  HostaSpawnPos.z += UnityEngine.Random.Range(-1, 2);
      if (ResDeployed == true)
        {
            ResTeam = GameObject.FindGameObjectsWithTag("RTeam");

            foreach (GameObject x in ResTeam)
            {
                x.GetComponent<AICharacterControl>().target = Target1.transform;
            }
        }
    }


    public void OnClickButton2()
    {

        for (int i =0; i < 3; i++)
        {
            GameObject Rteam = Instantiate(rescure, new Vector3(spawnRes.position.x + UnityEngine.Random.Range(1, 5), spawnRes.position.y, spawnRes.position.z + UnityEngine.Random.Range(1, 5)), spawnRes.rotation) as GameObject;

        }

        ResDeployed = true;
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
            //GameObject PolA = Instantiate(police, spawnpointA.position, spawnpointA.rotation) as GameObject;
            GameObject PolA = Instantiate(police, new Vector3 (spawnpointA.position.x + UnityEngine.Random.Range(1,5),spawnpointA.position.y, spawnpointA.position.z + UnityEngine.Random.Range(1,5)), spawnpointA.rotation) as GameObject;

        }

        for (int i = 0; i < f2; i++)
        {
            //GameObject PolB = Instantiate(police, spawnpointB.position, spawnpointB.rotation) as GameObject;
            GameObject PolB = Instantiate(police, new Vector3(spawnpointB.position.x + UnityEngine.Random.Range(1,5), spawnpointA.position.y, spawnpointB.position.z + UnityEngine.Random.Range(1,5)), spawnpointB.rotation) as GameObject;
        }

        for (int i = 0; i < f3; i++)
        {
            //GameObject PolC = Instantiate(police, spawnpointC.position, spawnpointC.rotation) as GameObject;
            GameObject PolC = Instantiate(police, new Vector3(spawnpointC.position.x + UnityEngine.Random.Range(1,5), spawnpointA.position.y, spawnpointC.position.z + UnityEngine.Random.Range(1,5)), spawnpointC.rotation) as GameObject;
        }

        for (int i = 0; i < f4; i++)
        {
            //GameObject Terr = Instantiate(terrorist, spawnpointD.position, spawnpointD.rotation) as GameObject;
            //GameObject Terr = Instantiate(terrorist, new Vector3(spawnpointD.position.x + UnityEngine.Random.Range(0, 1), 0, spawnpointD.position.z + UnityEngine.Random.Range(0, 1)), spawnpointD.rotation) as GameObject;
            GameObject Terr = Instantiate(terrorist, new Vector3(spawnpointD.position.x + UnityEngine.Random.Range(0,20),spawnpointD.position.y,spawnpointD.position.z + UnityEngine.Random.Range(0,20)), spawnpointD.rotation) as GameObject;
        }

        for (int i = 0; i < f5; i++)
        {


            if (i % 2==1)
            {
                //GameObject Hosta1 = Instantiate(hostage1, spawnpointE.position, spawnpointE.rotation) as GameObject;
                Debug.Log("1");
                GameObject Hosta1 = Instantiate(hostage1, new Vector3(spawnpointE.position.x + UnityEngine.Random.Range(1,4), spawnpointE.position.y, spawnpointE.position.z + UnityEngine.Random.Range(1,4)), spawnpointE.rotation) as GameObject;
            }
//            if (x == 2)
            else
            {
                //GameObject Hosta2 = Instantiate(hostage2, spawnpointF.position, spawnpointF.rotation) as GameObject;
                Debug.Log("2");
                GameObject Hosta2 = Instantiate(hostage2, new Vector3(spawnpointF.position.x + UnityEngine.Random.Range(1,4), spawnpointF.position.y, spawnpointF.position.z + UnityEngine.Random.Range(1,4)), spawnpointF.rotation) as GameObject;
            }
           // x = 2;
            //GameObject PolA = Instantiate(police, spawnpointA.position, spawnpointA.rotation) as GameObject;
        }

    }
}

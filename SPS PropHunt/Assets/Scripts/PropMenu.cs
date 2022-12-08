using System;
using UnityEngine;

public class PropMenu : MonoBehaviour
{
    public GameObject pumpkin;
    public GameObject cauldron;
    public GameObject scarecrow;
    private Transform temp;
    private GameObject[] currentDisguise;

    void Start(){ currentDisguise = new GameObject[1];currentDisguise[0] = GameObject.FindGameObjectWithTag("Disguise");}

    void Update(){}

    public void change(){
        currentDisguise[0] = GameObject.FindGameObjectWithTag("Disguise");
    }

    public void BePumpkin(){ 
        temp = currentDisguise[0].transform; 
        Destroy(currentDisguise[0].gameObject);
        currentDisguise[0] = Instantiate(pumpkin, temp.position, temp.rotation, temp.parent);
    }

    public void BeCauldron(){ 
        temp = currentDisguise[0].transform; 
        Destroy(currentDisguise[0].gameObject);
        currentDisguise[0] = Instantiate(cauldron, temp.position, temp.rotation, temp.parent);
    }

    public void BeScarecrow(){ 
        temp = currentDisguise[0].transform; 
        Destroy(currentDisguise[0].gameObject); 
        currentDisguise[0] = Instantiate(scarecrow, temp.position, temp.rotation, temp.parent);
    } 
}

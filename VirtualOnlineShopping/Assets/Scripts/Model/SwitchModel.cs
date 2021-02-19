﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{

    public Vector3 spawnPosition;
    public GameObject femaleModel;
    public GameObject maleModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void removeModel()
    {
        GameObject currentModel = GameObject.FindGameObjectWithTag("Model");
        Destroy(currentModel); 
    }

    //public bool checkLoadingSameModel(string newModelGender)
    //{
    //    GameObject currentModel = GameObject.FindGameObjectWithTag("Model");
    //    if(currentModel.GetComponent<ModelInformation>().gender == newModelGender)
    //    {
    //        return true;
    //    }
    //  return false;
    //}

    public void spawnModelFemale()
    {
        //if (!checkCurrentModel("Female"))
        //{
            removeModel();
            Instantiate(femaleModel, spawnPosition, Quaternion.Euler(0, 0, 0));
        //}
        
    }

    public void spawnModelMale()
    {
        //if (!checkCurrentModel("Male"))
        //{
        removeModel();
        Instantiate(maleModel, new Vector3(-10.89f, 4.39f, 7.71f), Quaternion.Euler(0, 0, 0));
        //}

    }
}
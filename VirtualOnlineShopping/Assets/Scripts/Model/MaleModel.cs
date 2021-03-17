﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Model
{
    public class MaleModel : MonoBehaviour
    {
        
        private readonly Dictionary<string, string> boneDictionary = new Dictionary<string, string>()
        {
            {"MaleModel/armature/Stomach/ChestLeft", "MaleModel/armature/Stomach/ChestRight"},
            {"MaleModel/armature/HipLeft","MaleModel/armature/HipRight"},
            {"MaleModel/armature/WaistLeft","MaleModel/armature/WaistRight"},
            {"MaleModel/armature/LeftShoulderTop","MaleModel/armature/RightShoulderTop"}, 
            {"MaleModel/armature/NeckLeft","MaleModel/armature/NeckRight"}
        };

        private GameObject boneOne;
        private GameObject boneTwo;
        
        private readonly ModelInformation modelInformation = new ModelInformation();
        
        public void Start()
        {
            AssignBones();
            modelInformation.Start();
        }

        private void BoneList(string boneOneAddress, string boneTwoAddress, ICollection<GameObject> boneTotalList)
        {
            boneOne = GameObject.Find(boneOneAddress);
            boneTwo = GameObject.Find(boneTwoAddress);
            
            boneTotalList.Add(boneOne);
            boneTotalList.Add(boneTwo);
        }

        private void AssignBones()
        {
            BoneList(boneDictionary.ElementAt(0).Key, boneDictionary.ElementAt(0).Value, modelInformation.bustBones);
            BoneList(boneDictionary.ElementAt(1).Key, boneDictionary.ElementAt(1).Value, modelInformation.hipBones);
            BoneList(boneDictionary.ElementAt(2).Key, boneDictionary.ElementAt(2).Value, modelInformation.waistBones);
            BoneList(boneDictionary.ElementAt(3).Key, boneDictionary.ElementAt(3).Value, modelInformation.shoulderBones);
            BoneList(boneDictionary.ElementAt(4).Key, boneDictionary.ElementAt(4).Value, modelInformation.neckBones);
        }

        public void Update()
        {
            modelInformation.UpdateHandleValue(modelInformation.bustObject, modelInformation.hipObject, modelInformation.waistObject, 
                modelInformation.shoulderObject, modelInformation.neckObject, 0.8f, 1.7f, 0.1961863f, 0.5f);
        }
    }
}


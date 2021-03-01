﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Clothing
{
    [Serializable]
    public class CategorySearchResult
    {
        public List<ClothingObject> products { get; set; }
    }
    
    [Serializable]
    public class ClothingObject
    {
        public int id { get; set; } 
        public string name{get; set;}
        public string colour{get; set;}
        public string brandName{get; set;}
        public int productCode{get; set;}
        public string url{get; set;}
        public string imageUrl{get; set;} 
        
    }
}
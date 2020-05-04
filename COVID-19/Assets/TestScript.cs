using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestScript : MonoBehaviour
{ 
   public  void ChangeName(TextMeshProUGUI example)
    {
        string test = "The new Hub";

        example.text = test;
    }


}

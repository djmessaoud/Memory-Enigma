using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PolicyController : MonoBehaviour
{
    public GameObject policyTextObject;
    public GameObject acceptPopupObject;
    // Start is called before the first frame update
    public void AcceptPolicy()
    {
        PlayerPrefs.SetInt("policyAccepted", 1);
        SceneManager.LoadScene("MenuScene");
    }

}

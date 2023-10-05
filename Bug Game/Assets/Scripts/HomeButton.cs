using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TapGesture tapGesture = this.GetComponent<TapGesture> () ;
        tapGesture.Tapped += TapGesture_Tapped ;
    }

    
    void TapGesture_Tapped (object sender, System.EventArgs e) {
        SceneManager.LoadScene("TitleScene");
    }
}

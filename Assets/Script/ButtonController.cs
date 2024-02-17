using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public Button button;
    public string newScene;
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

   private void OnButtonClick()
    {
        Debug.Log("ButtonClicked");
        SceneManager.LoadScene(newScene);

    }

}

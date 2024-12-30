using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelanjutnya : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            Application.Quit();
        }
    }
    public string SceneBerikutnya;
    // Start is called before the first frame update
  void OnCollisionEnter(Collision col)
  {
      if(col.gameObject.CompareTag("Player")){
          SceneManager.LoadScene(SceneBerikutnya);
      }
  }
}

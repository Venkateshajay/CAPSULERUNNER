using UnityEngine.SceneManagement;
using UnityEngine;

public class nextscence : MonoBehaviour
{
   void newscence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

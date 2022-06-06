using UnityEngine.SceneManagement;
using UnityEngine;

public class Startingscreen : MonoBehaviour
{
    public void starting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

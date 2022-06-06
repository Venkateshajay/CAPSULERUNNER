
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public float nextscencedelay;
    public GameObject completelevelui;
    bool endgames = false;
    public float restartdelay;
   
    public void completed()
    {
        completelevelui.SetActive(true);
        Invoke("newscence", nextscencedelay);
        
    }
    void newscence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void endgame()
    {
        if (endgames == false)
        {
            endgames = false;
            Invoke("restart", restartdelay);

        }


    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

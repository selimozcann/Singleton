using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public void ObjectActive()
    {
        Debug.Log("Object is Enabled");
    }

    public void DisActiveObject()
    {
        Debug.Log("Object is Disable");
    }
}

using UnityEngine;

public class Caller : MonoBehaviour
{
    public Reciever friend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello there my good friend");
        if (friend != null) 
            friend.call();

         
    }
}

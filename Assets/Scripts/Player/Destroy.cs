using UnityEngine;

public class DestroyObjectTimer : MonoBehaviour
{
    public GameObject Gate;
    public float Time;

    void Start()
    {
        Invoke("УдалитьОбъект", Time);
    }

    void УдалитьОбъект()
    {
        Destroy(Gate);
    }
}
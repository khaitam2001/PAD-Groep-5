using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FichesPosSet : MonoBehaviour
{
    [SerializeField]
    private List<Vector3> position = new List<Vector3>();

    public List<Vector3> Position
    {
        get { return position; }
    }
    public FichesPosSet()
    {

    }


    // Start is called before the first frame update
    void Start()
    {


        
    }

}

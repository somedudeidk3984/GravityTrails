using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && enemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Teleport : MonoBehaviour
//{
    //public int enemyCount;
    //public MeshRenderer mr;
    // Start is called before the first frame update
    //void Start()
    //{
        //enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    //}

    // Update is called once per frame
    //void Update()
    //{
        //if (enemyCount > 0)
        //{
            //mr.enabled = false;
        //}
        //else
        //{
            //mr.enabled = true;
        //}
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.gameObject.tag == "Player" && enemyCount == 0)
        //{
            //SceneManager.LoadScene(1);
        //}
    //}
//}

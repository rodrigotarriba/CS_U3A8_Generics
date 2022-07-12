using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{

    private void Start()
    {
        //Create a new component with a disabled CannonBall script
        NewObjectWithComponent<RandomScript01>();
        
        //Create a new component with a disabled SplitCannonBall script
        NewObjectWithComponent<RandomScript02>();


    }

    private void Update()
    {
        //Create a new game object with a Target component every time the space bar is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NewObjectWithComponent<RandomScript01>();
        }
    }

    /// <summary>
    /// Instantiate a new empty game object at 0,0,0 with a T component disabled.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    private void NewObjectWithComponent<T>() where T : MonoBehaviour
    {
        //instantiate a new gameobject with this component in it
        var newEmptyObject = new GameObject();
        newEmptyObject.transform.position = Vector3.zero;
        var newMonoBehaviour = (MonoBehaviour)newEmptyObject.AddComponent<T>();

        //disables the newly created component
        newMonoBehaviour.enabled = false;

        //log to the console the name of Type
        Debug.Log($"This MonoBehaviour is of type {typeof(T)}.");

    }




}

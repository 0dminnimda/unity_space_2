﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    static public float g = 1.0f;
    public float m = 1.0f;
    public float speed = 1.0f;
    private GameObject obj;
    private GameObject[] objs;

    static float LawOfGravity(float m1, float m2, float r) {
        float force = g * (m1 * m2) / (r * r);
        return force;
    }

    static float Dist(GameObject ob1, GameObject ob2) {
        float force = Vector3.Distance(ob1.transform.position, ob2.transform.position);
        return force;
    }

    private float CalculateForce(ArrayList objs) {
        float forse;
        foreach (GameObject obj in objs) {
            if (obj != this) {
                forse = LawOfGravity(this.m, obj.m, 1);
                Debug.Log(forse);
            }
            //СalculateForces(objs)
            //Debug.Log
        }
        return 1;
    }


    // Start is called before the first frame update
    void Start() {
        //Debug.Log(typeof(GameObject.FindGameObjectsWithTag("obj")));
    }

    // Update is called once per frame
    void Update() {
        objs = GameObject.FindGameObjectsWithTag("obj");
        foreach (GameObject obj in objs) {
            CalculateForce(objs);
            //Debug.Log
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 [RequireComponent(typeof(LineRenderer))]
public class LineAnimator : MonoBehaviour {
      LineRenderer lineRenderer;
      public Transform[] points;
      public Vector3[] positionsOfPoints;
 
 void Start(){
     lineRenderer = GetComponent<LineRenderer>();
     //UpdateLine(); // this can be called in update if your positions aren't static
 }
 
 public void UpdateLine()
 {
     List<Vector3> temp = new List<Vector3>();
     foreach(Transform t in points)
     {
          temp.Add(t.position);
     }
 
     positionsOfPoints = temp.ToArray();
     lineRenderer.SetVertexCount(positionsOfPoints.Length); // add this
     lineRenderer.SetPositions(positionsOfPoints);
   }
 }


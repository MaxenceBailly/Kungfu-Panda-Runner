using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segments;

    [SerializeField] int zPos = 50;
    [SerializeField] bool createNewSegment = false;
    [SerializeField] int segmentNum;

    // Start is called before the first frame update
    void Update()
    {
        if (createNewSegment == false)
        {
            createNewSegment = true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, segments.Length);
        Instantiate(segments[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        createNewSegment = false;
    }
}
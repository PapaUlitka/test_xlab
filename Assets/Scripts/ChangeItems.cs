using UnityEngine;

public class ChangeItems : MonoBehaviour
{
    public GameObject[] tools;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < tools.Length; ++i)
        {
            tools[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeItem()
    {
        int index = Random.Range(0, tools.Length);
        for (int i = 0; i < tools.Length; ++i)
        {
            tools[i].SetActive(i == index);
        }
    }
}

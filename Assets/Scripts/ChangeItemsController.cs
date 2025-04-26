using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItemsController : MonoBehaviour
{
    public ChangeItems[] changes;

    public void Change()
    {
        foreach (var change in changes)
        {
            change.ChangeItem();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Change();
        }
    }

}

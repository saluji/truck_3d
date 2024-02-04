using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ToggleGameObject : MonoBehaviour
{
    [System.Serializable]
    public class ToggleGroup
    {
        public Toggle toggle;
        public List<GameObject> objectsToEnable = new List<GameObject>();
        public List<GameObject> objectsToDisable = new List<GameObject>();
    }

    public List<ToggleGroup> toggleGroups = new List<ToggleGroup>();

    void Start()
    {
        // Make sure toggleGroups is not null
        if (toggleGroups.Count == 0)
        {
            Debug.LogError("Toggle groups are not assigned!");
            return;
        }

        // Subscribe to each toggle's onValueChanged event
        foreach (ToggleGroup group in toggleGroups)
        {
            if (group.toggle != null)
                group.toggle.onValueChanged.AddListener((isOn) => OnToggleValueChanged(group, isOn));
        }
    }

    void OnToggleValueChanged(ToggleGroup group, bool isOn)
    {
        // Check if the toggle is on
        if (isOn)
        {
            // Enable the desired GameObjects
            EnableObjects(group.objectsToEnable);

            // Disable the other GameObjects
            DisableObjects(group.objectsToDisable);
        }
        else
        {
            // If toggle is off, do the reverse
            EnableObjects(group.objectsToDisable);
            DisableObjects(group.objectsToEnable);
        }
    }

    void EnableObjects(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }

    void DisableObjects(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            if (obj != null)
                obj.SetActive(false);
        }
    }
}

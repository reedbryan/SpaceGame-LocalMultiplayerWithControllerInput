using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    public GameObject DamageMarkerPrefab; // Input in inspector

    /// <summary>
    /// Should be called from damageIntake script whenever a gameObject takes damage.
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="location"></param>
    public void showDamage(float damage, Vector2 location)
    {
        //Debug.Log(location);

        GameObject dmOb = Instantiate(DamageMarkerPrefab, location, transform.rotation);
        DamageMarker dm = dmOb.transform.GetChild(0).GetChild(0).GetComponent<DamageMarker>();

        dm.sendInfo(damage);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceValidator
{
    public static void NotNull(params object[] objsToCheck)
    {
        foreach(var obj in objsToCheck)
        {
            if (object.ReferenceEquals(obj, null))
            {
                throw new MissingReferenceException("Reference not found");
            }
        }
    }
}

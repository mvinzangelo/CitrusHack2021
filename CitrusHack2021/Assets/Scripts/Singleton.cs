using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<Flower> : Singleton where Flower : MonoBehaviour
{
    #region  Fields
    [CanBeNull]
    private static Flower _instance;

    [NotNull]
    // ReSharper disable once StaticMemberInGenericType
    private static readonly object Lock = new object();

    [SerializeField]
    private bool _persistent = true;
    #endregion

    #region  Properties
    [NotNull]
    public static Flower Instance
    {
        get
        {
            if (Quitting)
            {
                Debug.LogWarning($"[{nameof(Singleton)}<{typeof(Flower)}>] Instance will not be returned because the application is quitting.");
                // ReSharper disable once AssignNullToNotNullAttribute
                return null;
            }
            lock (Lock)
            {
                if (_instance != null)
                    return _instance;
                var instances = FindObjectsOfType<Flower>();
                var count = instances.Length;
                if (count > 0)
                {
                    if (count == 1)
                        return _instance = instances[0];
                    Debug.LogWarning($"[{nameof(Singleton)}<{typeof(Flower)}>] There should never be more than one {nameof(Singleton)} of type {typeof(Flower)} in the scene, but {count} were found. The first instance found will be used, and all others will be destroyed.");
                    for (var i = 1; i < instances.Length; i++)
                        Destroy(instances[i]);
                    return _instance = instances[0];
                }

                Debug.Log($"[{nameof(Singleton)}<{typeof(Flower)}>] An instance is needed in the scene and no existing instances were found, so a new instance will be created.");
                return _instance = new GameObject($"({nameof(Singleton)}){typeof(Flower)}")
                           .AddComponent<Flower>();
            }
        }
    }
    #endregion

    #region  Methods
    private void Awake()
    {
        if (_persistent)
            DontDestroyOnLoad(gameObject);
        OnAwake();
    }

    protected virtual void OnAwake() { }
    #endregion
}

public abstract class Singleton : MonoBehaviour
{
    #region  Properties
    public static bool Quitting { get; private set; }
    #endregion

    #region  Methods
    private void OnApplicationQuit()
    {
        Quitting = true;
    }
    #endregion
}

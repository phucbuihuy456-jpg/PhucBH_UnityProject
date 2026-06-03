using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]
    private float _maxHealth = 100;

    public float maxHealth
    {
        get
        {
            return _maxHealth;
        }
        set
        {
            _maxHealth = value;
        }
    }

    private float _currentHealth = 100;

    public float currentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            // Kiểm tra nếu máu giảm xuống 0 hoặc thấp hơn thì gọi hàm Die
            if (_currentHealth <= 0)
            {
                isAlive = false;
                //Die();
            }
        }
    }
    private bool _isAlive = true;
    public bool isAlive
    {
        get
        {
           return _isAlive;
        }
        set
        {
           _isAlive = value;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

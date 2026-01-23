using UnityEngine;

public class CodeConv : MonoBehaviour
{
    [SerializeField] public int health = 100;
    [SerializeField] private GameObject _deadEnemy;
    [SerializeField] EnemyDetection _enemyDetection;
    private GameObject[] _enemy;
    private float _knockBackTime = 0f;
    enum State
    {
        Alive,
        Dead
    }
    State state = State.Alive;
    void Start()
    {
        State state = State.Alive;
        Damage.damageDealt += TakeDamage;
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamage(0);
    }

    private void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _deadEnemy.transform.position = transform.position;
            Vector3 direction = _enemyDetection._player.transform.position - transform.position;
            _enemy = GameObject.FindGameObjectsWithTag("Enemy");
            State state = State.Dead;
            foreach (var i in _enemy)
            {
                Destroy(i);
            }
            if (_knockBackTime <= 0.2)
            {
                _deadEnemy.transform.position += -direction.normalized * 10f;
                _knockBackTime += Time.deltaTime;
            }
            Instantiate(_deadEnemy);
        }
    }
}

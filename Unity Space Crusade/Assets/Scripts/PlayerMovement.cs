using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    private float velocidadEnX = 2.5f; 
    private Rigidbody2D rb;
    private bool moviendoseHaciaDerecha = true;
    public SceneController sceneController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            moviendoseHaciaDerecha = !moviendoseHaciaDerecha;
        }

        float velocidadHorizontal = moviendoseHaciaDerecha ? velocidadEnX : -velocidadEnX;
        float movimientoX = velocidadHorizontal * Time.deltaTime;

        
        rb.position += new Vector2(movimientoX, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sceneController.gameOver();
        //Debug.Log(collision.gameObject.name);
    }
}

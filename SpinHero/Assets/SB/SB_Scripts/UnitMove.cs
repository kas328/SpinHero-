using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitMove : MonoBehaviour
{
    public FixedJoystick fixJoy;
    public float unitSpeed = 3.2f;

    Transform tr;
    public bool isTouchTop;
    public bool isTouchBottom;
    public bool isTouchRight;
    public bool isTouchLeft;
    GameObject SampleUnit;

    RaycastHit2D hit;

    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        float h = fixJoy.Horizontal;
        float v = fixJoy.Vertical;

        Vector2 moveDir = (new Vector2(0,1) * v) + (new Vector2(1, 0) * h);
        Debug.DrawRay(transform.position, transform.TransformDirection(moveDir), new Color(0, 1, 0), 0.7f);
        hit = Physics2D.Raycast(transform.position, transform.TransformDirection(moveDir), 0.7f, 1 << LayerMask.NameToLayer("wall"));

        if(hit.collider != null)
        {
            if (hit.collider.tag == "wall")
            {
                if (transform.position.x > 2.36) transform.position = new Vector2(2.36f,transform.position.y);
                if (transform.position.x < -2.36) transform.position = new Vector2(-2.36f,transform.position.y);
                if (transform.position.y > 4.58) transform.position = new Vector2(transform.position.x, 4.58f);
                if (transform.position.y < -2.1) transform.position = new Vector2(transform.position.x, -2.1f);
            }
        }
        tr.Translate(moveDir.normalized * Time.deltaTime * unitSpeed, Space.Self);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            switch (collision.gameObject.name)
            {
                case "wallTop":
                    isTouchTop = true;
                    break;
                case "wallBottom":
                    isTouchBottom = true;
                    break;
                case "wallRight":
                    isTouchRight = true;
                    break;
                case "wallLeft":
                    isTouchLeft = true;
                    break;
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            switch (collision.gameObject.name)
            {
                case "wallTop":
                    isTouchTop = false;
                    break;
                case "wallBottom":
                    isTouchBottom = false;
                    break;
                case "wallRight":
                    isTouchRight = false;
                    break;
                case "wallLeft":
                    isTouchLeft = false;
                    break;
            }
        }
    }
}

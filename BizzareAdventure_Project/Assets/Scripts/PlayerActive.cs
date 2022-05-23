using System;
using System.Collections;
using UnityEngine;

public class PlayerActive : MonoBehaviour
{
  public UnitState State;
  public bool IsAlive;
  public float MoveSpeed;

  private Animator playerAnim;
  private AudioSource playerAudio;

  private void Player_Movement(Vector2 moving)
  {
    moving.Normalize();
    playerAnim.SetFloat("AxisX", moving.x);
    playerAnim.SetFloat("AxisY", moving.y);

    if (moving.x != 0 || moving.y != 0)
    {
      playerAnim.setBool("IsMoving", true);
      if (!playerAudio.isPlaying)
      {
        playerAudio.Play();
      }
      State = UnitState.Move;
    }
    else
    {
      playerAnim.setBool("IsMoving", false);
      playerAudio.Stop();
      State = UnitState.Idle;
    }
  }

  private void Start()
  {
    playerAnim = GetComponent<Animator>();
    playerAudio = GetComponent<AudioSource>();
  }

  private void Update()
  {
    if (IsAlive)
    {
      var moveaway = Vector2.zero;
      moveaway.x = Input.GetAxis("Horizontal");
      moveaway.y = Input.GetAxis("Vertical");
      Player_Movement(moveaway);
    }
  }
}

public enum UnitState
{
  Idle, Move, Attack, Cast, Dead
}
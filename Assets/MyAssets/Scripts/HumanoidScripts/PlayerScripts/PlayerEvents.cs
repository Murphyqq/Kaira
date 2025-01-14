using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using MoreMountains.Feedbacks;
using System;

public class PlayerEvents : MonoBehaviour
{
    [SerializeField] private MMF_Player _attackFeedback;
    [SerializeField] private MMF_Player _moveFeedback;
    [SerializeField] private MMF_Player _jumpFeedback;
    [SerializeField] private MMF_Player _landFeedback;
    [SerializeField] private MMF_Player _dashFeedback;
    [SerializeField] private MMF_Player _dyingFeedback;
    [SerializeField] private MMF_Player _respawningFeedback;

    public void OnMove()
    {
        _moveFeedback?.PlayFeedbacks();
    }

    public void OnJump()
    {
        _jumpFeedback?.PlayFeedbacks();
    }

    public void OnLand()
    {
        _landFeedback?.PlayFeedbacks();
    }

    public void OnDash()
    {

        _dashFeedback?.PlayFeedbacks();
    }

    public void OnAttack()
    {
        _attackFeedback?.PlayFeedbacks();
    }

    public void OnDying()
    {
        _dyingFeedback?.PlayFeedbacks();
        //gameeventsReset
    }

    public void OnRespawning()
    {
        _respawningFeedback?.PlayFeedbacks();
    }
}

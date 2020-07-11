﻿using System.Collections;
using System.Collections.Generic;
using GMTK2020;
using UnityEngine;

namespace GMTK2020
{
    public enum WatchDirection
    {
        Up,
        Down,
        Left,
        Right,
    }

    public enum AnimType
    {
        Die, 
        Idle, 
        Shoot,
        Interaction,
        Dash,
        Move
    }
    
    
    [RequireComponent(typeof(Animator), typeof(Actor))]
    public class AnimationController : MonoBehaviour
    {
        private Animator _animator;
        private Actor _actor;
    
        private void Start()
        {
            _actor = GetComponent<Actor>();
            _animator = GetComponent<Animator>();
        } 
        
        public void AnimateActor(WatchDirection direction, AnimType animType, string actorName = "")
        {
            string animName = actorName;

            switch (animType)
            {
                case AnimType.Idle: animName += "Idle_"; break; 
                case AnimType.Move: animName += "Move_"; break; 
                case AnimType.Shoot: animName += "Shoot_"; break; 
                case AnimType.Dash: animName += "Dash_"; break; 
                case AnimType.Interaction: animName += "Interaction_"; break; 
                case AnimType.Die: animName += "Die_"; break; 
            }
            
            switch (direction)
            {
                case WatchDirection.Up: animName += "Up_"; break; 
                case WatchDirection.Down: animName += "Down"; break; 
                case WatchDirection.Left: animName += "Left"; break; 
                case WatchDirection.Right: animName += "Right"; break; 
            }
            
            _animator.Play(animName);
        }
    }
}
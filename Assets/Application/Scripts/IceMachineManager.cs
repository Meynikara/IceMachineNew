using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;
using System.Linq;

public class IceMachineManager : MonoBehaviour
{
    [Serializable]
    public class ConceptEvents
    {
        [Header("General")]
        public string _name;
        public string _label;
        public AudioClip _audioClip;
       

        [Header("Events")]
        public UnityEvent _commonEvents; // common events 
        public UnityEvent _vrEvents; // vr only events
        public UnityEvent _nonVREvents; // mobile webgl events

        [Header("Camera Movements")]
        public Transform _lookAt; // camera to look for non vr 
        public Transform _moveTo; // camera to look for non vr 

        public bool skip_unguided;
        public bool skip_guided;

        [Header("Reset Old Events")]
        public UnityEvent _resetCommonEvents; // common events 
        public UnityEvent _resetVREvents; // vr only events
        public UnityEvent _resetNonVREvents; // mobile webgl events
    }

    public List<ConceptEvents> _events;
    public TextMeshProUGUI _content;
    public AudioSource _source;

    public int _currentTaskId;
    ConceptEvents currentEvent;

    public void StartApp()
    {
        _currentTaskId = 0;
        NextTask(_currentTaskId);
      
    }
    public void NextTask()
    {
      
       // processPreviousTask();
        _currentTaskId += 1;
        NextTask(_currentTaskId);
       
      
    }

    public void NextTask(string _label)
    {
       
        if (currentEvent._label == _label)
        {
            processPreviousTask();
            _currentTaskId += 1;
            NextTask(_currentTaskId);
        }
        else
        {
            Debug.Log("Wrong stage");
        }

    }

    public void NextTask(int _taskId)
    {
        if (_currentTaskId != 0)
        {
            processPreviousTask();
        }

        _currentTaskId = _taskId;
        currentEvent = _events[_taskId];
       // processEvent();


    }

    public void processPreviousTask()
    {
        currentEvent._resetCommonEvents.Invoke();       
        currentEvent._resetVREvents.Invoke();
        currentEvent._resetNonVREvents.Invoke();
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Next procedure called...");
            NextTask(); 
        }
    }

    /*public void processEvent()
    {
        if (currentEvent != null)
        {
            Debug.Log(currentEvent.skip_unguided);
            if (currentEvent.skip_unguided == true && GuideType.typebool == false)
            {
                Debug.Log("skipped");
                NextTask();
            }
            else if (currentEvent.skip_guided == true && GuideType.typebool == true)
            {
                NextTask();
            }
            else
            {
                Debug.Log("not skipped");
                //////////////////
                if (MenuController.Master)
                {
                    if (GuideType.typebool && CellManager.Change == false)
                    {
                        Debug.Log("working -- guided");
                        currentEvent._instructionPanel.SetActive(true);
                        currentEvent._instructionPanelvr.SetActive(true);
                        _source.clip = currentEvent._audioClip;
                        _source.Play();
                    }
                }

                else
                {
                    if (GuideType.typebool)
                    {
                        Debug.Log("working -- guided");
                        currentEvent._instructionPanel.SetActive(true);
                        currentEvent._instructionPanelvr.SetActive(true);
                        _source.clip = currentEvent._audioClip;
                        _source.Play();
                    }
                }
                ////////////////////

                currentEvent._commonEvents.Invoke();
                if (PlatformChecker.GetPlatform() == Platforms.VR)
                {
                    currentEvent._vrEvents.Invoke();
                }
                else
                {
                    currentEvent._nonVREvents.Invoke();
                    if (currentEvent._lookAt != null && GuideType.typebool)
                    {
                        CancelInvoke("disableLookAt");
                        lookAt = true;
                        _currentRotation = currentEvent._lookAt;
                        // lookAt = false;
                    }
                    if (currentEvent._moveTo != null && GuideType.typebool)
                    {
                        CancelInvoke("disableLookAt");
                        _moveTo = true;
                        _currentPostion = currentEvent._moveTo;
                        // _moveTo = false;
                    }
                }

            }
        }
    }*/

}

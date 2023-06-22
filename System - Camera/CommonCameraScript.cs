using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonOfDamini.Enum;

namespace CommonOfDamini
{
    public class CommanCameraScript : MonoBehaviour
    {
        #region DECLARATION

        #region PUBLIC_VARIABLES
        #endregion

        #region HIDE_IN_INSPECTOR

        #endregion

        #region PROTECTED_VARIABLES

        #endregion

        #region PRIVATE_VARIABLES
        private Camera _camera;
        #endregion

        #region ENUMERATORS
        #endregion

        #endregion

        #region STRUCT

        #endregion

        #region GETTER/SETTER

        #endregion

        #region EVENT/DELEGATE

        #endregion

        #region COMMANLY_USING_VARIABLES

        [HideInInspector] public List<Coroutine> listOfStartedCoroutines;

        #endregion

        #region METHODS

        #region COMMONLY_USING_METHODS

        void Start()
        {
            //<VAR INIT...
            listOfStartedCoroutines = new List<Coroutine>();
            _camera = GetComponent<Camera>();
            //>VAR INIT...

            //<FUN CALLING...
            //>FUN CALLLING...

            //<COROUTINE…
            //>COROUTINE…

            //<EVENT DELEGATE INIT...
            //>EVENT DELEGATE INIT...
        }

        void ResetValues()
        {
            //<VAR INIT...
            //>VAR INIT...

            //<FUN CALLING...
            //>FUN CALLLING...

            //<COROUTINE…
            //>COROUTINE…

            //<EVENT DELEGATE INIT...
            //>EVENT DELEGATE INIT...
        }

        void OnGameOver()
        {
            //<VAR INIT...
            //>VAR INIT...

            //<FUN CALLING...
            //>FUN CALLLING...

            //<COROUTINE…
            //>COROUTINE…

            //<EVENT DELEGATE INIT...
            //>EVENT DELEGATE INIT...
        }

        void OnDestroy()
        {
            //Un Subscribe all subscribers....
        }

        void StopAllStartedCoroutines()
        {
            if (listOfStartedCoroutines == null)
            {
                Debug.LogError("list of coroutine is not assigned " + this);
                return;
            }
            for (int i = 0; i < listOfStartedCoroutines.Count; i++)
            {
                if (listOfStartedCoroutines[i] != null)
                {
                    StopCoroutine(listOfStartedCoroutines[i]);
                }
            }
        }

        #endregion

        #region GAME_SPECIFIC_METHODS

        #region UNITY_CALLBACKS

        #endregion

        #region PUBLIC_METHODS

        #endregion

        #region PRIVATE_METHODS

public static void FitToGivenSpriteForOrthoCamera(Camera camera, SpriteRenderer spriteRenderer, MeasurmentFactorsOf2DObj measurmentFactorsOf2DObj){
            if (!camera.orthographic)
            {
                Debug.LogError("Camera is not orthographic");
                return;
            }
switch(measurmentFactorsOf2DObj)
            {
                case MeasurmentFactorsOf2DObj.width:
                    camera.orthographicSize = spriteRenderer.SizeOfObject().x / (2f * camera.aspect);
                    break;

                case MeasurmentFactorsOf2DObj.height:
                    camera.orthographicSize = spriteRenderer.SizeOfObject().y / 2f;
                    break;
            }
        }

public static void FitToGivenDirectionForOrthoCamera(Camera camera, Vector3 targetPosition, Directions2D fitInDirection){
            if (!camera.orthographic)
            {
                Debug.LogError("Camera is not orthographic");
                return;
            }

            float halfHeight = 2f * camera.orthographicSize / 2;
            float halfWidth = 2f * camera.orthographicSize * camera.aspect / 2;
            int sign = (int) Sign.negative;

            switch (fitInDirection){
                case Directions2D.left:
                    camera.transform.position = targetPosition + (Vector3.left * sign) * halfWidth;  
                    break;

                case Directions2D.right:
                    camera.transform.position = targetPosition + (Vector3.right * sign) * halfWidth;
                    break;

                case Directions2D.up:
                    camera.transform.position = targetPosition + (Vector3.up * sign) * halfHeight;
                    break;

                case Directions2D.down:
                    camera.transform.position = targetPosition + (Vector3.down * sign) * halfHeight;
                    break;

                case Directions2D.onSamePos:
                    camera.transform.position = targetPosition;
                    break;
            }
            return;
        }
        #endregion

        #endregion

        #endregion

        #region COROUTINE

        #endregion
    }
}


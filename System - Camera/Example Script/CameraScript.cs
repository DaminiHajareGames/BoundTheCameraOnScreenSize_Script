using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonOfDamini;
using CommonOfDamini.Enum;

namespace FP11
{
    public class CameraScript : MonoBehaviour
    {
        #region DECLARATION

        #region PUBLIC_VARIABLES
        [Header("Fit Objects")]
        public SpriteRenderer cameraSizeFitToSpriteRenderer;
        public MeasurmentFactorsOf2DObj inRespectToMeasurmentSetCamera;
        public Directions2D cameraBoundryToStick;
        public float offsetForFittiongInGivenDir;
        public Vector3 offsetWhileSticking;
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

        #region CLASSES

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

        #endregion

        #region METHODS

        #region COMMONLY_USING_METHODS

        private void Update()
        {
            //<VAR INIT...
            listOfStartedCoroutines = new List<Coroutine>();
            _camera = GetComponent<Camera>();
            //>VAR INIT...

            //<FUN CALLING...
            CommanCameraScript.FitToGivenSpriteForOrthoCamera(_camera, cameraSizeFitToSpriteRenderer, inRespectToMeasurmentSetCamera);
            Vector3 targetPosition = cameraSizeFitToSpriteRenderer.BoundryPosition(cameraBoundryToStick, offsetForFittiongInGivenDir) + offsetWhileSticking;
            CommanCameraScript.FitToGivenDirectionForOrthoCamera(_camera, targetPosition, cameraBoundryToStick);
            //>FUN CALLLING...

            //<COROUTINE…
            //>COROUTINE…

            //<EVENT DELEGATE INIT...
            //>EVENT DELEGATE INIT...
        }

        void Start()
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
        #endregion

        #endregion

        #endregion

        #region COROUTINE

        #endregion
    }
}

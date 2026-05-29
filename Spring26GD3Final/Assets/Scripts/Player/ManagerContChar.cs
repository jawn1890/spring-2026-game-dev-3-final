using UnityEngine;
using UnityEngine.InputSystem;


namespace Player
{

    public class ManagerContChar : MonoBehaviour
    {
        //Component
        private CharacterController _charController;

        //Input Actions
        public InputActionAsset inputActions;

        //private InputAction _mSleepAction;

        //Animator
        //private Animator _animator;

        //move
        public float inputX;
        public float inputZ;
        public Vector3 vMovement;
        public float moveSpeed;

        private float _gravity;

        //Rotate Character
        private Transform _meshPlayer;
        //private int _isRunningHash;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            moveSpeed = 0.2f;
            _gravity = 0.5f;
            GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
            _meshPlayer = tempPlayer.transform.GetChild(0);
            _charController = tempPlayer.GetComponent<CharacterController>();
            //_animator = _meshPlayer.GetComponent<Animator>();
            //_isRunningHash = Animator.StringToHash("isRun");
        }

        // Update is called once per frame
        void Update()
        {
            inputX = Input.GetAxis("Horizontal");
            inputZ = Input.GetAxis("Vertical");
            //Debug.Log(inputX + inputZ);
            // if (inputX == 0 && inputZ == 0)
            // {
            //     _animator.SetBool(_isRunningHash, false);
            // }
            // else
            // {
            //     _animator.SetBool(_isRunningHash, true);
            // }
            //
            // if (_mSleepAction.WasPressedThisFrame())
            // {
            //     Sleep();
            // }

        }

        //look into CrossFadeInFixedTime for transitioning animations and blendTrees

        // public void Sleep()
        // {
        //     //Debug.Log("Go to sleep now!!");
        //     _animator.SetTrigger("triggerSleep");
        // }

        void FixedUpdate()
        {
            //Gravity
            if (_charController.isGrounded)
            {
                vMovement.y = 0f;
            }
            else
            {
                vMovement.y -= _gravity * Time.fixedDeltaTime;
            }

            //Movement
            vMovement = new Vector3(inputX * moveSpeed, vMovement.y, inputZ * moveSpeed);
            _charController.Move(vMovement);

            //Mesh Rotate
            if (inputX != 0 || inputZ != 0)
            {
                Vector3 lookDir = new Vector3(vMovement.x, 0, vMovement.z);
                _meshPlayer.rotation = Quaternion.LookRotation(lookDir);

            }

        }
        

        // private void OnEnable()
        // {
        //     inputActions.FindActionMap("Player").Enable();
        // }
        //
        // private void OnDisable()
        // {
        //     inputActions.FindActionMap("Player").Disable();
        // }
        //
        // private void Awake()
        // {
        //     _mSleepAction = InputSystem.actions.FindAction("Sleep");
        // }

    }
}
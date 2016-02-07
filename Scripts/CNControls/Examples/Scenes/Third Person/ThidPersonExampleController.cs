using UnityEngine;
using CnControls;

// This is merely an example, it's for an example purpose only
// Your game WILL require a custom controller scripts, there's just no generic character control systems, 
// they at least depend on the animations
//Link i use: //http://docs.unity3d.com/ScriptReference/CharacterController.SimpleMove.html

[RequireComponent(typeof(CharacterController))]
public class ThidPersonExampleController : MonoBehaviour
{

    public float MovementSpeed = 10f;
	float speed = 3.0f;
    private Transform _mainCameraTransform;
    private Transform _transform;
    private CharacterController _characterController;

    private void Start()
    {
        _mainCameraTransform = Camera.main.GetComponent<Transform>();
        _characterController = GetComponent<CharacterController>();
        _transform = GetComponent<Transform>();
    }

	float rotateSpeed = 0.8f;
	public void FixedUpdate()
	{
		// Move forward / backward
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		float curSpeed = speed * CnInputManager.GetAxis ("Vertical");
		_characterController.SimpleMove(forward * curSpeed);
	
		transform.Rotate(0, CnInputManager.GetAxis ("Horizontal") * rotateSpeed, 0);
	}
	











	//    public void FixedUpdate()
	//    {
	//        // Just use CnInputManager. instead of Input. and you're good to go
	//        var inputVector = new Vector3(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
	//        Vector3 movementVector = Vector3.zero;
	//
	//        // If we have some input
	//        if (inputVector.sqrMagnitude > 0.001f)
	//        {
	//           	movementVector = _mainCameraTransform.TransformDirection(inputVector);
	//          	movementVector.y = 0f;
	//            movementVector.Normalize();
	//			//Rotation
	//           _transform.forward = movementVector;
	//        }
	//
	//        movementVector += Physics.gravity;
	//		_characterController.Move(movementVector * Time.deltaTime * MovementSpeed);
	//    }

}

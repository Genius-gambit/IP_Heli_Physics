## Work Log

1. Implementation of the Indie Pixel Framework.
2. Fetching and Placement of the 3D Assets to the virtual environment.
3. Created one main script for the Rigidbody named IP_Base_RB_Controller.
4. Created three scripts which inherits from IP_Base_Rb_Controller and overrides the function HandlePhysics().
5. Created one script for the Base Inputs named IP_Base_HeliInput which fetches the values from the Input Manager.
6. Created two scripts(IP_Keyboard_HeliInput.cs, IP_XBox_HeliInput.cs) which inherits from the script(IP_Base_HeliInput) and gets the values based on their events.
7. Created a folder Baseline which handles the base functions for Rigidbodies - Forces, Hover, Torque.
8. Created a IP_Input_Controller.cs which handles both the devices components - Keyboard and Xbox.
9. Created a IP_Heli_Engine.cs which handles the number of engines for the helicopter or drones.
10. Created IP_Heli_Controller.cs which inherits the Rigidbody class and Requires an Input from IP_Input_Controller and runs the function Update Engine which leads towards the IP_Heli_Engine.cs.
11. Created a IP_Helicopter_Menus.cs which builds the Helicopter with all the components, engines and controls.
12. Created a IP_KeyboardHeli_InputEditor.cs and IP_XboxHeli_InputEditor.cs which helps in placing the values in the framework for debugging situations.

## Objective

1. ~~Introduction.~~
2. ~~Getting Setup.~~
3. ~~Designing our Code Structure.~~
4. ~~Introduction to Rigidbody.~~
5. ~~Creating a User Input.~~
6. ~~Creating the Helicopter Controller.~~
7. ~~Creating the Engine Component.~~
8. Handling the Rotor Blades.
9. Blurring the Textures with Houdini.
10. Flight Characteristics.
11. Building the Helicopter Camera.
12. Building a better Heli Camera.

## Learning Objectives

1. Setup our Basic Global Post Effects.
2. Learned how to work with Rigidbody.
3. Learned how to add forces.
4. Learned how to add torque.
5. Learned how to use Drag.
6. Learned how to calculate weight.
7. Setup Keyboard Inputs.
8. Setup our Xbox Inputs.
9. Built a Simple Editor to display out Input Data.
10. Created an Input Controller to swap inputs.
11. Created a base Rigidbody class.
12. Helicopter Controller working.
13. Learned how to use the Require Component Attribute.
14. Menu Options to Automate Setup.
15. Learned about Lift force on a Helicopter
16. Engine Script Up and Running.
17. Learned how to use Animation Curves.
18. Created a Sticky Throttle.

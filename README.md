# in-class-activities
## Devlogs
### W1
Hello world!
1. The Camera stays at its default starting location when making the camera not a child/component of the cat.
2. https://happychaosplayer.itch.io/w1-in-class-activity

### W2
1. R,G,B variables are float because when mixed together there are tens of thousands of color values. The variables do not contain any characters, meaning they cannot be strings, and are not conditional or true/false variables. We could use int theoretically but there are thousands of decimals we need making it unconventional and unoptimal.
2. The _bounce variable is int because the ball needs to bounce a specific NUMBER of times and cannot bounce in between 2 integers worth of times.
3. Semi-colon, its important because you use it so often you shouldn't forget it

### W3
Table #1
1. Return Type - string, Parameters - (int friendshipLevel, bool secret)
2. Return Type - void, Parameters - (float sanity)
3. Return Type - bool, Parameters - (float time)

Metaphor
Think of human body part as the class and the components can be referred to as body parts. Inside each body part includes smaller functions like methods from these components.

Part 3
When the value of ballRenderer.color *= 1.5f over and over again because the average of x and y are always above 2, the ball gets really bright because of very large color values.

### W4
Table #1
1. Added Rigidbody components to all objects that require physics such as gravity and drag, in this case we wanted the soccer ball to stay on the ground and bounce because of gravity, acting like an actual soccer ball, as well as the cat to move around like an actual cat that has physics. IsTrigger was enabled on anything we wanted to be invisible but still detect collisions, so we enabled it for the Goal object's box collider.
2. The Cat object's capsule collider was not properly aligned on the cat so we adjsuted it to align on the cat.

### W5
1. The class DeerW5 will need 2 member variables. One of them will be a variable under the class NavMeshAgent, and the second one will be the variable under the Transform class. These 2 together will let use the SetDestination method under the NavMeshAgent instance variable and input in the position of the Transform variable we created inside of the parameters.
2. Start() only
3. The method will just need a Start() method so that once the program begins the NavMeshAgent knows what object and its transform it should path towards, the NavMeshAgent will handle the movement every frame.

### W7
Category Assignment: Unity Engine
https://docs.google.com/document/d/1_tBpKPam_XOvv1F1GfLHlH7EezarfYFHKBYlpzPdyPM/edit?tab=t.0

1. Member variables should be the speed of the bat alongside the Transform class so we can access the target.
2. A StartChase() with the transform.position and Vector2.MoveTowards() method, and StopChase() which has nothing.
3. ABOVE

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
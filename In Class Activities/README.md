# in-class-activities
## Devlogs
### W1
Hello world!

### W2
1) What makes the r, g, and b variables floats is that they are numbers that go into the integers. ints are for integers (or full numbers), bools are true or false statments, and strings are for words. The _bounce variable is an int because the number of bounce3s the variable keeps track of counts up by ones (or in other words, in integers). The error that needed to be adjusted in step four was the addition of "f", the letter that signifies a float. Since the g variable is a float, "f" was necessary at the end of the statement.

### W5
In-class question: My question was how vectors were used within Unity, as at this point I had not yet started week four's minigame. My classmate responded by saying that there was already a designated component in Unity that kept track of the placement of objects using vectors.

Guesses for solving DeerW5:
What member variable(s) does this class need?
There will need to be a member variable for the transform the deer needs to go to and a member variable that tells the deer to go to this destination.

What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
The deer will not read the player's inputs, so Update() should not be needed. The method will also need [SerializeField] in order for it to show up as a component in the inspector.

What should the method(s) do?
The method should be able to manipulate the NavMeshAgent component to have the deer transform to the intended location.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
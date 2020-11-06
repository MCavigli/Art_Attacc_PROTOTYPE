# Art_Attacc_PROTOTYPE
This virtual reality experience is my final project for Holberton AR/VR specialization.

In this experience, the player can walk around a museum, enjoy famous works of art, and learn some general information about them. One of the works of art is an ancient and mysterious axe. Be careful not to pick it up though! The desire to knock over and destroy the other pieces of art might be too great if you do! 

This experience uses Oculus-Unity integration and is developed specifically for the Oculus Quest.

![Imgur](https://imgur.com/9IYYknn)

### Directions
Download the APK from [this link](). Follow the instructions on [this website]() to sideload the APK onto your Oculus Quest then fire up the experience.

You can **teleport** around the map using **the right or left thumbstick**. Push out to trigger the teleportation reticle, then move your thumb around to rotate the arrow and specify which direction you'd like to face.

If you look directly at a work of art you'll see a prompt that says "Press 'A' for more info". If you press **A** while you see this prompt, you'll be able to read information about that work of art. Press **A** again to dismiss. *(Note: this feature is a teeny bit finicky right now. When you want to dismiss the panel, you'll need to look away from the art work then press **A**.)*

**To grab the axe**, get close it it, aim your right hand at it and press the **grib button trigger** (it's the one your middle finger rests on). While holding down this button you can swing the axe around. Let go of the button to drop it.

### Goals with this project
Through this project I wanted to learn several different coding and Unity concepts. Here are some of the concepts included in this project:
* Collider interaction in VR
* Raycasters and how Oculus uses Gaze Pointers
* Working with OVR Player Controller
* Implementing distance grabbing
* Learning Unity's particle system and how it extends to scripting
* Becoming more familiar with audio in Unity
* Incorporating and altering 3rd-party assets.

### Incomplete Features
* ~~Information on the artwork. I'd like to set up a display that the user can read about each piece of art and an astonishing fact about it that really solidifies the horror over destroying it.~~ *This feature has been implemented successfully!*
* Unique destruction for each piece of art. Each work should have a unique destruction animation. The glass covering the paintings should crack, and the canvas should tear. Statues should crumble in a realistic way.
* Multiple methods of destruction. As of now there is an axe the user needs to find and use to destroy the other works. Ultimately there will be **dozens** of items that can be used to destroy the art. This includes spray paint, a squirt gun filled with ink, a sledgehammer, a gun, and a painter's pallette. With the pallette the user will be able to paint directly on the art and add to it. The pallette should interpret the artwork being defaced and provide the user will a color pallette that fits the specific artwork.
* Put this experience onto the web using WebXR, so the player can access the game directly from their headset's browser rather than loading an APK or going through a game store.
* There's no main menu or UI functionality right now. The experience begins without any sort of introduction.
* Left-hand functionality is off. You can teleport with the left thumbstick but the teleportation marker will extend from the right hand. Also, if you pick up the axe with your left hand it will be rotated the wrong way.
* Realistic sound effects. I put in a bunch of effects for the axe striking various objects, but I couldn't get the feel of the sound quite right so I chose to remove all sound effects and instead have an ethereal, looping, non-diagetic song in the background.

### Assets Used
[Museum](https://assetstore.unity.com/packages/3d/environments/urban/modern-gallery-82524) by Tirgames assets
[Statue of David](https://sketchfab.com/3d-models/david-by-michelangelo-8f4827cf36964a17b90bad11f48298ac) by jerryfisher on Sketchfab.com
[Mona Lisa](https://sketchfab.com/3d-models/mona-lisa-painting-42978b8f45704826a3198c77bc52f2e3) by 3Dee on Sketchfab.com
[Dwarven Axe](https://sketchfab.com/3d-models/dwarven-axe-27f3fa3562c2442bbfcbbd278d7b94bf) by zhixson on Sketchfab.com
[Manneken Pis statue](https://3dwarehouse.sketchup.com/model/56d02a85bd355fa8d2be5eda6a4888b8/Manneken-Pis-statue?hl=en) by 鄭佳 on sketchup.com
[Starry Night](https://sketchfab.com/3d-models/de-sterrennacht-nit-estelada-the-starry-night-4ba76c4b60444be2a0bf75435f3889b2) by dimoni on Sketchfab.com
[Sherbb's Particle Collection](https://assetstore.unity.com/packages/vfx/particles/sherbb-s-particle-collection-170798) by Sherbb
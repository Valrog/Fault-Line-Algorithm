# Fault-Line-Algorithm
An implementation of the fault line algorithm for heightmap generation in C#

<h2>Overwiev</h2>

This is a variation of the mentioned algorithm in _"Game Programming Gems 2"_, by Mark DeLoura. In the book, he describes
a method of generating fault fractals with moving points either upwards, or downwards, depending on the fault line.

This implementation differs from the algorithm in the book in that it manipulates only the vertices (pixels) above the generated fault line in a heightmap.
This is because we start with an empty (white) heightmap, and white color indicates the highest point. This approach leads to a glaring weakness in all generated terrains.

<h2>Flaws</h2>
As mentioned above, this algorithm only affects pixels that are above the fault line. This approach affects the end terrain in a significant way,
and that is the generated heightmap will almost certainly always feature a mountain range in upper and lower part of the map.

A possible solution to this shortcoming would be to start with a heightmap of medium height (i.e. every pixel would be set to a shade of grey) and
then affect every vertex, as DeLoura proposed. This would not have a forceful impact on time complexity, since the asymptotic complexity would remain **O(n)**.

<h2>Additional Notes</h2>

This project was first meant to be a plug-in for _Autodesk Maya_, but was shortly converted to a general heightmap generation tool. The initial idea was also to
implement a couple of different heightmap generation algorithms with ranging complexities and, perhaps, usefulness. Because of this, some legacy code remains that
references other methods of terrain generation inside the program.

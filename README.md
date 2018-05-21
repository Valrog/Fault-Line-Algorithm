# Fault Line Algorithm

<h4>Summary</h4>

This is an implemention of the mentioned algorithm in _"Game Programming Gems 2"_, by Mark DeLoura. In the book, he describes
a method of generating fault fractals with moving vertices on a mesh either upwards or downwards, depending on the fault line. This algorithm instead works on a Two-dimensional heightmap.

This implementation differs from the algorithm in the book in that it manipulates only the vertices (pixels) above the generated fault line in a heightmap.
This is because we start with an empty (white) heightmap, and white color indicates the highest point. This method has a significant shortcoming of generating a somewhat predictable terrain.

<h4>Flaws</h4>
As mentioned above, this algorithm only affects pixels that are above the fault line. This approach affects the end terrain in a significant way,
and that is the generated heightmap will almost certainly always feature a mountain range in upper and lower part of the map.

A possible solution to this shortcoming would be to start with a heightmap of medium height (i.e. every pixel would be set to a shade of grey) and
then affect every vertex, as DeLoura proposed. This would not have a forceful impact on time complexity, since the asymptotic complexity would remain **O(n^2)**.

<h2>Additional Notes</h2>

This project was first meant to be a plug-in for _Autodesk Maya_, but was shortly converted to a heightmap generation tool, since it makes more sense to generate heightmaps than manipulate an actual mesh.

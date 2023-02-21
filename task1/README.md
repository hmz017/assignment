### How to use 

- Fisrt add the image to project path inside (task1).
- open the jupyter file task1.ipynb.
- At cell number 3 you can add image name there.
- Run the project .

### how its work 

- Import the necessary libraries for the program, including OpenCV for computer vision tasks, NumPy for array manipulation, and Matplotlib for image visualization.

- Load the pre-trained face detection model from the files "architecture.txt" and "res10_300x300_ssd_iter_140000_fp16.caffemodel", which define the architecture and weights of the neural network. The model is loaded into the "model" variable.

- Load an image named "image" using OpenCV's imread function.

- Extract the width and height of the loaded image using the shape attribute of the image, and calculate the kernel size for the Gaussian blur filter based on the dimensions of the image.

- Preprocess the loaded image using the "blobFromImage" function provided by OpenCV's Deep Neural Network (dnn) module. This function applies mean subtraction and scales the image to a fixed size of 300x300 pixels, and the result is stored in the "blob" variable.

- Set the preprocessed image as input to the loaded model using the "setInput" function, and perform forward propagation to obtain the output of the model, which is stored in the "output" variable. The "squeeze" function is used to remove dimensions of size 1 from the output array.

- Iterate through the detected faces in the "output" array using a for loop, and check if the confidence level of the face detection is above 40%. If the confidence is above the threshold, blur the bounding box (face) using a Gaussian blur filter with a kernel size calculated in earlier code, and replace the original image with the blurred face.

- displaying the blurred image.



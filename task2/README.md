### how to use 

- Fisrt add the image to project path inside (task2).
- open the jupyter file task2.ipynb.
- At cell number 18 the final one you can add image name there.
- Run the project . 
note: run time 60 min on 50 epochs with 96% validation accuracy and 94% train accuracy. 
      run time 10 min on 7 epochs with 92% validation accuracy and 90% train accuracy.

### important 
 1- this link contain a file named medical mask you have to download it and save it in task2 :
https://www.kaggle.com/datasets/wobotintelligence/face-mask-detection-dataset
 2-save file task2 and task3 in the same folder please, thank you  

### how its work

- Imports necessary libraries and modules.

- Loads a CSV file ("trainMa.csv") that contains the filenames of images and their corresponding labels ("mask" or "without mask").

- Reads in the architecture and pre-trained weights for a convolutional neural network using OpenCV's dnn module.

- Defines a function ("getJSON") to load JSON files containing annotation data for the images.

- Defines a function ("adjust_gamma") to adjust the gamma correction of images.

- Extracts image patches from the input images based on the annotations in the JSON files and appends them to a list ("data") with their corresponding labels.Shuffles the list of data and splits it into training and validation sets.

- preparing two lists X and Y from the list data that contains tuples of features and labels.

- the X list that contains the features of the data is normalized by dividing it by 255.0, which scales the pixel values between 0 and 1. This normalization step is commonly used to ensure that the input data is in a suitable range for the neural network.

Then, the X list is reshaped to a 4D array with dimensions (n_samples, width, height, n_channels), where n_samples is the number of samples in the dataset, and width, height, and n_channels represent the dimensions of the images and the number of color channels. In this case, the images are 124 x 124 pixels with 3 color channels (RGB).
The Y list that contains the labels of the data is converted to a numpy array.

- Defines a Keras model using the Sequential API and adds several layers, including convolutional, pooling, dropout, and dense 
layers.

- Compiles the Keras model with binary cross-entropy loss and the Adam optimizer.

- Applies data augmentation to the training data using Keras' ImageDataGenerator.

- Trains the Keras model using the fit_generator method and the training and validation sets.

- Plots the training and validation accuracy and loss over epochs.

- save the model to use it in task3.

- Applies gamma correction to some sample images and plots the images with their predicted labels.








# PlingPlangPlong

**Project Goal**

The goal of this project was to produce an application that outputs a particular string dependent on how many factors out of 3, 5 and 7 that number has. More specifically, for a factor of 3, "Pling" was appended to the output, for 5 "Plang" was appended and finally for 7 "Plong" was appended. As such, numbers with multiple factors would expect an output which was a combination of these words concatenated together.

**Tools Used**

The StringBuilder class was used to create the response string based on the factors that the input number had. The primary benefit of using this class is that it is more efficient than otherwise manually appending an immutable string, since we are building up the string in a pre-allocated buffer. One of the most important tools used was SpecFlow being employed to achieve a full coverage of testing for this application, ensuring that positive and negative numbers were tested alongside the number 0. SpecFlow allows scenarios to be easily defined, for example "A number has no factors out of 3, 5 and 7" and the subsequent GIVEN WHEN THEN statements allow for easily readable tests.

![alt text](https://github.com/OliverLawrenceOvery/PlingPlangPlong/blob/main/RaindropsExercise/SpecFlow.png)


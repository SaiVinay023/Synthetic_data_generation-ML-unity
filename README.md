
HDRP project created in Unity 2020.3.21f1 using Perception 0.8.0-preview.4
====
# Unity_synthetic_datageneration_1

======


 Unity Synthetic Data Generation

This project is an HDRP (High Definition Render Pipeline) project created in Unity 2020.3.21f1 using the Perception 0.8.0-preview.4 package. It is designed for generating synthetic data for various computer vision tasks.

 Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Customization](#customization)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

Introduction

This repository contains a Unity project for generating synthetic datasets. The project leverages Unity's Perception package to create labeled data for machine learning and computer vision applications. It supports various types of labeling including 2D bounding boxes, 3D bounding boxes, semantic segmentation, and key point labeling.

Prerequisites

Before you begin, ensure you have met the following requirements:

- You have installed Unity Hub. 
- You have installed Unity Editor version 2020.3.21f1.
- You have installed Git.
- (Optional) Git Large File Storage (LFS) for managing large files.

Installation

Follow these steps to set up the project on your local machine:

1. Clone the Repository

   ```sh
   git clone https://github.com/SaiVinay023/unity-syntheticdata-generation.git
   cd unity-syntheticdata-generation
   ```

2. Install Unity Editor

   Download and install Unity Editor version 2020.3.21f1 from the [Unity Hub](https://unity3d.com/get-unity/download).

3. Open the Project

   Open the project folder with the installed Unity Editor. Note that the first time you open the project, it may take a longer time to import assets and set up the environment. Subsequent openings may take 15-45 minutes.

   - If you encounter any Zibra or other popups, simply close them.

Usage

To generate datasets using this project, follow these steps:

1. Open Unity Editor

   Open the Unity Editor and load the project.

2. Play the Scene

   Click the play button in the Unity Editor to start the simulation and begin generating data.

3. Generate Data

   The project supports the generation of the following types of labeled data:
   - 2D Bounding Box Labels
   - 3D Bounding Box Labels
   - Semantic Segmentation Labels
   - Key Point Labels

4. Customization and Adjustments

   The project allows for various customizations, such as adding new labelers and adjusting randomizers. See the [Customization](#customization) section for more details.

 Customization

The simulation is not fully automated, so you may need to add or adjust components manually:

- Adding New Labelers

  You can add new labelers to the main camera for specific data generation needs. 

- Adjusting Randomizers

  In the Perception Scenario column, you can add or modify randomizers to change specific materials, background occlusions, rotations, and other scene elements.

- Lighting Adjustments

  Adjust lighting randomizers to control the lighting conditions in your simulations.

**  Note: You can find the sample data sets in the repo for your reference which were taken in different environmental conditions.

For more detailed guidance on using and customizing the Perception package, refer to the [Perception Package Tutorial](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation%7E/Tutorial/Phase1.md).

Contributing

We welcome contributions to this project. To contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Make your changes and commit them (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Create a new Pull Request.

License

This project is licensed under the Apache-2.0 License. See the `LICENSE` file for more details.

Acknowledgments

- [Unity](https://unity.com/)
- [Unity Perception Package](https://github.com/Unity-Technologies/com.unity.perception)
- [GitHub LFS](https://git-lfs.github.com/)

For further details or support, you can refer to the official Unity and GitHub documentation or contact the repository maintainers.

---

Feel free to check the Perception package link above and add any missing information or additional details as needed.

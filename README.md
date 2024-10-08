# Waste Recycling

## Project Overview

The Waste Recycling application simulates a waste management system that allows users to manage different types of garbage. It includes a `Dustbin` class for managing garbage disposal, with support for plastic and paper garbage, as well as the ability to check the contents of the dustbin and perform operations such as throwing out garbage and emptying the bin.

## Features

- **Garbage Management**: Add plastic and paper garbage to the dustbin.
- **Condition Checks**: Ensure that only cleaned plastic and squeezed paper can be disposed of.
- **Count Tracking**: Track the number of each type of garbage in the dustbin.
- **Display Contents**: View the current contents of the dustbin.
- **Empty Contents**: Clear all items from the dustbin.

## Getting Started

### Prerequisites

- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) installed on your machine.
- Docker (optional, for containerized deployment).

### Installation Steps

1. **Clone the Repository**:
   Open a terminal or command prompt and run the following command:

   ```bash
   git clone https://github.com/yourusername/WasteRecycling.git

2.  **Navigate to the Project Directory**:
    
    ```bash
    cd WasteRecycling
    ```
    
3.  **Open the Project**: Open the project in your preferred code editor.
    
### Building and Running the Application

#### Docker Setup

1. Build the Docker image:

   ```bash
   docker build -t waste-recycling .

2.  Run the Docker container:
    
    ```bash
    docker run -p 80:80 waste-recycling` 
    
3.  Access the application: Open your web browser and go to `http://localhost` to view the application running in Docker.
    

### Usage

-   The application will create a blue dustbin.
-   You can throw out different types of garbage (e.g., plastic bags, crumpled paper).
-   The application checks the conditions for disposing of each type of garbage.
-   You can display the contents of the dustbin and empty it when needed.

### Technologies Used

-   **C#**: For implementing the application logic.
-   **.NET SDK**: For building and running the application.
-   **Docker**: For containerizing the application 
-  **Object-Oriented Programming (OOP)**: For designing the application structure, utilizing classes and objects for garbage management.

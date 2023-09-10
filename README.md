# Compose_web_app

Welcome to the **Compose_web_app** repository! This project demonstrates my proficiency in creating complex Dockerfiles and YAML files to orchestrate a simple CRUD (Create, Read, Update, Delete) web application. The application comprises a backend API built with .NET Core and a frontend developed using Angular.

## Overview

### Docker Compose Configuration

This project's core strength lies in its Docker Compose configuration, which effectively manages multiple services. It showcases my ability to handle complex infrastructure with Docker Compose. These services include:

- **Database Service (db_kimur_container)**: Utilizing the official Microsoft SQL Server image, this service sets up a SQL Server database with environment variables for security and data persistence. 

- **Migrations Service (migrations_kimur_container)**: This service handles database migrations, ensuring the database schema remains up to date with the latest application changes.

- **Backend Service (be_kimur_container)**: The backend API, powered by .NET Core, is containerized with a custom Dockerfile and configured for health checks.

- **Seed Service (seed_kimur_container)**: This service seeds initial data into the database using a custom command.

- **Frontend Service (fe_kimur_container)**: The Angular frontend is containerized with a custom Dockerfile and relies on the backend service.

### YAML File Mastery

The `docker-compose.yaml` file is meticulously crafted to define services, networks, and volumes, illustrating my expertise in managing containerized infrastructure.

## Getting Started

To run this application locally, follow these steps:

1. Clone the repository:
   ```sh
   git clone https://github.com/kibonga/Compose_web_app.git
   ```

2. Navigate to the project directory:
   ```sh
   cd Compose_web_app
   ```

3. Build and start the Docker containers using Docker Compose:
   ```sh
   docker-compose up -d
   ```

4. Access the application:
   - Backend API: [http://localhost:5000](http://localhost:5000)
   - Frontend: [http://localhost:4200](http://localhost:4200)

## Explore and Contribute

Feel free to explore the code to understand the intricacies of the Dockerfiles and YAML configuration. Contributions and feedback are welcome.

For more details and access to the source code, visit the [Compose_web_app GitHub Repository](https://github.com/kibonga/Compose_web_app/).

Thank you for checking out this project!

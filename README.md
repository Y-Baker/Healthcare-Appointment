
<p align="center">
    <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&weight=900&size=34&pause=1000&center=true&width=435&lines=MedConnect+API" alt="head" />
</p>

## Project Description
The MedConnect API provides a backend for a healthcare appointment scheduling platform, enabling patients to book appointments with healthcare providers, manage their medical history, and receive notifications. It includes features for patient and provider management, appointment scheduling, and secure access to patient records.

<br />

## Table of Contents

* [Deployment](#deployment)
* [Getting Started](#getting-started)
* [Requirements](#requirements)
* [ER Diagram](https://github.com/user-attachments/assets/b927bcee-5f7d-42bd-a369-c74c5a772a98)
* [End Points](https://github.com/Y-Baker/alx-airbnb-project-documentation/blob/main/user-stories/README.md)
* [Authors](#authors-black_nib)

## Deployment
Try the MedConnect API live: [MedConnect API Swagger Documentation](https://medapi.runasp.net/swagger/index.html)

## Getting Started

1- Clone the repository
```bash
git clone https://github.com/Y-Baker/MedConnect-API.git
```

2- Configure Connection String
- Open `appsettings.json` file and update the `SQL-Server` string with your SQL Server connection string.

3- Update Database
```bash
dotnet ef database update
```

4- Run the API
```bash
dotnet run
```

5- Open Swagger
```
https://localhost:{port}/swagger/index.html
```

## Requirements

### Overview
* **Purpose**:
    * To provide a robust backend service for scheduling and managing healthcare appointments.
    *  It ensures seamless interaction between patients and healthcare providers, enhancing the overall healthcare experience.

* **Scope**:
    * **Patient Features**:
        * Register and create a personal profile.
        * Book and manage appointments with healthcare providers.
        * View and update medical history.
        * Receive appointment reminders and notifications.

    * **Healthcare Provider Features**:
        * Manage schedules and availability.
        * Access and update patient records securely.
        * Communicate with patients through notifications.

* **Audience**:
    * This documentation is intended for developers building web and mobile healthcare applications for clinics or hospitals.
    * It provides the necessary information to integrate and utilize the MedConnect API effectively..

* **Assumptions**:
    * Developers have a basic understanding of RESTful APIs and web development.
    * The API will be used in a secure environment with proper authentication and authorization mechanisms.

---

### Functional Requirements
* **User Management**:
    * **Register**:
        * Patients and healthcare providers can register for an account.
        * Requires basic information such as name, email, and password.
    * **Login**:
        * Users can log in to their account using email and password.
        * Returns an access token for authentication.

* **Patient Features**:
    * **Profile**:
        * Patients can view and update their personal information.
        * Includes fields like name, date of birth, and contact details.
    * **Medical History**:
        * Patients can view and update their medical history.
        * Includes past diagnoses, medications, and allergies.
    * **Appointments**:
        * Patients can view upcoming and past appointments.
        * Book appointments with healthcare providers.
        * Receive notifications and Confirm Appointment Updates.
        * Receive notifications and reminders for appointments.

* **Healthcare Provider Features**:
    * **Profile**:
        * Healthcare providers can view and update their personal information.
        * Includes fields like name, specialty, and contact details.
    * **Schedule**:
        * Healthcare providers can manage their availability and working hours.
        * Set appointment slots for patients to book.
    * **Patient Records**:
        * Healthcare providers can access and update patient records securely.
        * Includes medical history, diagnoses, and treatment plans.
    * **Appointments**:
        * Healthcare providers can Confirm or cancel appointments.
        * Reschedule appointments with patients.
        * Communicate with patients through notifications.

---

### Non-Functional Requirements
* **Security**:
    * All API endpoints require authentication using JWT tokens.
    * Patient and provider data is encrypted at rest and in transit.
    * Access to patient records is restricted to authorized healthcare providers.

* **JSON API**:
    * The API follows the JSON API specification for consistent response formatting.
    * Includes support for pagination, filtering, and sorting. (In The Future)

* **Error Handling**:
    * Errors are returned with appropriate HTTP status codes and error messages.
    * Detailed error messages are provided for debugging purposes.

* **Swagger Documentation**:
    * The API is documented using Swagger for easy reference and testing.
    * Includes detailed descriptions of endpoints, request parameters, and response formats.


## ER Diagram
![ER Diagram](https://github.com/user-attachments/assets/b927bcee-5f7d-42bd-a369-c74c5a772a98)

## Users Endpoints

### POST /api/Account/Register
* Register a new account.
* **Schema For Patient**:
    ```json
    {
        "name": "string",
        "userName": "string",
        "email": "user@example.com",
        "password": "string",
        "confirmPassword": "string",
        "birthDay": "2024-12-19",
        "address": "string",
        "gender": 1,
        "userType": 1
    }
    ```
* **Schema For Healthcare Provider**:
    ```json
    {
        "name": "string",
        "userName": "string",
        "email": "user@example.com",
        "password": "string",
        "confirmPassword": "string",
        "bio": "string",
        "shift": 1,
        "rate": 5,
        "userType": 2
    }
    ```

### POST /api/Account/Login
* Login to an existing account.
* **Schema**:
    ```json
    {
        "userName": "string",
        "password": "string"
    }
    ```

### POST /api/Account/ForgotPassword
* Request a password reset for an account.
* **Schema**:
    ```json
    {
        "email": "user@example.com"
    }
    ```

### POST /api/Account/ResetPassword
* Reset the password for an account.
* **Schema**:
    ```json
    {
        "password": "string",
        "confirmPassword": "string",
        "email": "user@example.com",
        "token": "string"
    }
    ```

### DELETE /api/profile
* Delete an account.

### GET /api/profile
* Get the profile of the current user.

### PUT /api/profile
* Update the profile of the current user.
* **Schema For Patient**:
    ```json
    {
        "name": "string",
        "email": "user@example.com",
        "birthDay": "2024-12-19",
        "address": "string",
        "gender": 1,
        "phoneNumber": "string"
    }
    ```
* **Schema For Healthcare Provider**:
    ```json
    {
        "name": "string",
        "email": "user@example.com",
        "phoneNumber": "string",
        "bio": "string",
        "shift": 1,
        "rate": 5,
        "photo": "binary"
    }
    ```

## Patients Functionalities

### GET /api/patients/{id}
* Get the profile of a patient.
* **Schema**:
    ```json
    {
        "id": 1
    }
    ```

### GET /api/patients/{id}/medical-history
* Get the medical history of a patient.

## Appointments Functionalities

### POST /api/appointments
* Book an appointment.
* **Schema**:
    ```json
    {
        "patientId": 1,
        "doctorId": 2,
        "date": "2024-12-20T10:00:00Z"
    }
    ```

### GET /api/appointments/{id}
* Get appointment details by ID.

### PUT /api/appointments/{id}/reschedule
* Reschedule an appointment.
* **Schema**:
    ```json
    {
        "newDate": "2024-12-21T15:00:00Z"
    }
    ```

### PUT /api/appointments/{id}/cancel
* Cancel an appointment.

### GET /api/appointments/toconfirm
* Get all appointments needing confirmation.

### PUT /api/appointments/{id}/confirm
* Confirm an appointment.

## Doctors Functionalities

### GET /api/doctors
* Get all doctors.

### GET /api/doctors/{doctorId}
* Get doctor details by ID.

### PUT /api/doctors/{doctorId}
* Edit doctor details.
* **Schema**:
    ```json
    {
        "name": "Dr. John Doe",
        "specialty": "Cardiology",
        "phone": "123-456-7890"
    }
    ```

### DELETE /api/doctors/{doctorId}
* Delete a doctor.

## Notifications Functionalities

### GET /api/notification
* Get all notifications.

### GET /api/notification/new
* Get new notifications.

### GET /api/notification/{id}
* Get a notification by ID.

### POST /api/notification/sent
* Send a notification.
* **Schema**:
    ```json
    {
        "recipientId": 1,
        "message": "Your appointment is confirmed.",
        "type": "info"
    }
    


<br />

## Authors :black_nib:
* [__Repo__](https://github.com/Y-Baker/MedConnect-API)
* __Yousef Bakier__ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
 &nbsp;&nbsp;[<img height="" src="https://img.shields.io/static/v1?label=&message=GitHub&color=181717&logo=GitHub&logoColor=f2f2f2&labelColor=2F333A" alt="Github">](https://github.com/Y-Baker)
* __Gamal Elbatawy__ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
 &nbsp;&nbsp;[<img height="" src="https://img.shields.io/static/v1?label=&message=GitHub&color=181717&logo=GitHub&logoColor=f2f2f2&labelColor=2F333A" alt="Github">](https://github.com/gamalgithue)
* __Reem Fadaly__ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
    &nbsp;&nbsp;[<img height="" src="https://img.shields.io/static/v1?label=&message=GitHub&color=181717&logo=GitHub&logoColor=f2f2f2&labelColor=2F333A" alt="Github">](https://github.com/reemfadaly)
* __Mahmoud Abdulmawlaa__ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
    &nbsp;&nbsp;[<img height="" src="https://img.shields.io/static/v1?label=&message=GitHub&color=181717&logo=GitHub&logoColor=f2f2f2&labelColor=2F333A" alt="Github">](https://github.com/mahmoud-40)
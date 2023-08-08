# Week11.Solutions

By: Stella Marie

## Technologies Used

- C# 12
- ASP.NET Core 6
  - EntityFrameworkCore
  - MySql

## Description

### ToDoList

Sample project for Week 11, modified for migrations and many-to-many relationships from Week 10 use of EF Core, Html helpers, and only one-to-many relationships, and Week 9, the initial setup for multiple controllers and use of static content. To implement many-to-many, an intermediate entity, ItemTags, is created between Items and the new table, Tags.

### DoctorOffice

DoctorOffice is an MVC web app for managing doctors, patients and their medical records, appointments, offices and insurance providers. The extended database design was based on Vertabelo's [Medical Appointment Booking App](https://vertabelo.com/blog/the-doctor-will-see-you-soon-a-data-model-for-a-medical-appointment-booking-app/). [Clinic Management](https://vertabelo.com/blog/clinic-management-system-data-model/) appeared closer to the assigned prompt, but incorporated authentication and authorization, which is not within this week's scope.

View ![Database Schema](./DoctorOffice/Clinic%20Management.png)